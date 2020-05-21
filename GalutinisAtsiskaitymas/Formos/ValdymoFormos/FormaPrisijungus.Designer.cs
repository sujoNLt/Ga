namespace GalutinisAtsiskaitymas
{
    partial class FormaPrisijungus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataLBL = new System.Windows.Forms.Label();
            this.AtmintiesZaidimas = new System.Windows.Forms.PictureBox();
            this.Monetos = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Atsijungti = new System.Windows.Forms.Button();
            this.UserNamePrisijungus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AtmintiesZaidimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monetos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataLBL
            // 
            this.DataLBL.AutoSize = true;
            this.DataLBL.Location = new System.Drawing.Point(12, 9);
            this.DataLBL.Name = "DataLBL";
            this.DataLBL.Size = new System.Drawing.Size(0, 17);
            this.DataLBL.TabIndex = 3;
            // 
            // AtmintiesZaidimas
            // 
            this.AtmintiesZaidimas.Location = new System.Drawing.Point(51, 126);
            this.AtmintiesZaidimas.Name = "AtmintiesZaidimas";
            this.AtmintiesZaidimas.Size = new System.Drawing.Size(172, 147);
            this.AtmintiesZaidimas.TabIndex = 4;
            this.AtmintiesZaidimas.TabStop = false;
            this.AtmintiesZaidimas.Click += new System.EventHandler(this.AtmintiesZaidimas_Click);
            // 
            // Monetos
            // 
            this.Monetos.Location = new System.Drawing.Point(506, 126);
            this.Monetos.Name = "Monetos";
            this.Monetos.Size = new System.Drawing.Size(172, 147);
            this.Monetos.TabIndex = 6;
            this.Monetos.TabStop = false;
            this.Monetos.Click += new System.EventHandler(this.Monetos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(68, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Atminties žaidimas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monetų ieškotojas";
            this.label4.Visible = false;
            // 
            // Atsijungti
            // 
            this.Atsijungti.BackColor = System.Drawing.Color.DimGray;
            this.Atsijungti.Location = new System.Drawing.Point(689, 12);
            this.Atsijungti.Name = "Atsijungti";
            this.Atsijungti.Size = new System.Drawing.Size(108, 29);
            this.Atsijungti.TabIndex = 11;
            this.Atsijungti.Text = "Atsijungti";
            this.Atsijungti.UseVisualStyleBackColor = false;
            this.Atsijungti.Click += new System.EventHandler(this.Atsijungti_Click);
            // 
            // UserNamePrisijungus
            // 
            this.UserNamePrisijungus.AutoSize = true;
            this.UserNamePrisijungus.Location = new System.Drawing.Point(12, 35);
            this.UserNamePrisijungus.Name = "UserNamePrisijungus";
            this.UserNamePrisijungus.Size = new System.Drawing.Size(46, 17);
            this.UserNamePrisijungus.TabIndex = 12;
            this.UserNamePrisijungus.Text = "label1";
            // 
            // FormaPrisijungus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserNamePrisijungus);
            this.Controls.Add(this.Atsijungti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AtmintiesZaidimas);
            this.Controls.Add(this.DataLBL);
            this.Controls.Add(this.Monetos);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormaPrisijungus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaPrisijungus_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize)(this.AtmintiesZaidimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DataLBL;
        private System.Windows.Forms.PictureBox AtmintiesZaidimas;
        private System.Windows.Forms.PictureBox Monetos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Atsijungti;
        private System.Windows.Forms.Label UserNamePrisijungus;
    }
}