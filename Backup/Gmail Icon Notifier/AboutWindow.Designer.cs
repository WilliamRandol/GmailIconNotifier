using System.Runtime.InteropServices;
using System;

namespace Gmail_Icon_Notifier
{
	partial class AboutWindow
	{
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.chekNow_Button = new System.Windows.Forms.Button();
            this.disclaimer = new System.Windows.Forms.Label();
            this.accountsSettings_Button = new System.Windows.Forms.Button();
            this.openInbox_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chekNow_Button
            // 
            this.chekNow_Button.BackColor = System.Drawing.Color.Transparent;
            this.chekNow_Button.Location = new System.Drawing.Point(209, 235);
            this.chekNow_Button.Name = "chekNow_Button";
            this.chekNow_Button.Size = new System.Drawing.Size(75, 23);
            this.chekNow_Button.TabIndex = 7;
            this.chekNow_Button.Text = "Check Now";
            this.chekNow_Button.UseVisualStyleBackColor = false;
            this.chekNow_Button.Click += new System.EventHandler(this.checkNow_Button_Click);
            // 
            // disclaimer
            // 
            this.disclaimer.BackColor = System.Drawing.Color.Transparent;
            this.disclaimer.ForeColor = System.Drawing.Color.Firebrick;
            this.disclaimer.Location = new System.Drawing.Point(12, 194);
            this.disclaimer.Name = "disclaimer";
            this.disclaimer.Size = new System.Drawing.Size(272, 38);
            this.disclaimer.TabIndex = 12;
            this.disclaimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountsSettings_Button
            // 
            this.accountsSettings_Button.Location = new System.Drawing.Point(9, 235);
            this.accountsSettings_Button.Name = "accountsSettings_Button";
            this.accountsSettings_Button.Size = new System.Drawing.Size(105, 23);
            this.accountsSettings_Button.TabIndex = 13;
            this.accountsSettings_Button.Text = "Accounts/Settings";
            this.accountsSettings_Button.UseVisualStyleBackColor = true;
            this.accountsSettings_Button.Click += new System.EventHandler(this.accountsSettings_Button_Click);
            // 
            // openInbox_Button
            // 
            this.openInbox_Button.Location = new System.Drawing.Point(123, 235);
            this.openInbox_Button.Name = "openInbox_Button";
            this.openInbox_Button.Size = new System.Drawing.Size(75, 23);
            this.openInbox_Button.TabIndex = 14;
            this.openInbox_Button.Text = "Open Inbox";
            this.openInbox_Button.UseVisualStyleBackColor = true;
            this.openInbox_Button.Click += new System.EventHandler(this.openInbox_Button_Click);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Gmail_Icon_Notifier.Properties.Resources.GINBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.openInbox_Button);
            this.Controls.Add(this.accountsSettings_Button);
            this.Controls.Add(this.disclaimer);
            this.Controls.Add(this.chekNow_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Gmail_Icon_Notifier.Properties.Resources.Gmail;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gmail Icon Notifier";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutWindow_FormClosing);
            this.ResumeLayout(false);

		}
        private System.Windows.Forms.Button accountsSettings_Button;
        private System.Windows.Forms.Label disclaimer;
        private System.Windows.Forms.Button chekNow_Button;
        private System.Windows.Forms.Button openInbox_Button;
		
	}
}
