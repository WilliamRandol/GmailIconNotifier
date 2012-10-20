using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Collections;
using Google.GData.Client;
using Google.GData.Contacts;
using Google.GData.Extensions;
using Google.Contacts;
using SplashScreen;
//using Gmail_Integration_Helper;
//using System.Runtime.InteropServices;
//using System.Runtime.InteropServices.ComTypes;
using GINCommonControls;


namespace QuickSend
{
    public partial class QuickSend : Form
    {
        public static bool showQS;
        private frmSplash splash = new frmSplash();

        public QuickSend(string[] args)
        {
            splash.Show();
            StoredInfo.getInfo();
            InitializeComponent();
            user = StoredInfo.username;
            pass = StoredInfo.password;
            email = StoredInfo.emailAddress;
            Text += " as " + email;
            sortAttachments(args);
            GetContactList(user, pass);
            splash.Close();
        }

        private void sortAttachments(string[] attachments)
        {
            for (int i = 1; i < attachments.Length; i++)
            {
                DataRow newRow = attachmentTable.NewRow();
                newRow["Attachments"] = attachments[i];
                attachmentTable.Rows.Add(newRow);
            }
        }

        private void GetContactList(string username, string password)
        {
            contactTable.Columns.Add("Photo", typeof(System.Drawing.Bitmap));
            contactTable.Columns.Add("Name", typeof(string));
            contactTable.Columns.Add("Email", typeof(string));
            toDataGrid.DataSource = contactTable;
            toDataGrid.ShowCellToolTips = false;
            ccDataGrid.DataSource = contactTable;
            bccDataGrid.DataSource = contactTable;
            DataGridViewColumn column = toDataGrid.Columns[0];
            column.Width = 42;
            column.HeaderText = "";
            column = ccDataGrid.Columns[0];
            column.Width = 42;
            column.HeaderText = "";
            column = bccDataGrid.Columns[0];
            column.Width = 42;
            column.HeaderText = "";

            ContactsService client = new ContactsService("William Randol-Gmail Icon Notifier-0.8 (RC1)");
            client.setUserCredentials(user, pass);
            string authToken = client.QueryAuthenticationToken(); // Authenticate the user immediately

            RequestSettings rs = new RequestSettings("Gmail Icon Notifier", user, pass);
            rs.AutoPaging = true;
            ContactsRequest cr = new ContactsRequest(rs);

            Feed<Contact> f = cr.GetContacts();

            foreach (Contact c in f.Entries)
            {
                foreach (EMail email in c.Emails)
                {
                    contactTable.Rows.Add(contactPhoto(c, authToken), c.Title, email.Address);
                }
            }
        }

        private void sendMessage()
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(user);
            char[] splitter = ",;".ToCharArray();
            string[] toList = toTextBox.Text.Split(splitter);
            for (int i = 0; i < toList.Length; i++)
            {
                if (toList[i].Trim() != "")
                {
                    mail.To.Add(toList[i].Trim());
                }
            }
            if (ccTextBox.Text != "")
            {
                string[] ccList = ccTextBox.Text.Split(splitter);
                for (int i = 0; i < ccList.Length; i++)
                {
                    mail.CC.Add(ccList[i].Trim());
                }
            }
            if (bccTextBox.Text != "")
            {
                string[] bccList = bccTextBox.Text.Split(splitter);
                for (int i = 0; i < bccList.Length; i++)
                {
                    mail.Bcc.Add(bccList[i].Trim());
                }
            }
            if (attachmentTable.Rows.Count > 0)
            {
                for (int i = 0; i < attachmentTable.Rows.Count; i++)
                {

                    mail.Attachments.Add(new Attachment(attachmentTable.Rows[i]["Attachments"].ToString()));
                }
            }
            mail.Subject = subjectTextBox.Text.ToString();
            mail.Body = messageTextBox.Text.ToString();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Credentials = new NetworkCredential(user, pass);
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mail);
            Close();
        }

        private void toButton_Click(object sender, EventArgs e)
        {
            if (toDataGrid.Visible == false)
            {
                toDataGrid.Visible = true;
                ccDataGrid.Visible = false;
                bccDataGrid.Visible = false;
            }
            else
            {
                toDataGrid.Visible = false;
            }
        }

        private void ccButton_Click(object sender, EventArgs e)
        {
            if (ccDataGrid.Visible == false)
            {
                ccDataGrid.Visible = true;
                toDataGrid.Visible = false;
                bccDataGrid.Visible = false;
            }
            else
            {
                ccDataGrid.Visible = false;
            }
        }

        private void bccButton_Click(object sender, EventArgs e)
        {
            if (bccDataGrid.Visible == false)
            {
                bccDataGrid.Visible = true;
                toDataGrid.Visible = false;
                ccDataGrid.Visible = false;
            }
            else
            {
                bccDataGrid.Visible = false;
            }
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            if (attachmentOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    for (int i = 0; i < attachmentOpenFileDialog.FileNames.Length; i++)
                    {
                        DataRow newRow = attachmentTable.NewRow();
                        newRow["Attachments"] = attachmentOpenFileDialog.FileNames[i];
                        attachmentTable.Rows.Add(newRow);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not find file. Original error: " + ex.Message);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void attachmentGridView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void attachmentGridView_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
            {
                DataRow newRow = attachmentTable.NewRow();
                newRow["Attachments"] = s[i];
                attachmentTable.Rows.Add(newRow);
            }

        }

        private void dataGridView_Leave(object sender, EventArgs e)
        {
            if (!toButton.Focused && !ccButton.Focused && !bccButton.Focused)
            ((DataGridView)sender).Visible = false;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string addText = ((DataGridView)sender).Rows[e.RowIndex].Cells["Email"].Value.ToString() + "; ";
            if (((DataGridView)sender) == toDataGrid)
            {
                toTextBox.Text = toTextBox.Text + addText;
            }
            if (((DataGridView)sender) == ccDataGrid)
            {
                ccTextBox.Text = ccTextBox.Text + addText;
            }
            if (((DataGridView)sender) == bccDataGrid)
            {
                bccTextBox.Text = bccTextBox.Text + addText;
            }
        }

        private void dataGridView_MouseHover(object sender, EventArgs e)
        {
            contactGridToolTip.Show("Double Click a Contact to Add Them.", (DataGridView)sender);
        }

        private Bitmap contactPhoto(Contact c, string authToken)
        {
            HttpWebRequest req;
            HttpWebResponse resp;
            if (c.PhotoEtag != null)
            {
                req = (HttpWebRequest)HttpWebRequest.Create(c.PhotoUri);
                req.Headers.Add("Authorization", "GoogleLogin auth=" + authToken);
            }
            else
            {
                req = (HttpWebRequest)HttpWebRequest.Create("http://mail.google.com/mail/contacts/static/images/NoPicture.gif");
            }
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch
            {
                req = (HttpWebRequest)HttpWebRequest.Create("http://mail.google.com/mail/contacts/static/images/NoPicture.gif");
                resp = (HttpWebResponse)req.GetResponse();
            }
            Stream str = resp.GetResponseStream();
            Bitmap objBitmap = new Bitmap(str);
            objBitmap = new Bitmap(objBitmap.GetThumbnailImage(42, 42, null, IntPtr.Zero));
            return objBitmap;
        }
    }
}
