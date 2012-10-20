namespace Gmail_Icon_Notifier
{
    partial class Notifier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInbox_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkNow_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayNewEmailAgain_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showAbout_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSettignsAndAccounts_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInbox_ToolStripMenuItem,
            this.checkNow_ToolStripMenuItem,
            this.displayNewEmailAgain_ToolStripMenuItem,
            this.toolStripSeparator1,
            this.showAbout_ToolStripMenuItem,
            this.showSettignsAndAccounts_ToolStripMenuItem,
            this.toolStripSeparator2,
            this.exit_ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(235, 148);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.updateMenu);
            // 
            // openInbox_ToolStripMenuItem
            // 
            this.openInbox_ToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openInbox_ToolStripMenuItem.Name = "openInbox_ToolStripMenuItem";
            this.openInbox_ToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.openInbox_ToolStripMenuItem.Text = "Open Inbox";
            this.openInbox_ToolStripMenuItem.Click += new System.EventHandler(this.openInbox_ToolStripMenuItem_Click);
            // 
            // checkNow_ToolStripMenuItem
            // 
            this.checkNow_ToolStripMenuItem.Name = "checkNow_ToolStripMenuItem";
            this.checkNow_ToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.checkNow_ToolStripMenuItem.Text = "Check Now";
            this.checkNow_ToolStripMenuItem.Click += new System.EventHandler(this.checkNow_Notify);
            // 
            // displayNewEmailAgain_ToolStripMenuItem
            // 
            this.displayNewEmailAgain_ToolStripMenuItem.Name = "displayNewEmailAgain_ToolStripMenuItem";
            this.displayNewEmailAgain_ToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.displayNewEmailAgain_ToolStripMenuItem.Text = "Show New Email Notification Now!";
            this.displayNewEmailAgain_ToolStripMenuItem.Click += new System.EventHandler(this.checkNow_All);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // showAbout_ToolStripMenuItem
            // 
            this.showAbout_ToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAbout_ToolStripMenuItem.Name = "showAbout_ToolStripMenuItem";
            this.showAbout_ToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.showAbout_ToolStripMenuItem.Text = "Show About Gmail Icon Notifier";
            this.showAbout_ToolStripMenuItem.Click += new System.EventHandler(this.showAbout_Click);
            // 
            // showSettignsAndAccounts_ToolStripMenuItem
            // 
            this.showSettignsAndAccounts_ToolStripMenuItem.Name = "showSettignsAndAccounts_ToolStripMenuItem";
            this.showSettignsAndAccounts_ToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.showSettignsAndAccounts_ToolStripMenuItem.Text = "Show Accounts and Settings";
            this.showSettignsAndAccounts_ToolStripMenuItem.Click += new System.EventHandler(this.showAccountsAndSettings_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.exit_ToolStripMenuItem.Text = "Exit";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.checkNow_Normal);
            // 
            // Notifier
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(0, 0);
            this.ControlBox = false;
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::Gmail_Icon_Notifier.Properties.Resources.Gmail;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notifier";
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Notifier_Deactivated);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ToolStripMenuItem showSettignsAndAccounts_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem displayNewEmailAgain_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInbox_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem checkNow_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAbout_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Timer timer1;

            // 
            // notifyIcon1
            // 


    }
}
