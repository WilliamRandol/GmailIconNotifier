using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using System.IO;
using System.Xml;
using System.Net;
using System.Web;
using Microsoft.Win32;
using Google.GData.AccessControl;
using Google.GData.Contacts;
using Google.GData.Client;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace GINCommonControls
{
    public class Encryption
    {
        private static string key = "Qx74i";
        public static string Decrypt(string toDecrypt)
        {
                byte[] keyArray;
                byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                return UTF8Encoding.UTF8.GetString(resultArray);
        }
        public static string Encrypt(string toEncrypt)
        {
            if (toEncrypt != null)
            {
                byte[] keyArray;
                byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            return null;
        }

    }

    public static class StoredInfo
    {
        public static string username;
        public static string password;
        public static string accountSelection;
        public static string hostSelection;
        public static string emailAddress;
        public static string accountName;

        public static void getInfo()
        {

            DataTable dataTable1 = new DataTable();
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GIN\\accounts.xml"))
            {
                dataTable1.ReadXml(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GIN\\accounts.xml");
                DataRow[] dataSelect;
                dataSelect = dataTable1.Select("Default = 'Checked'", "ID");
                for (int i = 0; i < dataSelect.Length; i++)
                {
                    char[] unSplitter = "@".ToCharArray();
                    string[] unSplit = (dataSelect[i]["Email"].ToString().Split(unSplitter));
                    if (unSplit.Length > 1 && unSplit[1].ToLower() != "gmail.com" && unSplit[1].ToLower() != "googlemail.com")
                    {
                        username = unSplit[0];
                        accountSelection = "a/" + unSplit[1] + "/LoginAction2";
                        hostSelection = "a/" + unSplit[1];
                    }
                    else
                    {
                        username = dataSelect[i]["Email"].ToString();
                        accountSelection = "accounts/ServiceLoginAuth";
                        hostSelection = "mail";
                    }
                    password = Encryption.Decrypt(dataSelect[i]["Password"].ToString());
                    emailAddress = dataSelect[i]["Email"].ToString();
                    accountName = dataSelect[i]["Name"].ToString();
                }
            }
            if(hostSelection == null)
            {
                hostSelection = "mail";
            }
            if(accountSelection == null)
            {
                accountSelection = "accounts/ServiceLoginAuth";
            }
        }
    }

    public static class ReadXML
    {
        public static XmlDocument Mail = new XmlDocument();
        public static XmlNamespaceManager nsmgr;
        public static XmlNodeList rssItems;
        public static XmlNode root;
        public static bool badLogin, badConnection;

        public static void read()
        {
            StoredInfo.getInfo();
            //
            // Check the unread email feed
            //
            HttpWebRequest mailAsk = (HttpWebRequest)WebRequest.Create("https://mail.google.com/mail/feed/atom");
            mailAsk.Credentials = new NetworkCredential(StoredInfo.emailAddress, StoredInfo.password);
            mailAsk.ProtocolVersion = HttpVersion.Version10;
            mailAsk.Method = "GET";

            try
            {

                HttpWebResponse mailResponse = (HttpWebResponse)mailAsk.GetResponse();
                Stream mailStream = mailResponse.GetResponseStream();
                XmlTextReader mailRead = new XmlTextReader(mailStream);

                Mail.Load(mailRead);

                mailRead.Close();
                mailStream.Close();

                // Create an XmlNamespaceManager to resolve the default namespace.
                nsmgr = new XmlNamespaceManager(Mail.NameTable);
                nsmgr.AddNamespace("fd", "http://purl.org/atom/ns#");

                root = Mail.DocumentElement;
                rssItems = root.SelectNodes("/fd:feed/fd:entry", nsmgr);
                // rssItemCount = rssItems.Count;
                badLogin = false;
                badConnection = false;
            }
            catch (WebException er)
            {
                if (er.Status == WebExceptionStatus.ProtocolError)
                {
                    badLogin = true;
                }
                else
                {
                    badConnection = true;
                }
            }
        }
    }

    public static class OpenPage
    {
        public static string buildLink(string link)
        {
            StoredInfo.getInfo();
            //Create the instance of the website
            WebRequest req;
            req = WebRequest.Create("https://www.google.com/accounts/ClientLogin?accountType=HOSTED_OR_GOOGLE&Email=" + StoredInfo.emailAddress + "&Passwd=" + StoredInfo.password + "&service=mail&source=William_Randol-Gmail_Icon_Notifier-0.8_(rc1)");

            //Website is put into a stream that is then read
            Stream webStream;
            webStream = req.GetResponse().GetResponseStream();
            StreamReader webReader = new StreamReader(webStream);
            string fContents = "";
            fContents = webReader.ReadToEnd();

            // do something with the data and put it in a string variable called "data"
            //string data = "accountType=HOSTED_OR_GOOGLE&Email=" + StoredInfo.emailAddress + "&Passwd=" + StoredInfo.password + "&service=mail&source=William_Randol-Gmail_Icon_Notifier-0.8_(rc1)";

            //Send the data back to the website via a POST method
            //byte[] bytes = Encoding.ASCII.GetBytes(data);
            //req.ContentLength = bytes.Length;
            //req.Method = "POST";
            //req.ContentType = "application/x-www-form-urlencoded";
            //Stream dataStream = req.GetRequestStream();
            //dataStream.Write(bytes, 0, bytes.Length);
            //dataStream.Close();

            //Get a final response from the website
            WebResponse response = req.GetResponse();
            Stream rData = response.GetResponseStream();
            MessageBox.Show(rData.ToString());

            //RegistryKey usePrev = Registry.CurrentUser.OpenSubKey("Software\\Google Gmail");
            //if (isSet("useLoginPage", usePrev.GetValueNames()))
            //{
            //    if (usePrev.GetValue("useLoginPage").ToString() == "true")
            //    {
            //return "https://www.google.com/accounts/TokenAuth?auth=" +client.QueryAuthenticationToken() + "&service=mail&continue=" + HttpUtility.UrlEncode(link, Encoding.UTF8);
            //        //+ StoredInfo.accountSelection + &Email=" + StoredInfo.username + "
            //    }
            //}
            return link;
        }

        private static bool isSet(string regValue, string[] regValues)
        {
            bool found = false;
            foreach (string value in regValues)
            {
                if (value == regValue)
                {
                    found = true;
                }
            }
            return found;
        }


        public static void open(string link)
        {
            System.Diagnostics.Process.Start(link);
            //https://www.google.com/" + StoredInfo.accountSelection + "?service=mail&Email=" + StoredInfo.username + "&Passwd=" + StoredInfo.password + "&null=Sign%20in&rm=false&continue=
        }

        public static void open()
        {
            StoredInfo.getInfo();
            open(buildLink("https://mail.google.com/" + StoredInfo.hostSelection + "/#inbox"));
        }
    }
            
}
