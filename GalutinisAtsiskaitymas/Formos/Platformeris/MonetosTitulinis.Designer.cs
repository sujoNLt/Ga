namespace GalutinisAtsiskaitymas
{
    partial class MonetosTitulinis
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
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Top10 = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Top10PlatView = new System.Windows.Forms.DataGridView();
            this.Vieta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Top10PlatView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Monetų ieškotojas";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DimGray;
            this.Exit.Location = new System.Drawing.Point(101, 252);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(120, 55);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Išeiti";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Top10
            // 
            this.Top10.BackColor = System.Drawing.Color.DimGray;
            this.Top10.Location = new System.Drawing.Point(101, 181);
            this.Top10.Name = "Top10";
            this.Top10.Size = new System.Drawing.Size(120, 55);
            this.Top10.TabIndex = 6;
            this.Top10.Text = "Top10";
            this.Top10.UseVisualStyleBackColor = false;
            this.Top10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top10_MouseDown);
            this.Top10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Top10_MouseUp);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.DimGray;
            this.Play.Location = new System.Drawing.Point(101, 110);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(120, 55);
            this.Play.TabIndex = 5;
            this.Play.Text = "Žaisti";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Top10PlatView
            // 
            this.Top10PlatView.AllowUserToAddRows = false;
            this.Top10PlatView.AllowUserToDeleteRows = false;
            this.Top10PlatView.AllowUserToOrderColumns = true;
            this.Top10PlatView.AllowUserToResizeColumns = false;
            this.Top10PlatView.AllowUserToResizeRows = false;
            this.Top10PlatView.BackgroundColor = System.Drawing.Color.DimGray;
            this.Top10PlatView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Top10PlatView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Top10PlatView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vieta});
            this.Top10PlatView.Enabled = false;
            this.Top10PlatView.GridColor = System.Drawing.Color.DimGray;
            this.Top10PlatView.Location = new System.Drawing.Point(1, 26);
            this.Top10PlatView.Name = "Top10PlatView";
            this.Top10PlatView.ReadOnly = true;
            this.Top10PlatView.RowHeadersVisible = false;
            this.Top10PlatView.RowTemplate.Height = 24;
            this.Top10PlatView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Top10PlatView.Size = new System.Drawing.Size(314, 281);
            this.Top10PlatView.TabIndex = 9;
            this.Top10PlatView.Visible = false;
            this.Top10PlatView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Top10View_RowPostPaint);
            this.Top10PlatView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top10_MouseDown);
            this.Top10PlatView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Top10_MouseUp);
            // 
            // Vieta
            // 
            this.Vieta.HeaderText = "Vieta:";
            this.Vieta.Name = "Vieta";
            this.Vieta.ReadOnly = true;
            this.Vieta.Width = 45;
            // 
            // MonetosTitulinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(318, 377);
            this.Controls.Add(this.Top10PlatView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Top10);
            this.Controls.Add(this.Play);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MonetosTitulinis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonetosTitulinis_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Top10PlatView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Top10;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.DataGridView Top10PlatView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vieta;
    }
}