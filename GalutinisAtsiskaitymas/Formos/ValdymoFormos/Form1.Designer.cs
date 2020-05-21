namespace GalutinisAtsiskaitymas
{
    partial class Form1
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
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.LogInBTN = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.BackColor = System.Drawing.Color.DimGray;
            this.RegisterBTN.Location = new System.Drawing.Point(107, 228);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(133, 38);
            this.RegisterBTN.TabIndex = 23;
            this.RegisterBTN.Text = "Prisiregistruoti";
            this.RegisterBTN.UseVisualStyleBackColor = false;
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // LogInBTN
            // 
            this.LogInBTN.BackColor = System.Drawing.Color.DimGray;
            this.LogInBTN.Location = new System.Drawing.Point(107, 171);
            this.LogInBTN.Name = "LogInBTN";
            this.LogInBTN.Size = new System.Drawing.Size(133, 38);
            this.LogInBTN.TabIndex = 22;
            this.LogInBTN.Text = "Prisijungti";
            this.LogInBTN.UseVisualStyleBackColor = false;
            this.LogInBTN.Click += new System.EventHandler(this.LogInBTN_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.BackColor = System.Drawing.Color.LightGray;
            this.PasswordTB.Location = new System.Drawing.Point(68, 126);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(199, 22);
            this.PasswordTB.TabIndex = 21;
            // 
            // UserNameTB
            // 
            this.UserNameTB.BackColor = System.Drawing.Color.LightGray;
            this.UserNameTB.Location = new System.Drawing.Point(68, 66);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(199, 22);
            this.UserNameTB.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Slaptažodis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Prisijungimo vardas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(334, 309);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.LogInBTN);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterBTN;
        private System.Windows.Forms.Button LogInBTN;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

