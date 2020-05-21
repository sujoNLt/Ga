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
using System.Data.Linq;
using System.Diagnostics;

namespace GalutinisAtsiskaitymas
{
    public partial class AtmintiesZaidimas : Form
    {
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nslau\Desktop\KaunasCodingSchool\GalutinisAtsiskaitymas\GalutinisAtsiskaitymas\UserDataBase.mdf;Integrated Security=True";

        private Action Beuzsidarant;

        string score;
        Random rng = new Random();
        List<string> pav = new List<string>()
        {
            "=","=","R","R","S","S","!","!","#","#","l","l","~","~","I","I"
        };
        Label firstClicked, secondClicked;

        Stopwatch stopwatch;

        public AtmintiesZaidimas(Action beuzsidarant)
        { 
            Beuzsidarant = beuzsidarant;
            InitializeComponent();
            PriskirtiPav();
            stopwatch = new Stopwatch();
        }

        private void UzsidarantVaikui()
        {
            this.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void PriskirtiPav()
        {
            Label label;
            int random;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                {
                    continue;
                }
                random = rng.Next(0, pav.Count);
                label.Text = pav[random];

                pav.RemoveAt(random);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            if (firstClicked != null && secondClicked != null)
            {
                return;
            }

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
            {
                return;
            }
            if (clickedLabel.ForeColor == Color.Black)
            {
                return;
            }
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            Laimejo();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void Laimejo()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;
                if (label != null && label.ForeColor == label.BackColor)
                {
                    return;
                }
            }
            stopwatch.Stop();
            TimeSpan stopwatchElapsed = stopwatch.Elapsed;
            score = String.Format("{0:F2}", stopwatchElapsed.TotalSeconds);

            DuomenuIrasymas();

            var result = MessageBox.Show("Jūsų laikas: " + score + "\nAr norite kartoti?", "Laimėjote!!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                this.Close();
            }
        }

        private void DuomenuIrasymas()
        {
            SqlConnection sql = new SqlConnection(ConnectionString);
            string querry = "INSERT INTO AtmintiesScore(VartotojoID, Laikas) VALUES(@VartotojoID, @Laikas)";
            SqlCommand command = new SqlCommand(querry, sql);
            command.Parameters.AddWithValue("@VartotojoID", UName.uId);
            command.Parameters.AddWithValue("@Laikas", score);
            sql.Open();
            var atsakymas = command.ExecuteNonQuery();
            if (atsakymas < 0)
            {
                Console.WriteLine("Irasyti i duomenu baze nepavyko");
            }
            sql.Close();
        }

        private void KiekUztruko_Tick(object sender, EventArgs e)
        {
            Score.Text = "Laikas: " + stopwatch.Elapsed.Seconds.ToString();
            Application.DoEvents();
        }

        private void AtmintiesZaidimas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Beuzsidarant();
        }

        private void RestartGame()
        {
            List<string> pavv = new List<string>()
            {
                "=","=","R","R","S","S","!","!","#","#","l","l","~","~","I","I"
            };

            Random rngg = new Random();
            stopwatch.Restart();
            Score.Text = "Laikas: 0";

            foreach (Label l in tableLayoutPanel1.Controls.OfType<Label>())
            {
                l.ForeColor = Color.LimeGreen;
                l.Text = string.Empty;
            }

            Label label;
            int random;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                {
                    continue;
                }
                random = rngg.Next(0, pavv.Count);
                label.Text = pavv[random];

                pavv.RemoveAt(random);
            }
        }
    }
}
