using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Security.Cryptography;
using Microsoft.Win32;
using GINCommonControls;

namespace Gmail_Icon_Notifier
{
    public partial class Settings : Form
    {
        private DataRow selectedRow;

        public Settings()
        {
            InitializeComponent();
            XMLCheck();
            getSelectedRow();
            testRows();
            startUpCheck();
        }

        public void setNewAccount(string newAccount)
        {
            DataRow newRow = accounts_Table.NewRow();
            newRow["Name"] = newAccount;
            accounts_Table.Rows.Add(newRow);
            apply_Button.Enabled = true;
            getSelectedRow();
            testRows();
        }

        private void XMLCheck()
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GIN"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GIN");
            }

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GIN\\accounts.xml"))
            {
                accounts_Table.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GIN\\accounts.xml", XmlWriteMode.WriteSchema, true);
            }

            else
            {
                accounts_Table.ReadXml(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GIN\\accounts.xml");
            }
        }

        private void testRows()
        {
            DataRow[] rows = accounts_Table.Select();
            if ( rows.Length == 0)
            {
                account_ComboBox.Enabled = false;
                emailAddress_TextBox.Enabled = false;
                password_TextBox.Enabled = false;
                useAsDefault_CheckBox.Enabled = false;
                deleteAccount_Button.Enabled = false;
            }
            else
            {
                account_ComboBox.Enabled = true;
                emailAddress_TextBox.Enabled = true;
                password_TextBox.Enabled = true;
                useAsDefault_CheckBox.Enabled = true;
                deleteAccount_Button.Enabled = true;
            }
            if (rows.Length == 1)
            {
                selectedRow["Default"] = "Checked";
                useAsDefault_CheckBox.CheckState = CheckState.Checked;
                useAsDefault_CheckBox.Enabled = false;
            }
            else if (rows.Length > 1)
            {
                DataRow[] checkedRows = accounts_Table.Select("[Default] = 'Checked'");
                if (checkedRows.Length != 1)
                {
                    selectedRow["Default"] = "Checked";
                }
            }
        }

        private void startUpCheck()
        {
            RegistryKey startup = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
            if (isSet("Gmail Icon Notifier", startup.GetValueNames()))
            {
                startWithWindows_CheckBox.CheckState = CheckState.Checked;
            }
            else
            {
                startWithWindows_CheckBox.CheckState = CheckState.Unchecked;
            }

            RegistryKey usePrev = Registry.CurrentUser.OpenSubKey("Software\\Google Gmail");
            if (isSet("usePrev", usePrev.GetValueNames()))
            {
                if (usePrev.GetValue("usePrev").ToString() == "true")
                {
                    usePrevVer_CheckBox.CheckState = CheckState.Checked;
                }
                else
                {
                    usePrevVer_CheckBox.CheckState = CheckState.Unchecked;
                }
            }
            if (isSet("useLoginPage", usePrev.GetValueNames()))
            {
                if (usePrev.GetValue("useLoginPage").ToString() == "true")
                {
                    useLoginPage_CheckBox.CheckState = CheckState.Checked;
                }
                else
                {
                    useLoginPage_CheckBox.CheckState = CheckState.Unchecked;
                }
            }
        }

        private bool isSet(string regValue, string[] regValues)
        {
            bool found = false;
            foreach (string value in regValues)
            {
                if (value== regValue)
                {
                    found = true;
                }
            }
            return found;
        }
    
        private void cleanup()
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GIN\\tempaccounts.xml");
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GIN\\tempaccounts2.xml");
        }

        private void getSelectedRow()
        {
            if ((DataRowView)account_ComboBox.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)account_ComboBox.SelectedItem;
                //selectedRow = accounts_Table.Select("[ID] = " + rowView.Row["ID"]);
                selectedRow = rowView.Row;
            }
        }

        private void updateForm()
        {
            emailAddress_TextBox.Text = selectedRow["Email"].ToString();

            if (selectedRow["Default"].ToString() == "Checked")
            {
                useAsDefault_CheckBox.CheckState = CheckState.Checked;
                useAsDefault_CheckBox.Enabled = false;
            }
            else
            {
                useAsDefault_CheckBox.CheckState = CheckState.Unchecked;
                useAsDefault_CheckBox.Enabled = true;
            }

            if (selectedRow["Password"].ToString() != "")
            {
                password_TextBox.Text = Encryption.Decrypt(selectedRow["Password"].ToString());
            }
            else
            {
                password_TextBox.Text = "";
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.settingsOpen = false;
            cleanup();
        }

        private void settings_Enter(object sender, EventArgs e)
        {
            try
            {
                updateForm();
            }
            catch { }
        }

        private void email_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (emailAddress_TextBox.Focused == true)
            {
                selectedRow["Email"] = emailAddress_TextBox.Text;
                apply_Button.Enabled = true;
            }
        }

        private void password_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (password_TextBox.Focused == true)
            {
                selectedRow["Password"] = Encryption.Encrypt(password_TextBox.Text);
                apply_Button.Enabled = true;
            }
        }

        private void ok_Button_Click(object sender, EventArgs e)
        {
            if (apply_Button.Enabled == true)
            {
                apply_Button_Click(sender, e);
            }
            CheckNow.setMode("all");
            CheckNow.check();
            cancel_Button_Click(sender, e);
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void apply_Button_Click(object sender, EventArgs e)
        {
            if (startWithWindows_CheckBox.CheckState == CheckState.Checked)
            {
                bool found = false;
                RegistryKey startup = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                string[] startProgs = startup.GetValueNames();
                foreach (string name in startProgs)
                {
                    if (name == "Gmail Icon Notifier")
                    {
                        found = true;
                    }
                    if (found == false)
                    {
                        startup.SetValue("Gmail Icon Notifier", System.IO.Path.GetFullPath(System.Reflection.Assembly.GetExecutingAssembly().Location));
                    }
                }
            }
            else if (startWithWindows_CheckBox.CheckState == CheckState.Unchecked)
            {
                bool found = false;
                RegistryKey startup = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                string[] startProgs = new string[0];
                startProgs = startup.GetValueNames();
                foreach (string name in startProgs)
                {
                    if (name == "Gmail Icon Notifier")
                    {
                        found = true;
                    }
                    if (found == true)
                    {
                        startup.DeleteValue("Gmail Icon Notifier");
                    }
                }
                CheckNow.setMode("normal");
                CheckNow.check();
            }
            RegistryKey usePrev = Registry.CurrentUser.OpenSubKey("Software\\Google Gmail", true);
            if (usePrevVer_CheckBox.CheckState == CheckState.Checked)
            {
                usePrev.SetValue("usePrev", "true");
            }
            else if (usePrevVer_CheckBox.CheckState == CheckState.Unchecked)
            {
                usePrev.SetValue("usePrev", "false");
            }
            if (useLoginPage_CheckBox.CheckState == CheckState.Checked)
            {
                usePrev.SetValue("useLoginPage", "true");
            }
            else
            {
                usePrev.SetValue("useLoginPage", "false");
            }

            accounts_Table.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GIN\\accounts.xml", XmlWriteMode.WriteSchema, true);
            apply_Button.Enabled = false;
        }

        private void addNewAccount_Button_Click(object sender, EventArgs e)
        {
            NewAccountInput newAccount = new NewAccountInput();
            newAccount.Show();
            testRows();
        }

        private void deleteAccount_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to remove the account for " + selectedRow["Name"] + "?", "Delete Account?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            accounts_Table.Rows.Remove(selectedRow);
            testRows();
        }

        private void useAsDefault_CheckBox_Click(object sender, EventArgs e)
        {
            DataRow[] rows = accounts_Table.Select();
            foreach (DataRow row in rows)
            {
                if (row["ID"] != selectedRow["ID"])
                {
                    row["Default"] = "Unchecked";
                }
            }
            selectedRow["Default"] = "Checked";
            apply_Button.Enabled = true;
        }

        private void account_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSelectedRow();
            updateForm();
        }

        private void startWithWindows_CheckBox_Click(object sender, EventArgs e)
        {
            apply_Button.Enabled = true;
        }
        
        private void timeBetween_TrackBar_Scroll(object sender, EventArgs e)
        {
            if (timeBetween_TrackBar.Value.ToString() == "0")
            {
                timeBetween_Label.Text = "Time Betwen Notifications ( Off )";
            }
            else
            {
                timeBetween_Label.Text = "Time Betwen Notifications (" + timeBetween_TrackBar.Value.ToString() + " min)";
            }

            selectedRow["CheckFreq"] = (timeBetween_TrackBar.Value * 60000).ToString();
            apply_Button.Enabled = true;
        }

        private void accountSettings_TabControl_Click(object sender, EventArgs e)
        {
            if (timeBetween_TrackBar.Value.ToString() == "0")
            {
                timeBetween_Label.Text = "Time Betwen Notifications ( Off )";
            }
            else
            {
                timeBetween_Label.Text = "Time Betwen Notifications (" + timeBetween_TrackBar.Value.ToString() + " min)";
            }

        }

        private void useLoginPage_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            apply_Button.Enabled = true;
        }

    }
}

