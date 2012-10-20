using System;
using System.Windows.Forms;
using System.IO;
using GINCommonControls;

namespace Gmail_Icon_Notifier
{
    public partial class Notifier : Form
    {
        public static string openInboxText = "Open Inbox";
        public static string showNoticeText = "Show New Email Notification Now!";
        public static NotifyIcon notifyIcon = new NotifyIcon();

        public Notifier()
        {
            InitializeComponent();
            notifyIcon.DoubleClick += new EventHandler(openInbox_ToolStripMenuItem_Click);
            notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipClicked += new System.EventHandler(this.checkNow_All);
            shrinkMe();
            timer1.Start();
            CheckNow.setMode("all");
            CheckNow.check();
        }

        private void showAbout_Click(object sender, EventArgs e)
        {
            if (Controller.aboutOpen == false)
            {
                Controller.openAbout();
            }
            else
            {
                Controller.closeAbout();
            }
        }

        private void showAccountsAndSettings_Click(object sender, EventArgs e)
        {
            if (Controller.settingsOpen == false)
            {
                Controller.openSettings();
            }
            else
            {
                Controller.closeSettings();
            }
        }

        private void openInbox_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPage.open();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GIN\\tempaccounts.xml");
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GIN\\tempaccounts2.xml");
            notifyIcon.Dispose();
            Dispose();
        }

        private void checkNow_Normal(object sender, EventArgs e)
        {
            CheckNow.setMode("normal");
            CheckNow.check();
            shrinkMe();
        }

        private void checkNow_All(object sender, EventArgs e)
        {
            CheckNow.setMode("all");
            CheckNow.check();
        }

        private void checkNow_Notify(object sender, EventArgs e)
        {
            CheckNow.setMode("notif");
            CheckNow.check();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            CheckNow.setMode("normal");
            CheckNow.check();
        }

        private void Notifier_Deactivated(object sender, EventArgs e)
        {
            Hide();
        }

        private void updateMenu(object sender, System.ComponentModel.CancelEventArgs e)
        {
            openInbox_ToolStripMenuItem.Text = openInboxText;
            displayNewEmailAgain_ToolStripMenuItem.Text = showNoticeText;
            
            if (Controller.aboutOpen)
            {
                showAbout_ToolStripMenuItem.Text = "Hide About Gmail Icon Notifier";
            }
            else
            {
                showAbout_ToolStripMenuItem.Text = "Show About Gmail Icon Notifier";
            }
            if (Controller.settingsOpen)
            {
                showSettignsAndAccounts_ToolStripMenuItem.Text = "Hide Accounts and Settings";
            }
            else
            {
                showSettignsAndAccounts_ToolStripMenuItem.Text = "Show Accounts and Settings";
            }
        }

        private static void shrinkMe()
        {
            try
            {
                System.Diagnostics.Process.GetCurrentProcess().MaxWorkingSet = System.Diagnostics.Process.GetCurrentProcess().MinWorkingSet;
            }
            catch
            {
            }
        }
    }
}