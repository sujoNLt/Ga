using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Timers;

namespace GalutinisAtsiskaitymas
{
    public partial class Monetos : Form
    {
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nslau\Desktop\KaunasCodingSchool\GalutinisAtsiskaitymas\GalutinisAtsiskaitymas\UserDataBase.mdf;Integrated Security=True";
        private Action Beuzsidarant;
        SoundPlayer player;
        Stopwatch stopwatch;
        bool left, right, jump, gameOver;
        bool dead = false;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;
        int playerHealth = 3;
        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enemy1Speed = 5;
        int enemy2Speed = 5;
        int enemy3Speed = 3;

        string laikas;

        public Monetos(Action beuzsidarant)
        {
            Beuzsidarant = beuzsidarant;
            InitializeComponent();
            stopwatch = new Stopwatch();
            player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\nslau\Desktop\KaunasCodingSchool\GalutinisAtsiskaitymas\GalutinisAtsiskaitymas\Art_Sound\Platformeriui.wav";
            player.PlayLooping();
            label1.Text = "Gyvybės: " + playerHealth.ToString();
        }


        private void Monetos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Beuzsidarant();
            player.Stop();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Score.Text = "Monetos: " + score + Environment.NewLine + "Atsiimk iš priešų visas monetas";
            Veikejas.Top += jumpSpeed;
            if (left == true)
            {
                Veikejas.Left -= playerSpeed;
            }
            if (right == true)
            {
                Veikejas.Left += playerSpeed;
            }

            if (jump == true && force < 0)
            {
                jump = false;
            }
            if (jump == true)
            {
                jumpSpeed = -5;
                force -= 1;
            }
            else
            {
                jumpSpeed = 4;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platforma")
                    {
                        

                        if (Veikejas.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            Veikejas.Top = x.Top - Veikejas.Height;

                            if ((string)x.Name == "JudantHorizantaliai" && left == false || (string)x.Name == "JudantHorizantaliai" && right == false)
                            {
                                Veikejas.Left -= horizontalSpeed;
                            }
                        }

                        x.BringToFront();
                    }

                    if ((string)x.Tag == "monetos")
                    {
                        if (Veikejas.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }

                    if ((string)x.Tag =="Priesas" || (string)x.Tag == "Priesas2" || (string)x.Tag == "Priesas3")
                    {
                        if (Veikejas.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameTimer.Stop();
                            playerHealth--;
                            label1.Text = "Gyvybės: " + playerHealth.ToString();
                            dead = true;
                            if (playerHealth == 0 && dead)
                            {
                                gameOver = true;
                            }
                            Score.Text = "Monetos: " + score + Environment.NewLine + "Mirei nuo priešo atakų";
                            
                        }
                    }
                }
            }

            JudantHorizantaliai.Left -= horizontalSpeed;
            if (JudantHorizantaliai.Left < 700 || JudantHorizantaliai.Left + JudantHorizantaliai.Width > this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            KylantiPlatforma1.Top += verticalSpeed;
            if (KylantiPlatforma1.Top < 38 || KylantiPlatforma1.Top > 301)
            {
                verticalSpeed = -verticalSpeed;
            }

            Priesas1.Left -= enemy1Speed;
            if (Priesas1.Left < pictureBox5.Left || Priesas1.Left + Priesas1.Width > pictureBox5.Left + pictureBox5.Width)
            {
                enemy1Speed = -enemy1Speed;
                
            }

            Priesas2.Left -= enemy2Speed;
            if (Priesas2.Left < pictureBox9.Left || Priesas2.Left + Priesas2.Width > pictureBox9.Left + pictureBox9.Width || Priesas2.Bounds.IntersectsWith(Priesas3.Bounds))
            {
                enemy2Speed = -enemy2Speed;
            }

            Priesas3.Left -= enemy3Speed;
            if (Priesas3.Left < pictureBox9.Left || Priesas3.Left + Priesas3.Width > pictureBox9.Left + pictureBox9.Width || Priesas3.Bounds.IntersectsWith(Priesas2.Bounds))
            {
                enemy3Speed = -enemy3Speed;
            }

            if (Veikejas.Top + Veikejas.Height > this.ClientSize.Height + 50)
            {
                GameTimer.Stop();
                playerHealth--;
                label1.Text = "Gyvybės: " + playerHealth.ToString();
                dead = true;
                if (playerHealth == 0)
                {
                    gameOver = true;
                }
                Score.Text = "Monetos: " + score + Environment.NewLine + "Mirei krisdamas";
            }

            if (Veikejas.Bounds.IntersectsWith(Durys.Bounds) && score == 6)
            {
                GameTimer.Stop();
                stopwatch.Stop();
                gameOver = true;
                TimeSpan stopwatchElapsed = stopwatch.Elapsed;

                laikas = String.Format("{0:F2}", stopwatch.Elapsed.TotalSeconds);

                DuomenuIrasymas();

                var laimejai = MessageBox.Show("Kartoti? ", "Laimėjai" , MessageBoxButtons.YesNo);
                if (laimejai == DialogResult.Yes)
                {
                    gameOver = true;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void DuomenuIrasymas()
        {
            Score.Text = "Monetos: " + score + Environment.NewLine + "Atsiėmei visas monetas!";
            SqlConnection sql = new SqlConnection(ConnectionString);
            string querry = "INSERT INTO PlatformerScore(VartotojoID, Laikas, Gyvybes) VALUES(@VartotojoID, @Laikas, @Gyvybes)";
            SqlCommand command = new SqlCommand(querry, sql);
            command.Parameters.AddWithValue("@VartotojoID", UName.uId);
            command.Parameters.AddWithValue("@Laikas", laikas);
            command.Parameters.AddWithValue("@Gyvybes", playerHealth);
            sql.Open();
            var atsakymas = command.ExecuteNonQuery();
            if (atsakymas < 0)
            {
                Console.WriteLine("Irasyti i duomenu baze nepavyko");
            }
            sql.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Laikas: " + stopwatch.Elapsed.Seconds.ToString();
            Application.DoEvents();
        }

        private void Monetos_KeyDown(object sender, KeyEventArgs e)
        {
            stopwatch.Start();
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Up && jump == false)
            {
                jump = true;
            }

        }

        private void Monetos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (jump == true)
            {
                jump = false;
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

            if (e.KeyCode == Keys.Enter && playerHealth > 0 && dead)
            {
                GameTimer.Start();
                Veikejas.Left = 17;
                Veikejas.Top = 400;
            }
            
        }

        private void RestartGame()
        {
            jump = false;
            left = false;
            right = false;
            gameOver = false;
            playerHealth = 3;
            score = 0;
            stopwatch.Reset();

            Score.Text = "Monetos: " + score;
            label1.Text = "Gyvybės: " + playerHealth.ToString();
            label2.Text = "Laikas: 0";

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            Veikejas.Left = 17;
            Veikejas.Top = 400;

            Priesas1.Left = 650;
            Priesas2.Left = 265;
            Priesas3.Left = 480;

            KylantiPlatforma1.Top = 300;
            JudantHorizantaliai.Left = 800;

            GameTimer.Start();
        }
    }
}
