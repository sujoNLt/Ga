using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GalutinisAtsiskaitymas
{
    public partial class FormaPrisijungus : Form
    {
        private Action Beuzsidarant;
        Timer timer;

        public FormaPrisijungus(Action beuzsidarant)
        {
            Beuzsidarant = beuzsidarant;
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += TimerTickEvent;
            timer.Enabled = true;
            timer.Start();

            AtmintiesZaidimas.MouseEnter += PictureBox1MouseEnter;
            AtmintiesZaidimas.MouseLeave += PictureBox1MouseLeave;
            Monetos.MouseEnter += PictureBox3MouseEnter;
            Monetos.MouseLeave += PictureBox3MouseLeave;

            AtmintiesZaidimas.SizeMode = PictureBoxSizeMode.StretchImage;
            Monetos.SizeMode = PictureBoxSizeMode.StretchImage;
            AtmintiesZaidimas.Image = Image.FromFile(@"C:\Users\nslau\Desktop\KaunasCodingSchool\GalutinisAtsiskaitymas\GalutinisAtsiskaitymas\Art_Sound\Screenshot_3.png");
            Monetos.Image = Image.FromFile(@"C:\Users\nslau\Desktop\KaunasCodingSchool\GalutinisAtsiskaitymas\GalutinisAtsiskaitymas\Art_Sound\Platformer.png");

            UserNamePrisijungus.Text = UName.uname;
        }

        private void FormaPrisijungus_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Beuzsidarant();
        }

        private void UzsidarantVaikui()
        {
            this.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void TimerTickEvent(object sender, EventArgs e)
        {
            DataLBL.Text = DateTime.Now.ToShortTimeString();
        }



        private void PictureBox1MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void PictureBox1MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void PictureBox3MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void PictureBox3MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }


        private void AtmintiesZaidimas_Click(object sender, EventArgs e)
        {
            Action action = UzsidarantVaikui;
            AtmintiesTitulinis atmintiesTitulinis = new AtmintiesTitulinis(action);
            atmintiesTitulinis.Show();
            this.Hide();
        }

        private void Monetos_Click(object sender, EventArgs e)
        {
            Action action = UzsidarantVaikui;
            MonetosTitulinis monetosTitulinis = new MonetosTitulinis(action);
            monetosTitulinis.Show();
            this.Hide();
        }


        private void Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
