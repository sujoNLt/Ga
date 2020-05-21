namespace GalutinisAtsiskaitymas
{
    partial class RegistracijosForma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterRegisterBtn = new System.Windows.Forms.Button();
            this.UserNameRegisterTB = new System.Windows.Forms.TextBox();
            this.PasswordRegisterTB = new System.Windows.Forms.TextBox();
            this.PasswordRegister2TB = new System.Windows.Forms.TextBox();
            this.EmailRegisterTB = new System.Windows.Forms.TextBox();
            this.BirthDateRegisterDTP = new System.Windows.Forms.DateTimePicker();
            this.UzimtasVardasLB = new System.Windows.Forms.Label();
            this.SlapNeatitinkaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prisijungimo vardas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slaptažodis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pakartoti slaptažodį:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gimimo data:";
            // 
            // RegisterRegisterBtn
            // 
            this.RegisterRegisterBtn.BackColor = System.Drawing.Color.DimGray;
            this.RegisterRegisterBtn.Location = new System.Drawing.Point(117, 368);
            this.RegisterRegisterBtn.Name = "RegisterRegisterBtn";
            this.RegisterRegisterBtn.Size = new System.Drawing.Size(133, 38);
            this.RegisterRegisterBtn.TabIndex = 5;
            this.RegisterRegisterBtn.Text = "Prisiregistruoti";
            this.RegisterRegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterRegisterBtn.Click += new System.EventHandler(this.RegisterRegisterBtn_Click);
            // 
            // UserNameRegisterTB
            // 
            this.UserNameRegisterTB.BackColor = System.Drawing.Color.LightGray;
            this.UserNameRegisterTB.Location = new System.Drawing.Point(88, 65);
            this.UserNameRegisterTB.Name = "UserNameRegisterTB";
            this.UserNameRegisterTB.Size = new System.Drawing.Size(184, 22);
            this.UserNameRegisterTB.TabIndex = 6;
            // 
            // PasswordRegisterTB
            // 
            this.PasswordRegisterTB.BackColor = System.Drawing.Color.LightGray;
            this.PasswordRegisterTB.Location = new System.Drawing.Point(88, 130);
            this.PasswordRegisterTB.Name = "PasswordRegisterTB";
            this.PasswordRegisterTB.PasswordChar = '*';
            this.PasswordRegisterTB.Size = new System.Drawing.Size(184, 22);
            this.PasswordRegisterTB.TabIndex = 7;
            // 
            // PasswordRegister2TB
            // 
            this.PasswordRegister2TB.BackColor = System.Drawing.Color.LightGray;
            this.PasswordRegister2TB.Location = new System.Drawing.Point(88, 192);
            this.PasswordRegister2TB.Name = "PasswordRegister2TB";
            this.PasswordRegister2TB.PasswordChar = '*';
            this.PasswordRegister2TB.Size = new System.Drawing.Size(184, 22);
            this.PasswordRegister2TB.TabIndex = 8;
            // 
            // EmailRegisterTB
            // 
            this.EmailRegisterTB.BackColor = System.Drawing.Color.LightGray;
            this.EmailRegisterTB.Location = new System.Drawing.Point(88, 255);
            this.EmailRegisterTB.Name = "EmailRegisterTB";
            this.EmailRegisterTB.Size = new System.Drawing.Size(184, 22);
            this.EmailRegisterTB.TabIndex = 9;
            // 
            // BirthDateRegisterDTP
            // 
            this.BirthDateRegisterDTP.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.BirthDateRegisterDTP.CustomFormat = "dd-MM-yyy";
            this.BirthDateRegisterDTP.Location = new System.Drawing.Point(54, 313);
            this.BirthDateRegisterDTP.MaxDate = new System.DateTime(2020, 5, 7, 0, 0, 0, 0);
            this.BirthDateRegisterDTP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthDateRegisterDTP.Name = "BirthDateRegisterDTP";
            this.BirthDateRegisterDTP.Size = new System.Drawing.Size(244, 22);
            this.BirthDateRegisterDTP.TabIndex = 10;
            this.BirthDateRegisterDTP.Value = new System.DateTime(2020, 5, 7, 0, 0, 0, 0);
            // 
            // UzimtasVardasLB
            // 
            this.UzimtasVardasLB.AutoSize = true;
            this.UzimtasVardasLB.Location = new System.Drawing.Point(150, 90);
            this.UzimtasVardasLB.Name = "UzimtasVardasLB";
            this.UzimtasVardasLB.Size = new System.Drawing.Size(0, 17);
            this.UzimtasVardasLB.TabIndex = 11;
            // 
            // SlapNeatitinkaLB
            // 
            this.SlapNeatitinkaLB.AutoSize = true;
            this.SlapNeatitinkaLB.Location = new System.Drawing.Point(150, 217);
            this.SlapNeatitinkaLB.Name = "SlapNeatitinkaLB";
            this.SlapNeatitinkaLB.Size = new System.Drawing.Size(0, 17);
            this.SlapNeatitinkaLB.TabIndex = 12;
            // 
            // RegistracijosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.SlapNeatitinkaLB);
            this.Controls.Add(this.UzimtasVardasLB);
            this.Controls.Add(this.BirthDateRegisterDTP);
            this.Controls.Add(this.EmailRegisterTB);
            this.Controls.Add(this.PasswordRegister2TB);
            this.Controls.Add(this.PasswordRegisterTB);
            this.Controls.Add(this.UserNameRegisterTB);
            this.Controls.Add(this.RegisterRegisterBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistracijosForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistracijosForma_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterRegisterBtn;
        private System.Windows.Forms.TextBox UserNameRegisterTB;
        private System.Windows.Forms.TextBox PasswordRegisterTB;
        private System.Windows.Forms.TextBox PasswordRegister2TB;
        private System.Windows.Forms.TextBox EmailRegisterTB;
        private System.Windows.Forms.DateTimePicker BirthDateRegisterDTP;
        private System.Windows.Forms.Label UzimtasVardasLB;
        private System.Windows.Forms.Label SlapNeatitinkaLB;
    }
}