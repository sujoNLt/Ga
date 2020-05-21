using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace GalutinisAtsiskaitymas
{
    public partial class AtmintiesTitulinis : Form
    {
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nslau\Desktop\KaunasCodingSchool\GalutinisAtsiskaitymas\GalutinisAtsiskaitymas\UserDataBase.mdf;Integrated Security=True";

        Action Beuzsidarant;
        public AtmintiesTitulinis(Action beuzsidarant)
        {
            Beuzsidarant = beuzsidarant;
            InitializeComponent();
        }

        private void AtmintiesTitulinis_FormClosing(object sender, FormClosingEventArgs e)
        {
            Beuzsidarant();
        }

        private void UzsidarantVaikui()
        {
            this.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Action action = UzsidarantVaikui;
            AtmintiesZaidimas atmintiesZaidimas = new AtmintiesZaidimas(action);
            atmintiesZaidimas.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Top10_MouseDown(object sender, MouseEventArgs e)
        {
            Top10View.Visible = true;
            DataContext db = new DataContext(ConnectionString);
            Top10View.DataSource = db.GetTable<AtmintiesScore>().Select(x =>
            new
            {
                x.UserInfo.UserName,
                x.Laikas
            }
            ).OrderBy(x => x.Laikas).Take(10);
        }

        private void Top10_MouseUp(object sender, MouseEventArgs e)
        {
            Top10View.Visible = false;
        }

        private void Top10View_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.Top10View.Rows[e.RowIndex].Cells["Vieta"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
