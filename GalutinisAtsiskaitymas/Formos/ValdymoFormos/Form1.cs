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
    public partial class Form1 : Form
    {
        string hash;
        string salt;
        string user;

        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nslau\Desktop\KaunasCodingSchool\GalutinisAtsiskaitymas\GalutinisAtsiskaitymas\UserDataBase.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            PasswordTB.MouseEnter += PasswordTBMouseEnter;
            PasswordTB.MouseLeave += PasswordTBMouseLeave;
        }

        private void UzsidarantVaikui()
        {
            this.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void PasswordTBMouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.PasswordChar = '\0';
        }

        private void PasswordTBMouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.PasswordChar = '*';
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            Action action = UzsidarantVaikui;
            RegistracijosForma registracijos = new RegistracijosForma(action);
            registracijos.Show();
            this.Hide();
        }

        public static bool VerifyPassword(string enteredPass, string storedHash, string storedSalt)
        {
            var saltBytes = Convert.FromBase64String(storedSalt);
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPass, saltBytes, 1000);
            return Convert.ToBase64String(pbkdf2.GetBytes(256)) == storedHash;
        }

        private void LogInBTN_Click(object sender, EventArgs e)
        {
            if (UserNameTB.Text != "" && PasswordTB.Text != "")
            {
                SqlConnection sql = new SqlConnection(ConnectionString);

                string query = "Select *FROM UserInfo WHERE UserName = '" + UserNameTB.Text.Trim() + "'";
                
                sql.Open();
                SqlCommand hashCommand = new SqlCommand(query, sql);
                SqlDataReader hashReader = hashCommand.ExecuteReader();
                while (hashReader.Read())
                {
                    user = hashReader["UserName"].ToString();
                    hash = hashReader["Hash"].ToString();
                    salt = hashReader["Salt"].ToString();
                    UName.uId = Convert.ToInt32(hashReader["Id"]);
                }

                bool isPassMatched = VerifyPassword(PasswordTB.Text, hash, salt);

                if (isPassMatched && UserNameTB.Text == user)
                {
                    UName.uname = UserNameTB.Text;

                    Action action = UzsidarantVaikui;
                    FormaPrisijungus formaPrisijungus = new FormaPrisijungus(action);
                    formaPrisijungus.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Pasitikrinkite įvestus duomenis");
                }
            }

        }
    }
}