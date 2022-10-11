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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.lblItems = new MetroFramework.Controls.MetroLabel();
            this.lblMessages = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // pbEodSms
            // 
            this.pbEodSms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEodSms.Location = new System.Drawing.Point(23, 128);
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
            this.txtBoxStatus.CustomButton.Location = new System.Drawing.Point(323, 2);
            this.txtBoxStatus.CustomButton.Name = "";
            this.txtBoxStatus.CustomButton.Size = new System.Drawing.Size(145, 145);
            this.txtBoxStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxStatus.CustomButton.TabIndex = 1;
            this.txtBoxStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxStatus.CustomButton.UseSelectable = true;
            this.txtBoxStatus.CustomButton.Visible = false;
            this.txtBoxStatus.Lines = new string[0];
            this.txtBoxStatus.Location = new System.Drawing.Point(23, 157);
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
            this.txtBoxStatus.Size = new System.Drawing.Size(471, 150);
            this.txtBoxStatus.TabIndex = 3;
            this.txtBoxStatus.UseSelectable = true;
            this.txtBoxStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(22, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(133, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Items not returned";
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(368, 64);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(126, 45);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Send SMS";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(187, 60);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(0, 0);
            this.lblItems.TabIndex = 6;
            this.lblItems.Visible = false;
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Location = new System.Drawing.Point(187, 90);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(0, 0);
            this.lblMessages.TabIndex = 8;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(22, 90);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(104, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Messages sent";
            // 
            // EodSmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 330);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtBoxStatus);
            this.Controls.Add(this.pbEodSms);
            this.Name = "EodSmsForm";
            this.Text = "EOD SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar pbEodSms;
        private MetroFramework.Controls.MetroTextBox txtBoxStatus;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel lblItems;
        private MetroFramework.Controls.MetroLabel lblMessages;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

