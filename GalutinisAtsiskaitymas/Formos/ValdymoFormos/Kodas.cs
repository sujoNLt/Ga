using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace GalutinisAtsiskaitymas
{
    public partial class Kodas : Form
    {
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nslau\Desktop\KaunasCodingSchool\GalutinisAtsiskaitymas\GalutinisAtsiskaitymas\UserDataBase.mdf;Integrated Security=True";
        Random rng;
        int kodukas;

        public Kodas()
        {
            InitializeComponent();
            rng = new Random();
            label1.Text += UName.pname;
            SiustiEmail();
        }

        private void SiustiEmail()
        {
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("galutinisatsiskaitymasinfo@gmail.com", "GalutinisAtsiskaitymas101")
            };

            kodukas = rng.Next(999, 9999);

            MailMessage message = new MailMessage();
            message.From = new MailAddress("galutinisatsiskaitymasinfo@gmail.com");
            message.To.Add(UName.pname);
            message.Subject = "Patvirtinimio kodas";
            message.Body = "Kodas: " + kodukas.ToString();

            smtp.Send(message);
        }

        private void PatvirtinitiBtn_Click(object sender, EventArgs e)
        {
            if (KodasTXT.Text == kodukas.ToString())
            {
                if (Application.OpenForms["RegistracijosForma"] != null)
                {
                    (Application.OpenForms["RegistracijosForma"] as RegistracijosForma).DuomenuIrasymas();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Pasitikrinkite ar gerai įvestas kodas");
            }
        }

     
}
}
