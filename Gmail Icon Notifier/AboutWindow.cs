using System;
using System.Drawing;
using System.Windows.Forms;
using GINCommonControls;

namespace Gmail_Icon_Notifier
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
        }

        void checkNow_Button_Click(object sender, System.EventArgs e)
        {
            CheckNow.setMode("notif");
            CheckNow.check();
        }

        void accountsSettings_Button_Click(object sender, EventArgs e)
        {
            if (Controller.settingsOpen)
            {
                Controller.closeSettings();
            }
            else
            {
                Controller.openSettings();
            }
        }

        void openInbox_Button_Click(object sender, EventArgs e)
        {
            StoredInfo.getInfo();
            System.Diagnostics.Process.Start("https://www.google.com/" + StoredInfo.accountSelection + "?service=mail&Email=" + StoredInfo.username + "&Passwd=" + StoredInfo.password + "&null=Sign%20in&rm=false&continue=https%3A%2F%2Fmail.google.com%2F" + StoredInfo.hostSelection + "%2F%23inbox");
        }
        private void AboutWindow_Load(object sender, EventArgs e)
        {
            Controller.aboutOpen = true;
        }

        private void AboutWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.aboutOpen = false;
        }
    }
}