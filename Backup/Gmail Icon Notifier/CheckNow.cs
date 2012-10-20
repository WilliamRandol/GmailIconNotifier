using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GINCommonControls;

namespace Gmail_Icon_Notifier
{
    public static class CheckNow
    {
        private static long[] modified;
        private static string[] title, link, description, name, modifiedStr;
        private static int full, rssItemCount, StartOn;
        private static string fullcount, updatedStr, mode;
        private static long lastModified, updated;
        private static bool showPopUp = true;
        private static XmlNode rssDetail;

        public static void check()
        {
            ReadXML.read();
            sortXML();
            setWinUnread();
            setNotifier();
            if (!ReadXML.badLogin)
            {
                notify();
            }
        }

        public static void setMode(string md)
        {
            mode = md;
        }

        public static void sortXML()
        {
            if (!ReadXML.badLogin)
            {
                rssItemCount = ReadXML.rssItems.Count;

                if (updatedStr == null)
                {
                    updatedStr = ReadXML.root.SelectNodes("/fd:feed", ReadXML.nsmgr).Item(0).SelectSingleNode("fd:modified", ReadXML.nsmgr).InnerText;
                    lastModified = 0;
                }
                else
                {
                    lastModified = updated;
                    updatedStr = ReadXML.root.SelectNodes("/fd:feed", ReadXML.nsmgr).Item(0).SelectSingleNode("fd:modified", ReadXML.nsmgr).InnerText;
                }
                updated = dateConverter(updatedStr);

                fullcount = ReadXML.root.SelectNodes("/fd:feed", ReadXML.nsmgr).Item(0).SelectSingleNode("fd:fullcount", ReadXML.nsmgr).InnerText;
                full = int.Parse(fullcount);
                title = new string[rssItemCount];
                link = new string[rssItemCount];
                description = new string[rssItemCount];
                name = new string[rssItemCount];
                modifiedStr = new string[rssItemCount];
                modified = new long[rssItemCount];
                StartOn = rssItemCount - 1;
                char[] splitter = "&=".ToCharArray();
                for (int i = rssItemCount - 1; i >= 0; i--)
                {
                    link[i] = fillDetails(i, "fd:link", "No Link");
                    title[i] = fillDetails(i, "fd:title", "No Title");
                    description[i] = fillDetails(i, "fd:summary", "No Description");
                    name[i] = fillDetails(i, "fd:author/fd:name", "No Name");
                    modifiedStr[i] = fillDetails(i, "fd:modified", "0");
                    modified[i] = dateConverter(modifiedStr[i]);
                    setStartOn(i);

                    string[] idsplit = (link[i].Split(splitter));
                    link[i] = idsplit[3];
                    StoredInfo.getInfo();
                    link[i] = "https://mail.google.com/" + StoredInfo.hostSelection + "/#inbox/" + link[i];
                    //https://www.google.com/" + StoredInfo.accountSelection + "?service=mail&continue=&Email=" + StoredInfo.username + "&Passwd=" + StoredInfo.password + "&null=Sign%20in&rm=false
                    title[i] = Regex.Replace(title[i], "&#39;", "'");
                    description[i] = Regex.Replace(description[i], "&#39;", "'");
                    description[i] = Regex.Replace(description[i], " &hellip;", "…");
                }
            }
            else
            {
                Controller.openSettings();
            }

            //}
            //catch
            //{
            //    updatedStr = ReadXML.root.SelectNodes("/fd:feed", ReadXML.nsmgr).Item(0).SelectSingleNode("fd:modified", ReadXML.nsmgr).InnerText;
            //    sortXML();
            //}
        }

        private static void setStartOn(int i)
        {
            if (modified[i] <= lastModified && lastModified != 0)
            {
                showPopUp = false;
            }
            else if (modified[i] > lastModified)
            {
                showPopUp = true;
                if (i <= StartOn && StartOn == rssItemCount - 1)
                {
                    StartOn = i;
                }
            }
            else if (lastModified == 0)
            {
                showPopUp = true;
                StartOn = rssItemCount - 1;
            }
        }

        private static void setNotifier()
        {
            if (full == 1)
            {
                Notifier.notifyIcon.Text = "Gmail Icon Notifier - You have " + fullcount + " unread email";
                Notifier.openInboxText = "Open Inbox (" + fullcount + " unread email)";
                Notifier.showNoticeText = "Show the One Available Alert Now.";
                Notifier.notifyIcon.Icon = global::Gmail_Icon_Notifier.Properties.Resources.Gmail;
            }
            else if (full > 1)
            {
                Notifier.notifyIcon.Text = "Gmail Icon Notifier - You have " + fullcount + " unread emails";
                Notifier.openInboxText = "Open Inbox (" + fullcount + " unread emails)";
                Notifier.showNoticeText = "Show All " + title.Length.ToString() + " Available Alerts Now.";
                Notifier.notifyIcon.Icon = global::Gmail_Icon_Notifier.Properties.Resources.Gmail;
            }
            else if (full == 0)
            {
                Notifier.notifyIcon.Text = "Gmail Icon Notifier - You have no unread emails";
                Notifier.openInboxText = "Open Inbox (no unread email)";
                Notifier.showNoticeText = "There are No Available Alerts.";
                showPopUp = false;
                Notifier.notifyIcon.Icon = global::Gmail_Icon_Notifier.Properties.Resources.GmailGrey;
            }
        }

        private static void setWinUnread()
        {
            uint mCtn = Convert.ToUInt32(full);
            SHSetUnreadMailCount("Google Gmail", mCtn, System.Environment.CurrentDirectory.ToString() + "//Gmail Icon Notifier.exe//");
        }

        private static void notify()
        {
            if (mode == "all")
            {
                StartOn = rssItemCount - 1;
                showPopUp = true;
            }
            if (mode == "notif" && showPopUp == false)
            {
                Notifier.notifyIcon.BalloonTipTitle = "No New Email";
                if (rssItemCount > 1)
                {
                    Notifier.notifyIcon.BalloonTipText = "You have no new email.\r\nClick this baloon tip to view the last " + title.Length.ToString() + " notifications";
                }
                else if (rssItemCount == 1)
                {
                    Notifier.notifyIcon.BalloonTipText = "You have no new email.\r\nClick this baloon tip to view the last notification";
                }
                else if (rssItemCount < 1)
                {
                    Notifier.notifyIcon.BalloonTipText = "You have no new email.";
                }
                Notifier.notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                Notifier.notifyIcon.ShowBalloonTip(150);
            }
            else if (showPopUp == true)
            {
                PopupBox popupbox = new PopupBox(title, link, description, name, fullcount, StartOn);
            }
        }

        private static long dateConverter(string date)
        {
            date = Regex.Replace(date, "-", "");
            date = Regex.Replace(date, ":", "");
            date = Regex.Replace(date, "Z", "");
            date = Regex.Replace(date, "T", "");
            return Convert.ToInt64(date);

        }

        private static string fillDetails(int i, string xmlNode, string altText)
        {
            string toFill;
            rssDetail = ReadXML.rssItems.Item(i).SelectSingleNode(xmlNode, ReadXML.nsmgr);
            if (rssDetail != null)
            {
                if (xmlNode != "fd:link")
                {
                    toFill = rssDetail.InnerText;
                }
                else
                {
                    toFill = rssDetail.Attributes[1].Value;
                }
            }
            else
            {
                toFill = altText;
            }
            return toFill;
        }

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        private static extern uint SHSetUnreadMailCount(string pszMailAddress, uint dwCount, string pszShellExecuteCommand);
    }
}