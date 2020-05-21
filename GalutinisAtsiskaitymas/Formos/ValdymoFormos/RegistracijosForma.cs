using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace GalutinisAtsiskaitymas
{
    public partial class RegistracijosForma : Form
    {
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nslau\Desktop\KaunasCodingSchool\GalutinisAtsiskaitymas\GalutinisAtsiskaitymas\UserDataBase.mdf;Integrated Security=True";

        private Action Beuzsidarant;

        public RegistracijosForma(Action beuzsidarant)
        {
            Beuzsidarant = beuzsidarant;
            InitializeComponent();

            BirthDateRegisterDTP.Format = DateTimePickerFormat.Custom;
            BirthDateRegisterDTP.CustomFormat = "dd-MM-yyyy";

            Binding();
        }

        private void RegistracijosForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            Beuzsidarant();
        }

        private void UzsidarantVaikui()
        {
            this.Close();
        }

        private void Binding()
        {
            BindingClass bind = new BindingClass();
            UserNameRegisterTB.DataBindings.Add("Text", bind, "UserName", true, DataSourceUpdateMode.OnPropertyChanged);
            UserNameRegisterTB.DataBindings.Add("ForeColor", bind, "ForeUser");
            PasswordRegisterTB.DataBindings.Add("Text", bind, "Password", true, DataSourceUpdateMode.OnPropertyChanged);
            PasswordRegisterTB.DataBindings.Add("ForeColor", bind, "ForePassword");
            PasswordRegister2TB.DataBindings.Add("Text", bind, "Password2", true, DataSourceUpdateMode.OnPropertyChanged);
            PasswordRegister2TB.DataBindings.Add("ForeColor", bind, "ForePassword2");
            EmailRegisterTB.DataBindings.Add("Text", bind, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
            EmailRegisterTB.DataBindings.Add("ForeColor", bind, "ForeEmail");
        }

        private void RegisterRegisterBtn_Click(object sender, EventArgs e)
        {
            DateTime birthDate = BirthDateRegisterDTP.Value;
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = now - birthDate;
            double days = timeSpan.TotalDays;
            double years = Math.Floor(days / 365);

            if (UserNameRegisterTB.Text != "" && PasswordRegisterTB.Text != "" && PasswordRegister2TB.Text != "" && EmailRegisterTB.Text != "")
            {
                if (UserNameRegisterTB.ForeColor == Color.Black && PasswordRegisterTB.ForeColor == Color.Black && PasswordRegister2TB.ForeColor == Color.Black && EmailRegisterTB.ForeColor == Color.Black)
                {
                    if (PasswordRegisterTB.Text == PasswordRegister2TB.Text)
                    {
                        if (years >= 12)
                        {
                            SqlConnection sql = new SqlConnection(ConnectionString);
                            string query = "Select *FROM UserInfo WHERE UserName = '" + UserNameRegisterTB.Text.Trim() + "'";
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sql);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            if (dataTable.Rows.Count == 1)
                            {
                                MessageBox.Show("Toks prisijungimo vardas jau egzistuoja");
                            }
                            else
                            {
                                UName.pname = EmailRegisterTB.Text;
                                DialogResult dr = MessageBox.Show("Norėdami prisijungti prie 'Galutinis atsiskaitymas programėles' patvirtinkite jog tai jūs", "Patvirtinimas", MessageBoxButtons.OKCancel);
                                if (dr == DialogResult.OK)
                                {
                                    Kodas kodas = new Kodas();
                                    kodas.Show();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Užsiregistruoti galite tik nuo 12 metų");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Slaptažodžiai neatitinka");
                    }
                }
                else
                {
                    MessageBox.Show("Neteisingai suvesti duomenys pažymėti raudonai");
                }
            }
            else
            {
                MessageBox.Show("Užpildykite duomenis");
            }
        }

        public void DuomenuIrasymas()
        {
            SqlConnection sql = new SqlConnection(ConnectionString);
            HashSalt hashSalt = HashSalt.GenerateSaltedHash(64, PasswordRegisterTB.Text);

            string querry = "INSERT INTO UserInfo(UserName, Email, BirthDate, Hash, Salt) VALUES(@UserName, @Email, @BirthDate, @Hash, @Salt)";
            SqlCommand command = new SqlCommand(querry, sql);
            command.Parameters.AddWithValue("@UserName", UserNameRegisterTB.Text);
            command.Parameters.AddWithValue("@Email", EmailRegisterTB.Text);
            command.Parameters.AddWithValue("@BirthDate", BirthDateRegisterDTP.Value);
            command.Parameters.AddWithValue("@Hash", hashSalt.Hash);
            command.Parameters.AddWithValue("@Salt", hashSalt.Salt);

            sql.Open();
            var atsakymas = command.ExecuteNonQuery();
            if (atsakymas < 0)
            {
                Console.WriteLine("Irasyti i duomenu baze nepavyko");
            }
            sql.Close();

            this.Close();
            Beuzsidarant();
        }
    }
}
