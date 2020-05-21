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
    public partial class MonetosTitulinis : Form
    {
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nslau\Desktop\KaunasCodingSchool\GalutinisAtsiskaitymas\GalutinisAtsiskaitymas\UserDataBase.mdf;Integrated Security=True";
        Action Beuzsidarant;
        public MonetosTitulinis(Action beuzsidarant)
        {
            Beuzsidarant = beuzsidarant;
            InitializeComponent();
            
        }

        private void MonetosTitulinis_FormClosing(object sender, FormClosingEventArgs e)
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
            Monetos monetos = new Monetos(action);
            monetos.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Top10_MouseDown(object sender, MouseEventArgs e)
        {
            Top10PlatView.AutoGenerateColumns = true;
            Top10PlatView.Visible = true;
            DataContext db = new DataContext(ConnectionString);
            Top10PlatView.DataSource = db.GetTable<PlatformerScore>().Select(x =>
            new
            {
                x.UserInfo.UserName,
                x.Laikas,
                x.Gyvybes
            }).OrderBy(x => x.Laikas).OrderByDescending(x => x.Gyvybes).Take(10);

            Top10PlatView.Columns["UserName"].Width = 80;
            Top10PlatView.Columns["Laikas"].Width = 50;
            Top10PlatView.Columns["Gyvybes"].Width = 60;
        }

        private void Top10_MouseUp(object sender, MouseEventArgs e)
        {
            Top10PlatView.Visible = false;
        }

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void Top10View_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.Top10PlatView.Rows[e.RowIndex].Cells["Vieta"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
