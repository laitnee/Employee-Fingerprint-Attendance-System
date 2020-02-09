namespace FingerprintAttendanceSystem
{
    partial class Homepage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.atdLogBtn = new System.Windows.Forms.Button();
            this.strAttBtn = new System.Windows.Forms.Button();
            this.mngStaffBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.atdLogBtn);
            this.panel1.Controls.Add(this.strAttBtn);
            this.panel1.Controls.Add(this.mngStaffBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 344);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(14)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(142, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Homepage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fingerprint Attendance System";
            // 
            // atdLogBtn
            // 
            this.atdLogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(250)))));
            this.atdLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atdLogBtn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atdLogBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.atdLogBtn.Location = new System.Drawing.Point(25, 251);
            this.atdLogBtn.Name = "atdLogBtn";
            this.atdLogBtn.Size = new System.Drawing.Size(377, 71);
            this.atdLogBtn.TabIndex = 2;
            this.atdLogBtn.Text = "Attendance Log";
            this.atdLogBtn.UseVisualStyleBackColor = false;
            this.atdLogBtn.Click += new System.EventHandler(this.atdLogBtn_Click);
            // 
            // strAttBtn
            // 
            this.strAttBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(7)))), ((int)(((byte)(246)))));
            this.strAttBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strAttBtn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strAttBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.strAttBtn.Location = new System.Drawing.Point(25, 97);
            this.strAttBtn.Name = "strAttBtn";
            this.strAttBtn.Size = new System.Drawing.Size(377, 71);
            this.strAttBtn.TabIndex = 1;
            this.strAttBtn.Text = "Start Attendance";
            this.strAttBtn.UseVisualStyleBackColor = false;
            this.strAttBtn.Click += new System.EventHandler(this.strAttBtn_Click);
            // 
            // mngStaffBtn
            // 
            this.mngStaffBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(5)))));
            this.mngStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mngStaffBtn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngStaffBtn.Location = new System.Drawing.Point(25, 174);
            this.mngStaffBtn.Name = "mngStaffBtn";
            this.mngStaffBtn.Size = new System.Drawing.Size(377, 71);
            this.mngStaffBtn.TabIndex = 0;
            this.mngStaffBtn.Text = "Manage Staff";
            this.mngStaffBtn.UseVisualStyleBackColor = false;
            this.mngStaffBtn.Click += new System.EventHandler(this.mngStaffBtn_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 343);
            this.Controls.Add(this.panel1);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Homepage_FormClosed);
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button atdLogBtn;
        private System.Windows.Forms.Button strAttBtn;
        private System.Windows.Forms.Button mngStaffBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}