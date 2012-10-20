using System;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using GINCommonControls;

namespace Gmail_Integration_Helper
{
    public partial class program
    {
        static string to, cc, bcc, body, subject, attach;
        static bool found = false;

        [STAThread]
        private static void Main(string[] args)
        {
            if (args.Length < 1 || args[0] == "-inbox" || args[0] == "inbox")
            {
                OpenPage.open();
            }
            else
            {
                switch (args[0])
                {
                    case "sendto":
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(true);
                        Application.Run(new QuickSend.QuickSend(args));
                        break;
                    case "doNothing":
                        break;
                    default:
                        sortArgs(args);
                        OpenPage.open(OpenPage.buildLink(mailToLink()));
                        break;
                }
            }
        }

        private static void sortArgs(string[] args)
        {
            foreach (string arg in args)
            {
                char[] splitter = ":?&=".ToCharArray();
                string[] splitted = arg.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < splitted.Length - 1; i++)
                {
                    to = to + argSorter(splitted[i], splitted[i + 1], "mailto");
                    body = body + argSorter(splitted[i], splitted[i + 1], "body");
                    subject = subject + argSorter(splitted[i], splitted[i + 1], "subject");
                    cc = cc + argSorter(splitted[i], splitted[i + 1], "cc");
                    bcc = bcc + argSorter(splitted[i], splitted[i + 1], "bcc");
                    attach = attach + argSorter(splitted[i], splitted[i + 1], "attachment");
                }
            }
        }

        private static string argSorter(string splitted, string nextSplitted, string checkFor)
        {
            if (splitted.ToLower() == checkFor)
            {
                return nextSplitted;
            }
            else return null;
        }

        private static string mailToLink()
        {
            string mailtoLink;
            StoredInfo.getInfo();
            RegistryKey usePrev = Registry.CurrentUser.OpenSubKey("Software\\Google Gmail");
            string[] progSet = usePrev.GetValueNames();
            foreach (string set in progSet)
            {
                if (set == "usePrev")
                {
                    found = true;
                }
            }
            if (found == true && usePrev.GetValue("usePrev").ToString() == "true")
            {
                mailtoLink = "https://mail.google.com/" + StoredInfo.hostSelection + "/?view=cm&fs=1&tf=1&ui=1&to=" + to + "&cc=" + cc + "&bcc=" + bcc + "&su=" + subject + "&body=" + body + "&attach=" + attach;
            }
            else
            {
                mailtoLink = "https://mail.google.com/" + StoredInfo.hostSelection + "/?view=cm&fs=1&tf=1&to=" + to + "&cc=" + cc + "&bcc=" + bcc + "&su=" + subject + "&body=" + body + "&attach=" + attach;
            }
            return mailtoLink;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct POINTL
    {
        public static int x;
        public static int y;
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("00000122-0000-0000-C000-000000000046")]
    public interface IDropTarget
    {
        [PreserveSig()]
        int DragEnter(System.Runtime.InteropServices.ComTypes.IDataObject pDataObj,               //  IDataObject
                      ulong grfKeyState,             //  DWORD
                      POINTL pt,
                      ref ulong pdwEffect);          //  DWORD*

        [PreserveSig()]
        int DragOver(ulong grfKeyState,              //  DWORD
                     POINTL pt,
                     ref ulong pdwEffect);           //  DWORD*

        [PreserveSig()]
        int DragLeave();

        [PreserveSig()]
        void Drop(System.Runtime.InteropServices.ComTypes.IDataObject pDataObj,                    //  IDataObject
                 ulong grfKeyState,                  //  DWORD
                 POINTL pt,
                 ref ulong pdwEffect);               //  DWORD*

    }

    public partial class program : IPersistFile
    {
        #region IPersistFile Members

        public void GetClassID(out Guid pClassID)
        {
            throw new NotImplementedException();
        }

        public void GetCurFile(out string ppszFileName)
        {
            throw new NotImplementedException();
        }

        public int IsDirty()
        {
            throw new NotImplementedException();
        }

        public void Load(string pszFileName, int dwMode)
        {
            return;
        }

        public void Save(string pszFileName, bool fRemember)
        {
            throw new NotImplementedException();
        }

        public void SaveCompleted(string pszFileName)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    
    public partial class program : IDropTarget
    {
        #region IDropTarget Members

        public int DragEnter(System.Runtime.InteropServices.ComTypes.IDataObject pDataObj, ulong grfKeyState, POINTL pt, ref ulong pdwEffect)
        {
            return 2;
        }

        public int DragOver(ulong grfKeyState, POINTL pt, ref ulong pdwEffect)
        {
            throw new NotImplementedException();
        }

        public int DragLeave()
        {
            throw new NotImplementedException();
        }

        public void Drop(System.Runtime.InteropServices.ComTypes.IDataObject pDataObj, ulong grfKeyState, POINTL pt, ref ulong pdwEffect)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new QuickSend.QuickSend(GetFilenames(pDataObj)));
            //QuickSend.QuickSend qs = new QuickSend.QuickSend(GetFilenames(pDataObj));
            //qs.Show();
            return;
        }

        #endregion

        [DllImport("shell32")]
        public static extern uint DragQueryFile(uint hDrop, uint iFile, StringBuilder buffer, int cch);

        private static string[] GetFilenames(System.Runtime.InteropServices.ComTypes.IDataObject dataObject)
        {

            string[] filenames = null;
            StringBuilder sb;
            STGMEDIUM medium = new STGMEDIUM();
            FORMATETC format = new FORMATETC();
            format.cfFormat = 15;
            format.dwAspect = DVASPECT.DVASPECT_CONTENT;
            format.lindex = -1;
            format.ptd = new IntPtr(0);
            format.tymed = TYMED.TYMED_HGLOBAL | TYMED.TYMED_ISTORAGE | TYMED.TYMED_ISTREAM | TYMED.TYMED_FILE;
            dataObject.GetData(ref format, out medium);
            uint nSelected = DragQueryFile((uint)medium.unionmember, 0xffffffff, null, 0);
            filenames = new string[nSelected + 1];
            filenames[0] = "sendto";

            for (uint i = 0; i < nSelected; i++)
            {
                sb = new StringBuilder(256);
                DragQueryFile((uint)medium.unionmember, i, sb, sb.Capacity + 1);
                filenames[i + 1] = sb.ToString();
            }
            return filenames;
        }       
    }
}