namespace FingerprintAttendanceSystem
{
    partial class adminLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLbl = new System.Windows.Forms.Label();
            this.lgnLbl = new System.Windows.Forms.Label();
            this.lgnBtn = new System.Windows.Forms.Button();
            this.pwdTxt = new MetroFramework.Controls.MetroTextBox();
            this.usernameTxt = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.errorLbl);
            this.panel1.Controls.Add(this.lgnLbl);
            this.panel1.Controls.Add(this.lgnBtn);
            this.panel1.Controls.Add(this.pwdTxt);
            this.panel1.Controls.Add(this.usernameTxt);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 266);
            this.panel1.TabIndex = 0;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(78, 67);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(227, 15);
            this.errorLbl.TabIndex = 4;
            this.errorLbl.Text = "error : invalid username or password";
            this.errorLbl.Visible = false;
            // 
            // lgnLbl
            // 
            this.lgnLbl.AutoSize = true;
            this.lgnLbl.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(14)))), ((int)(((byte)(128)))));
            this.lgnLbl.Location = new System.Drawing.Point(96, 23);
            this.lgnLbl.Name = "lgnLbl";
            this.lgnLbl.Size = new System.Drawing.Size(209, 33);
            this.lgnLbl.TabIndex = 3;
            this.lgnLbl.Text = "ADMIN LOGIN";
            // 
            // lgnBtn
            // 
            this.lgnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(23)))), ((int)(((byte)(204)))));
            this.lgnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgnBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.lgnBtn.Location = new System.Drawing.Point(102, 205);
            this.lgnBtn.Name = "lgnBtn";
            this.lgnBtn.Size = new System.Drawing.Size(181, 46);
            this.lgnBtn.TabIndex = 2;
            this.lgnBtn.Text = "login";
            this.lgnBtn.UseVisualStyleBackColor = false;
            this.lgnBtn.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(69, 154);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '●';
            this.pwdTxt.Size = new System.Drawing.Size(261, 23);
            this.pwdTxt.TabIndex = 1;
            this.pwdTxt.Text = "password";
            this.pwdTxt.UseSystemPasswordChar = true;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(69, 95);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(261, 23);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.Text = "username";
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 263);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "adminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label lgnLbl;
        private System.Windows.Forms.Button lgnBtn;
        private MetroFramework.Controls.MetroTextBox pwdTxt;
        private MetroFramework.Controls.MetroTextBox usernameTxt;
    }
}

