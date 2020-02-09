namespace FingerprintAttendanceSystem
{
    partial class CaptureForm
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
            System.Windows.Forms.Label StatusLabel;
            System.Windows.Forms.Label PromptLabel;
            this.CloseButton = new System.Windows.Forms.Button();
            this.StatusLine = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.Prompt = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            StatusLabel = new System.Windows.Forms.Label();
            PromptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(479, 316);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 20;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // StatusLine
            // 
            this.StatusLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLine.Location = new System.Drawing.Point(4, 300);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(469, 39);
            this.StatusLine.TabIndex = 19;
            this.StatusLine.Text = "[Status line]";
            // 
            // StatusText
            // 
            this.StatusText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusText.BackColor = System.Drawing.SystemColors.Window;
            this.StatusText.Location = new System.Drawing.Point(264, 92);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StatusText.Size = new System.Drawing.Size(290, 205);
            this.StatusText.TabIndex = 18;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new System.Drawing.Point(261, 76);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(40, 13);
            StatusLabel.TabIndex = 17;
            StatusLabel.Text = "Status:";
            // 
            // Prompt
            // 
            this.Prompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prompt.Location = new System.Drawing.Point(264, 39);
            this.Prompt.Name = "Prompt";
            this.Prompt.ReadOnly = true;
            this.Prompt.Size = new System.Drawing.Size(290, 20);
            this.Prompt.TabIndex = 16;
            // 
            // PromptLabel
            // 
            PromptLabel.AutoSize = true;
            PromptLabel.Location = new System.Drawing.Point(261, 23);
            PromptLabel.Name = "PromptLabel";
            PromptLabel.Size = new System.Drawing.Size(43, 13);
            PromptLabel.TabIndex = 15;
            PromptLabel.Text = "Prompt:";
            // 
            // Picture
            // 
            this.Picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Picture.BackColor = System.Drawing.SystemColors.Window;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture.Location = new System.Drawing.Point(7, 23);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(248, 274);
            this.Picture.TabIndex = 14;
            this.Picture.TabStop = false;
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 362);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StatusLine);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(StatusLabel);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(PromptLabel);
            this.Controls.Add(this.Picture);
            this.Name = "CaptureForm";
            this.Text = "CaptureForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaptureForm_FormClosed);
            this.Load += new System.EventHandler(this.CaptureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label StatusLine;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.TextBox Prompt;
        private System.Windows.Forms.PictureBox Picture;
    }
}