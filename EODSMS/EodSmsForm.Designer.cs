namespace EODSMS
{
    partial class EodSmsForm
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
            this.pbEodSms = new MetroFramework.Controls.MetroProgressBar();
            this.txtBoxStatus = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // pbEodSms
            // 
            this.pbEodSms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEodSms.Location = new System.Drawing.Point(23, 63);
            this.pbEodSms.Name = "pbEodSms";
            this.pbEodSms.Size = new System.Drawing.Size(471, 23);
            this.pbEodSms.Step = 1;
            this.pbEodSms.TabIndex = 0;
            // 
            // txtBoxStatus
            // 
            this.txtBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBoxStatus.CustomButton.Image = null;
            this.txtBoxStatus.CustomButton.Location = new System.Drawing.Point(357, 2);
            this.txtBoxStatus.CustomButton.Name = "";
            this.txtBoxStatus.CustomButton.Size = new System.Drawing.Size(111, 111);
            this.txtBoxStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxStatus.CustomButton.TabIndex = 1;
            this.txtBoxStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxStatus.CustomButton.UseSelectable = true;
            this.txtBoxStatus.CustomButton.Visible = false;
            this.txtBoxStatus.Lines = new string[0];
            this.txtBoxStatus.Location = new System.Drawing.Point(23, 92);
            this.txtBoxStatus.MaxLength = 32767;
            this.txtBoxStatus.Multiline = true;
            this.txtBoxStatus.Name = "txtBoxStatus";
            this.txtBoxStatus.PasswordChar = '\0';
            this.txtBoxStatus.ReadOnly = true;
            this.txtBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxStatus.SelectedText = "";
            this.txtBoxStatus.SelectionLength = 0;
            this.txtBoxStatus.SelectionStart = 0;
            this.txtBoxStatus.ShortcutsEnabled = true;
            this.txtBoxStatus.Size = new System.Drawing.Size(471, 116);
            this.txtBoxStatus.TabIndex = 3;
            this.txtBoxStatus.UseSelectable = true;
            this.txtBoxStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EodSmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 231);
            this.Controls.Add(this.txtBoxStatus);
            this.Controls.Add(this.pbEodSms);
            this.Name = "EodSmsForm";
            this.Text = "EOD SMS";
            this.Load += new System.EventHandler(this.EodSmsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar pbEodSms;
        private MetroFramework.Controls.MetroTextBox txtBoxStatus;
    }
}

