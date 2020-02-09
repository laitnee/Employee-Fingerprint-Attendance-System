namespace FingerprintAttendanceSystem
{
    partial class FingerprintAttendance
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.fpStatusLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.verPicBox = new System.Windows.Forms.PictureBox();
            this.rptLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.fpStatusLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 44);
            this.panel1.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(26, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(96, 29);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "stop";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // fpStatusLbl
            // 
            this.fpStatusLbl.AutoSize = true;
            this.fpStatusLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpStatusLbl.Location = new System.Drawing.Point(364, 19);
            this.fpStatusLbl.Name = "fpStatusLbl";
            this.fpStatusLbl.Size = new System.Drawing.Size(208, 16);
            this.fpStatusLbl.TabIndex = 0;
            this.fpStatusLbl.Text = "Fingerprint scanner connected";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(14)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.dtLbl);
            this.panel2.Controls.Add(this.timeLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 80);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtLbl
            // 
            this.dtLbl.AutoSize = true;
            this.dtLbl.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLbl.Location = new System.Drawing.Point(182, 42);
            this.dtLbl.Name = "dtLbl";
            this.dtLbl.Size = new System.Drawing.Size(229, 25);
            this.dtLbl.TabIndex = 1;
            this.dtLbl.Text = "12th December 2020";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(246, 9);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(91, 33);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "3 : 33";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.verPicBox);
            this.panel3.Controls.Add(this.rptLbl);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(601, 262);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // verPicBox
            // 
            this.verPicBox.Location = new System.Drawing.Point(317, 66);
            this.verPicBox.Name = "verPicBox";
            this.verPicBox.Size = new System.Drawing.Size(272, 190);
            this.verPicBox.TabIndex = 2;
            this.verPicBox.TabStop = false;
            this.verPicBox.Visible = false;
            // 
            // rptLbl
            // 
            this.rptLbl.AutoSize = true;
            this.rptLbl.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptLbl.Location = new System.Drawing.Point(313, 14);
            this.rptLbl.Name = "rptLbl";
            this.rptLbl.Size = new System.Drawing.Size(169, 23);
            this.rptLbl.TabIndex = 1;
            this.rptLbl.Text = "Scan your Finger";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FingerprintAttendanceSystem.Properties.Resources.fingerprint__4_;
            this.pictureBox1.Location = new System.Drawing.Point(26, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FingerprintAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 386);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FingerprintAttendance";
            this.Text = "FingerprintAttendance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FingerprintAttendance_FormClosed);
            this.Load += new System.EventHandler(this.FingerprintAttendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fpStatusLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label rptLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dtLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox verPicBox;
    }
}