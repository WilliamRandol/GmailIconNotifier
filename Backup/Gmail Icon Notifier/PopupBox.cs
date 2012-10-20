using System;
using System.Media;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Gmail_Icon_Notifier
{
	/// <summary>
	/// Description of PopupBox.
	/// </summary>
	public partial class PopupBox : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
		private bool mouseOver;
		private int msgNumber, full;
        private string[] title, links, description, name;
        private string link, fullcount;

        public PopupBox(string[] t, string[] l, string[] d, string[] n, string f, int m)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            BackgroundImage = ResizeBitmap(global::Gmail_Icon_Notifier.Properties.Resources.background, Width, Height);
            ShowWindow(Handle, WindowShowStyle.ShowNoActivate);
			int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
			int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
			Left = screenWidth - Width;
			Top = screenHeight;
			timer1.Start();
            title = t;
            links = l;
            description = d;
            name = n;
            fullcount = f;
            msgNumber = m;
            full = int.Parse(fullcount);
			displayMessage(msgNumber, "start");
            try
            {
                RegistryKey emailSnd = Registry.CurrentUser.OpenSubKey("AppEvents\\Schemes\\Apps\\.Default\\MailBeep\\.Current");
                string soundStr = emailSnd.GetValue("").ToString();
                SoundPlayer emailSound = new SoundPlayer(soundStr);
                emailSound.Play();
            }
            catch { }
        }

        private void displayMessage(int mgn, string caller)
		{
            msgNumber = mgn;
            if (msgNumber >= 0)
			{
				link_Label.Text = title[msgNumber];
				label3.Text = description[msgNumber];
				label4.Text = name[msgNumber];
				link = links[msgNumber];
                label5.Text = ((full + 1) - (full - msgNumber)).ToString() + " of " + fullcount;//title.Length.ToString();
				if (title.Length-1 == 0)
				{
					button1.Visible = false;
					button2.Visible = false;
					button3.Visible = false;
					button4.Visible = false;
				}
				else if (msgNumber >= title.Length-1)
				{
					button1.Visible = false;
					button2.Visible = false;
					button3.Visible = true;
					button4.Visible = true;
				}
				else if (msgNumber <= 0)
				{
					button1.Visible = true;
					button2.Visible = true;
					button3.Visible = false;
					button4.Visible = false;
				}
				else
				{
					button1.Visible = true;
					button2.Visible = true;
					button3.Visible = true;
					button4.Visible = true;
				}
			}
			else
			{
				if (caller == "start")
				{
					button1.Visible = false;
					button2.Visible = false;
					button3.Visible = false;
					button4.Visible = false;
					link_Label.Text = "";
					label3.Text = "There are no new messages in your inbox";
					label4.Text = "";
					label5.Text = "";
				}
			}
		}
		
        private void Label2Click(object sender, EventArgs e)
		{
            try
            {
                System.Diagnostics.Process.Start(link);
            }
            catch { }
		}

        private void mouseOverOn(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            mouseOver = true;
            timer3.Stop();
        }

        private void mouseOverOnPU(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(imageList1.Images[0]);
            IntPtr ptr = b.GetHicon();
            Cursor c = new Cursor(ptr);
            Cursor = c;
            mouseOver = true;
            timer3.Stop();
        }

        private void mouseOverOff(object sender, EventArgs e)
        {
            mouseOver = false;
            timer3.Start();
        }

        private void Timer1Tick(object sender, EventArgs e)
        {
            if (Top > (Screen.PrimaryScreen.WorkingArea.Height - Height))
            {
                Top -=  Convert.ToInt32(2 * Math.Round((Convert.ToDouble(Height) / 200), 2));
            }
            if (Opacity < 1)
            {
                Opacity += 0.01;
            }
            if (Opacity >= 1 && Top <= (Screen.PrimaryScreen.WorkingArea.Height - Height))
            {
                timer1.Stop();
                timer3.Start();
            }
        }

        private void Timer2Tick(object sender, EventArgs e)
		{
			if (Opacity > 0)
			{
  				Opacity += -0.1;
			}
			else
			{
				Dispose();
			}
		}

        private void Label1Click(object sender, EventArgs e)
		{
				timer2.Start();
		}

        private void Timer3Tick(object sender, EventArgs e)
		{
			if (mouseOver == false)
			{
				if (msgNumber > 0)
				{
					displayMessage(msgNumber - 1, "clock");
				}	
				else
				{
					timer2.Start();
				}
			}
			else
			{
				timer3.Stop();
			}
		}

        private void button1Click(object sender, EventArgs e)
		{
			displayMessage(title.Length - 1, "button");
		}

        private void button1MD(object sender, MouseEventArgs e)
		{
            button1.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsBakAllMD;
		}

        private void button1MO(object sender, EventArgs e)
		{
            Cursor = Cursors.Hand;
            mouseOver = true;
            timer3.Stop();
            button1.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsBakAllMO;
		}

        private void button1MOO(object sender, EventArgs e)
		{
			mouseOverOff(sender, e);
            button1.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsBakAll;
		}

        private void button1MU(object sender, MouseEventArgs e)
		{
            button1.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsBakAllMO;
		}

        private void button2Click(object sender, EventArgs e)
		{
			displayMessage(msgNumber + 1, "button");
		}

        private void button2MD(object sender, MouseEventArgs e)
		{
            button2.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsBakMD;
		}

        private void button2MO(object sender, EventArgs e)
		{
            Cursor = Cursors.Hand;
            mouseOver = true;
            timer3.Stop();
            button2.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsBakMO;
		}

        private void button2MOO(object sender, EventArgs e)
		{
            mouseOverOff(sender, e);
            button2.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsBak;
		}

        private void button2MU(object sender, MouseEventArgs e)
		{
            button2.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsBakMO;
		}

        private void button3Click(object sender, EventArgs e)
		{
			displayMessage(0, "button");
		}

        private void button3MD(object sender, MouseEventArgs e)
		{
            button3.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsFwdAllMD;
		}

        private void button3MO(object sender, EventArgs e)
		{
            Cursor = Cursors.Hand;
            mouseOver = true;
            timer3.Stop();
            button3.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsFwdAllMO;
		}

        private void button3MOO(object sender, EventArgs e)
		{
			mouseOverOff(sender, e);
            button3.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsFwdAll;
		}

        private void button3MU(object sender, MouseEventArgs e)
		{
            button3.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsFwdAllMO;
		}

        private void button4Click(object sender, EventArgs e)
		{
			displayMessage(msgNumber - 1, "button");
		}

        private void button4MD(object sender, MouseEventArgs e)
		{
            button4.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsFwdMD;
		}

        private void button4MO(object sender, EventArgs e)
		{
            Cursor = Cursors.Hand;
            mouseOver = true;
            timer3.Stop();
            button4.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsFwdMO;
		}

        private void button4MOO(object sender, EventArgs e)
		{
			mouseOverOff(sender, e);
            button4.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsFwd;
		}

        private void button4MU(object sender, MouseEventArgs e)
		{
            button4.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsFwdMO;
		}
        
        private void popupBoxMouseDown(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            Bitmap b = new Bitmap(imageList1.Images[1]);
            IntPtr ptr = b.GetHicon();
            Cursor c = new Cursor(ptr);
            Cursor = c;

            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void popupBoxMouseMove(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void popupBoxMouseUp(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button == MouseButtons.Left)
            {
                Bitmap b = new Bitmap(imageList1.Images[0]);
                IntPtr ptr = b.GetHicon();
                Cursor c = new Cursor(ptr);
                Cursor = c;
                isMouseDown = false;
            }
        }
        
        private Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }

    }
}
