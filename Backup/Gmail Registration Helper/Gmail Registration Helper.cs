using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.Runtime.InteropServices;


namespace Gmail_Registration_Helper
{

    class Program
    {

        static string smFolder, installFolder, quickLink, dtLink;

        static void Main(string[] args)
        {
            //open the registry key in XP
            try
            {
                RegistryKey infoKey = Registry.LocalMachine.OpenSubKey("Software\\Google Gmail");
                if (infoKey == null)
                {
                    //open the registry key in Vista
                    infoKey = Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Google Gmail", true);
                }
                smFolder = infoKey.GetValue("smFolder").ToString();
                installFolder = infoKey.GetValue("installFolder").ToString();
                quickLink = infoKey.GetValue("quickLink").ToString();
                dtLink = infoKey.GetValue("dtLink").ToString();
            }
            catch
            {
            }
            if (args.Length > 0)
            {
                foreach (string arg in args)
                {
                    if (arg == "-hideIcons")
                    {
                        hideIcons();
                    }

                    else if (arg == "-showIcons")
                    {
                        showIcons();
                    }

                    else if (arg == "-reinstall")
                    {
                        reinstall();
                    }
                }
            }
            else
            {
                install();
            }
            SHChangeNotify(HChangeNotifyEventID.SHCNE_ALLEVENTS, HChangeNotifyFlags.SHCNF_DWORD, IntPtr.Zero, IntPtr.Zero);
            SHChangeNotify(HChangeNotifyEventID.SHCNE_ASSOCCHANGED, HChangeNotifyFlags.SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);
            SHChangeNotify(HChangeNotifyEventID.SHCNE_UPDATEDIR, HChangeNotifyFlags.SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);
        }
        private static void hideIcons()
        {
            if (File.Exists(dtLink))
            {
                File.Move(dtLink, installFolder + "\\dtLink.lnk");
            }

            if (Directory.Exists(smFolder))
            {
                Directory.Move(smFolder, installFolder + "\\smFolder");
            }

            if (File.Exists(quickLink))
            {
                File.Move(quickLink, installFolder + "\\quickLink.lnk");
            }

            uint mCtn = uint.Parse("0");
            SHSetUnreadMailCount("Gmail", mCtn, System.Environment.CurrentDirectory.ToString() + "//Gmail Icon Notifier.exe//");

            RegistryKey setDefault = Registry.LocalMachine.OpenSubKey("Software\\Clients\\Mail", true);
            if (setDefault == null)
            {
                setDefault = Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Clients\\Mail", true);
            }
            setDefault.SetValue("", "");

            RegistryKey showIcon = Registry.LocalMachine.OpenSubKey("Software\\Clients\\Mail\\Google Gmail\\InstallInfo", true);
            if (showIcon == null)
            {
                showIcon = Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Clients\\Mail\\Google Gmail\\InstallInfo", true);
            }
            showIcon.SetValue("IconsVisible", "0", RegistryValueKind.DWord);
        }

        private static void showIcons()
        {
            if (File.Exists(installFolder + "\\dtLink.lnk"))
            {
                File.Move(installFolder + "\\dtLink.lnk", dtLink);
            }

            if (Directory.Exists(installFolder + "\\smFolder"))
            {
                Directory.Move(installFolder + "\\smFolder", smFolder);
            }

            if (File.Exists(installFolder + "\\quickLink.lnk"))
            {
                File.Move(installFolder + "\\quickLink.lnk", quickLink);
            }

            RegistryKey showIcon = Registry.LocalMachine.OpenSubKey("Software\\Clients\\Mail\\Google Gmail\\InstallInfo", true);
            if (showIcon == null)
            {
                showIcon = Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Clients\\Mail\\Google Gmail\\InstallInfo", true);
            }
            showIcon.SetValue("IconsVisible", "1", RegistryValueKind.DWord);
        }

        private static void reinstall()
        {
            if (File.Exists(installFolder + "\\dtLink.lnk"))
            {
                File.Move(installFolder + "\\dtLink.lnk", dtLink);
            }

            if (Directory.Exists(installFolder + "\\smFolder"))
            {
                Directory.Move(installFolder + "\\smFolder", smFolder);
            }

            if (File.Exists(installFolder + "\\quickLink.lnk"))
            {
                File.Move(installFolder + "\\quickLink.lnk", quickLink);
            }

            RegistryKey setDefault = Registry.LocalMachine.OpenSubKey("Software\\Clients\\Mail", true);
            if (setDefault == null)
            {
                setDefault = Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Clients\\Mail", true);
            }
            setDefault.SetValue("", "Google Gmail");

            RegistryKey showIcon = Registry.LocalMachine.OpenSubKey("Software\\Clients\\Mail\\Google Gmail\\InstallInfo", true);
            if (showIcon == null)
            {
                showIcon = Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\Clients\\Mail\\Google Gmail\\InstallInfo", true);
            }
            showIcon.SetValue("IconsVisible", "1", RegistryValueKind.DWord);
        }

        private static void install()
        {
            string[] brokenPath = Directory.GetCurrentDirectory().Split('\\');
            string codeBaseString = "file:///";
            foreach (string pathPart in brokenPath)
            {
                codeBaseString += pathPart + "/";
            }
            codeBaseString += "Gmail Integration Helper.EXE";

            RegistryKey InprocServer = Registry.ClassesRoot.OpenSubKey(@"CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32", true);
            InprocServer.SetValue("CodeBase", codeBaseString);
            InprocServer = Registry.ClassesRoot.OpenSubKey(@"CLSID\{7b64789d-dd84-4698-9e69-0ee0313ab7fd}\InprocServer32\1.0.0.0", true);
            InprocServer.SetValue("CodeBase", codeBaseString);
        }

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHSetUnreadMailCount(string pszMailAddress, uint dwCount, string pszShellExecuteCommand);
        [DllImport("shell32.dll")]
        static extern void SHChangeNotify(HChangeNotifyEventID wEventId, HChangeNotifyFlags uFlags, IntPtr dwItem1, IntPtr dwItem2);

        private static bool CopyKey(RegistryKey parentKey,
        string keyNameToCopy, string newKeyName)
        {
            //Create new key
            RegistryKey destinationKey = parentKey.CreateSubKey(newKeyName);

            //Open the sourceKey we are copying from
            RegistryKey sourceKey = parentKey.OpenSubKey(keyNameToCopy);

            RecurseCopyKey(sourceKey, destinationKey);

            return true;
        }

        private static void RecurseCopyKey(RegistryKey sourceKey, RegistryKey destinationKey)
        {
            //copy all the values
            foreach (string valueName in sourceKey.GetValueNames())
            {
                object objValue = sourceKey.GetValue(valueName);
                RegistryValueKind valKind = sourceKey.GetValueKind(valueName);
                destinationKey.SetValue(valueName, objValue, valKind);
            }

            //For Each subKey 
            //Create a new subKey in destinationKey 
            //Call myself 
            foreach (string sourceSubKeyName in sourceKey.GetSubKeyNames())
            {
                RegistryKey sourceSubKey = sourceKey.OpenSubKey(sourceSubKeyName);
                RegistryKey destSubKey = destinationKey.CreateSubKey(sourceSubKeyName);
                RecurseCopyKey(sourceSubKey, destSubKey);
            }
        }

    }

    #region enum HChangeNotifyEventID
    /// <summary>
    /// Describes the event that has occurred.
    /// Typically, only one event is specified at a time.
    /// If more than one event is specified, the values contained
    /// in the <i>dwItem1</i> and <i>dwItem2</i>
    /// parameters must be the same, respectively, for all specified events.
    /// This parameter can be one or more of the following values.
    /// </summary>
    /// <remarks>
    /// <para><b>Windows NT/2000/XP:</b> <i>dwItem2</i> contains the index
    /// in the system image list that has changed.
    /// <i>dwItem1</i> is not used and should be <see langword="null"/>.</para>
    /// <para><b>Windows 95/98:</b> <i>dwItem1</i> contains the index
    /// in the system image list that has changed.
    /// <i>dwItem2</i> is not used and should be <see langword="null"/>.</para>
    /// </remarks>
    [Flags]
    enum HChangeNotifyEventID
    {
        /// <summary>
        /// All events have occurred.
        /// </summary>
        SHCNE_ALLEVENTS = 0x7FFFFFFF,

        /// <summary>
        /// A file type association has changed. <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/>
        /// must be specified in the <i>uFlags</i> parameter.
        /// <i>dwItem1</i> and <i>dwItem2</i> are not used and must be <see langword="null"/>.
        /// </summary>
        SHCNE_ASSOCCHANGED = 0x08000000,

        /// <summary>
        /// The attributes of an item or folder have changed.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the item or folder that has changed.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_ATTRIBUTES = 0x00000800,

        /// <summary>
        /// A nonfolder item has been created.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the item that was created.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_CREATE = 0x00000002,

        /// <summary>
        /// A nonfolder item has been deleted.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the item that was deleted.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_DELETE = 0x00000004,

        /// <summary>
        /// A drive has been added.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the root of the drive that was added.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_DRIVEADD = 0x00000100,

        /// <summary>
        /// A drive has been added and the Shell should create a new window for the drive.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the root of the drive that was added.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_DRIVEADDGUI = 0x00010000,

        /// <summary>
        /// A drive has been removed. <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the root of the drive that was removed.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_DRIVEREMOVED = 0x00000080,

        /// <summary>
        /// Not currently used.
        /// </summary>
        SHCNE_EXTENDED_EVENT = 0x04000000,

        /// <summary>
        /// The amount of free space on a drive has changed.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the root of the drive on which the free space changed.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_FREESPACE = 0x00040000,

        /// <summary>
        /// Storage media has been inserted into a drive.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the root of the drive that contains the new media.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_MEDIAINSERTED = 0x00000020,

        /// <summary>
        /// Storage media has been removed from a drive.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the root of the drive from which the media was removed.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_MEDIAREMOVED = 0x00000040,

        /// <summary>
        /// A folder has been created. <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/>
        /// or <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the folder that was created.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_MKDIR = 0x00000008,

        /// <summary>
        /// A folder on the local computer is being shared via the network.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the folder that is being shared.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_NETSHARE = 0x00000200,

        /// <summary>
        /// A folder on the local computer is no longer being shared via the network.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the folder that is no longer being shared.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_NETUNSHARE = 0x00000400,

        /// <summary>
        /// The name of a folder has changed.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the previous pointer to an item identifier list (PIDL) or name of the folder.
        /// <i>dwItem2</i> contains the new PIDL or name of the folder.
        /// </summary>
        SHCNE_RENAMEFOLDER = 0x00020000,

        /// <summary>
        /// The name of a nonfolder item has changed.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the previous PIDL or name of the item.
        /// <i>dwItem2</i> contains the new PIDL or name of the item.
        /// </summary>
        SHCNE_RENAMEITEM = 0x00000001,

        /// <summary>
        /// A folder has been removed.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the folder that was removed.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_RMDIR = 0x00000010,

        /// <summary>
        /// The computer has disconnected from a server.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the server from which the computer was disconnected.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// </summary>
        SHCNE_SERVERDISCONNECT = 0x00004000,

        /// <summary>
        /// The contents of an existing folder have changed,
        /// but the folder still exists and has not been renamed.
        /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or
        /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>.
        /// <i>dwItem1</i> contains the folder that has changed.
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
        /// If a folder has been created, deleted, or renamed, use SHCNE_MKDIR, SHCNE_RMDIR, or
        /// SHCNE_RENAMEFOLDER, respectively, instead.
        /// </summary>
        SHCNE_UPDATEDIR = 0x00001000,

        /// <summary>
        /// An image in the system image list has changed.
        /// <see cref="HChangeNotifyFlags.SHCNF_DWORD"/> must be specified in <i>uFlags</i>.
        /// </summary>
        SHCNE_UPDATEIMAGE = 0x00008000,

    }
    #endregion // enum HChangeNotifyEventID

    #region public enum HChangeNotifyFlags
    /// <summary>
    /// Flags that indicate the meaning of the <i>dwItem1</i> and <i>dwItem2</i> parameters.
    /// The uFlags parameter must be one of the following values.
    /// </summary>
    [Flags]
    public enum HChangeNotifyFlags
    {
        /// <summary>
        /// The <i>dwItem1</i> and <i>dwItem2</i> parameters are DWORD values.
        /// </summary>
        SHCNF_DWORD = 0x0003,
        /// <summary>
        /// <i>dwItem1</i> and <i>dwItem2</i> are the addresses of ITEMIDLIST structures that
        /// represent the item(s) affected by the change.
        /// Each ITEMIDLIST must be relative to the desktop folder.
        /// </summary>
        SHCNF_IDLIST = 0x0000,
        /// <summary>
        /// <i>dwItem1</i> and <i>dwItem2</i> are the addresses of null-terminated strings of
        /// maximum length MAX_PATH that contain the full path names
        /// of the items affected by the change.
        /// </summary>
        SHCNF_PATHA = 0x0001,
        /// <summary>
        /// <i>dwItem1</i> and <i>dwItem2</i> are the addresses of null-terminated strings of
        /// maximum length MAX_PATH that contain the full path names
        /// of the items affected by the change.
        /// </summary>
        SHCNF_PATHW = 0x0005,
        /// <summary>
        /// <i>dwItem1</i> and <i>dwItem2</i> are the addresses of null-terminated strings that
        /// represent the friendly names of the printer(s) affected by the change.
        /// </summary>
        SHCNF_PRINTERA = 0x0002,
        /// <summary>
        /// <i>dwItem1</i> and <i>dwItem2</i> are the addresses of null-terminated strings that
        /// represent the friendly names of the printer(s) affected by the change.
        /// </summary>
        SHCNF_PRINTERW = 0x0006,
        /// <summary>
        /// The function should not return until the notification
        /// has been delivered to all affected components.
        /// As this flag modifies other data-type flags, it cannot by used by itself.
        /// </summary>
        SHCNF_FLUSH = 0x1000,
        /// <summary>
        /// The function should begin delivering notifications to all affected components
        /// but should return as soon as the notification process has begun.
        /// As this flag modifies other data-type flags, it cannot by used by itself.
        /// </summary>
        SHCNF_FLUSHNOWAIT = 0x2000
    }
    #endregion // enum HChangeNotifyFlags
}
