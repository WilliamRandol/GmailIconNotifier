using System.Runtime.InteropServices;
using System;
using Gmail_Icon_Notifier;

namespace Gmail_Icon_Notifier
{
    /// <summary>Enumeration of the different ways of showing a window using
    /// ShowWindow</summary>
    enum WindowShowStyle : uint
        {
            /// <summary>Hides the window and activates another window.</summary>
            /// <remarks>See SW_HIDE</remarks>
            Hide = 0,
            /// <summary>Activates and displays a window. If the window is minimized
            /// or maximized, the system restores it to its original size and
            /// position. An application should specify this flag when displaying
            /// the window for the first time.</summary>
            /// <remarks>See SW_SHOWNORMAL</remarks>
            ShowNormal = 1,
            /// <summary>Activates the window and displays it as a minimized window.</summary>
            /// <remarks>See SW_SHOWMINIMIZED</remarks>
            ShowMinimized = 2,
            /// <summary>Activates the window and displays it as a maximized window.</summary>
            /// <remarks>See SW_SHOWMAXIMIZED</remarks>
            ShowMaximized = 3,
            /// <summary>Maximizes the specified window.</summary>
            /// <remarks>See SW_MAXIMIZE</remarks>
            Maximize = 3,
            /// <summary>Displays a window in its most recent size and position.
            /// This value is similar to "ShowNormal", except the window is not
            /// actived.</summary>
            /// <remarks>See SW_SHOWNOACTIVATE</remarks>
            ShowNormalNoActivate = 4,
            /// <summary>Activates the window and displays it in its current size
            /// and position.</summary>
            /// <remarks>See SW_SHOW</remarks>
            Show = 5,
            /// <summary>Minimizes the specified window and activates the next
            /// top-level window in the Z order.</summary>
            /// <remarks>See SW_MINIMIZE</remarks>
            Minimize = 6,
            /// <summary>Displays the window as a minimized window. This value is
            /// similar to "ShowMinimized", except the window is not activated.</summary>
            /// <remarks>See SW_SHOWMINNOACTIVE</remarks>
            ShowMinNoActivate = 7,
            /// <summary>Displays the window in its current size and position. This
            /// value is similar to "Show", except the window is not activated.</summary>
            /// <remarks>See SW_SHOWNA</remarks>
            ShowNoActivate = 8,
            /// <summary>Activates and displays the window. If the window is
            /// minimized or maximized, the system restores it to its original size
            /// and position. An application should specify this flag when restoring
            /// a minimized window.</summary>
            /// <remarks>See SW_RESTORE</remarks>
            Restore = 9,
            /// <summary>Sets the show state based on the SW_ value specified in the
            /// STARTUPINFO structure passed to the CreateProcess function by the
            /// program that started the application.</summary>
            /// <remarks>See SW_SHOWDEFAULT</remarks>
            ShowDefault = 10,
            /// <summary>Windows 2000/XP: Minimizes a window, even if the thread
            /// that owns the window is hung. This flag should only be used when
            /// minimizing windows from a different thread.</summary>
            /// <remarks>See SW_FORCEMINIMIZE</remarks>
            ForceMinimized = 11
        }

	partial class PopupBox
	{

        /// <summary>Shows a Window</summary>
        /// <remarks>
        /// <para>To perform certain special effects when showing or hiding a
        /// window, use AnimateWindow.</para>
        ///<para>The first time an application calls ShowWindow, it should use
        ///the WinMain function's nCmdShow parameter as its nCmdShow parameter.
        ///Subsequent calls to ShowWindow must use one of the values in the
        ///given list, instead of the one specified by the WinMain function's
        ///nCmdShow parameter.</para>
        ///<para>As noted in the discussion of the nCmdShow parameter, the
        ///nCmdShow value is ignored in the first call to ShowWindow if the
        ///program that launched the application specifies startup information
        ///in the structure. In this case, ShowWindow uses the information
        ///specified in the STARTUPINFO structure to show the window. On
        ///subsequent calls, the application must call ShowWindow with nCmdShow
        ///set to SW_SHOWDEFAULT to use the startup information provided by the
        ///program that launched the application. This behavior is designed for
        ///the following situations: </para>
        ///<list type="">
        ///    <item>Applications create their main window by calling CreateWindow
        ///    with the WS_VISIBLE flag set. </item>
        ///    <item>Applications create their main window by calling CreateWindow
        ///    with the WS_VISIBLE flag cleared, and later call ShowWindow with the
        ///    SW_SHOW flag set to make it visible.</item>
        ///</list></remarks>
        /// <param name="hWnd">Handle to the window.</param>
        /// <param name="nCmdShow">Specifies how the window is to be shown.
        /// This parameter is ignored the first time an application calls
        /// ShowWindow, if the program that launched the application provides a
        /// STARTUPINFO structure. Otherwise, the first time ShowWindow is called,
        /// the value should be the value obtained by the WinMain function in its
        /// nCmdShow parameter. In subsequent calls, this parameter can be one of
        /// the WindowShowStyle members.</param>
        /// <returns>
        /// If the window was previously visible, the return value is nonzero.
        /// If the window was previously hidden, the return value is zero.
        /// </returns>
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);

		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
        
        private System.ComponentModel.IContainer components = null;	
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override bool ShowWithoutActivation
        {
            get
            {
                return true;
            }
        }
        protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupBox));
            this.link_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // link_Label
            // 
            this.link_Label.AutoEllipsis = true;
            this.link_Label.BackColor = System.Drawing.Color.Transparent;
            this.link_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_Label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Label.ForeColor = System.Drawing.Color.DarkGreen;
            this.link_Label.Location = new System.Drawing.Point(25, 89);
            this.link_Label.Name = "link_Label";
            this.link_Label.Size = new System.Drawing.Size(176, 31);
            this.link_Label.TabIndex = 1;
            this.link_Label.Text = "label2";
            this.link_Label.MouseLeave += new System.EventHandler(this.mouseOverOff);
            this.link_Label.Click += new System.EventHandler(this.Label2Click);
            this.link_Label.MouseHover += new System.EventHandler(this.mouseOverOn);
            this.link_Label.MouseEnter += new System.EventHandler(this.mouseOverOn);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 68);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.MouseLeave += new System.EventHandler(this.mouseOverOff);
            this.label3.MouseHover += new System.EventHandler(this.mouseOverOn);
            this.label3.MouseEnter += new System.EventHandler(this.mouseOverOn);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            this.label4.MouseLeave += new System.EventHandler(this.mouseOverOff);
            this.label4.MouseHover += new System.EventHandler(this.mouseOverOn);
            this.label4.MouseEnter += new System.EventHandler(this.mouseOverOn);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Close";
            this.label1.Click += new System.EventHandler(this.Label1Click);
            this.label1.MouseHover += new System.EventHandler(this.mouseOverOff);
            this.label1.MouseEnter += new System.EventHandler(this.mouseOverOff);
            // 
            // timer3
            // 
            this.timer3.Interval = 7000;
            this.timer3.Tick += new System.EventHandler(this.Timer3Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsBakAll;
            this.button1.Location = new System.Drawing.Point(13, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 25);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1MOO);
            this.button1.Click += new System.EventHandler(this.button1Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1MD);
            this.button1.MouseHover += new System.EventHandler(this.button1MO);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1MU);
            this.button1.MouseEnter += new System.EventHandler(this.button1MO);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsBak;
            this.button2.Location = new System.Drawing.Point(42, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 25);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseLeave += new System.EventHandler(this.button2MOO);
            this.button2.Click += new System.EventHandler(this.button2Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2MD);
            this.button2.MouseHover += new System.EventHandler(this.button2MO);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2MU);
            this.button2.MouseEnter += new System.EventHandler(this.button2MO);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsFwdAll;
            this.button3.Location = new System.Drawing.Point(170, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 25);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseLeave += new System.EventHandler(this.button3MOO);
            this.button3.Click += new System.EventHandler(this.button3Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3MD);
            this.button3.MouseHover += new System.EventHandler(this.button3MO);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3MU);
            this.button3.MouseEnter += new System.EventHandler(this.button3MO);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = global::Gmail_Icon_Notifier.Properties.Resources.buttonsFwd;
            this.button4.Location = new System.Drawing.Point(140, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 25);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseLeave += new System.EventHandler(this.button4MOO);
            this.button4.Click += new System.EventHandler(this.button4Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4MD);
            this.button4.MouseHover += new System.EventHandler(this.button4MO);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4MU);
            this.button4.MouseEnter += new System.EventHandler(this.button4MO);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseLeave += new System.EventHandler(this.mouseOverOff);
            this.label5.MouseHover += new System.EventHandler(this.mouseOverOn);
            this.label5.MouseEnter += new System.EventHandler(this.mouseOverOn);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "grab-1.bmp");
            this.imageList1.Images.SetKeyName(1, "grabbing.bmp");
            // 
            // PopupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Magenta;
            this.BackgroundImage = global::Gmail_Icon_Notifier.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.link_Label);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(200, 200);
            this.MinimizeBox = false;
            this.Name = "PopupBox";
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NewMessage";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.popupBoxMouseUp);
            this.MouseEnter += new System.EventHandler(this.mouseOverOnPU);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.popupBoxMouseDown);
            this.MouseLeave += new System.EventHandler(this.mouseOverOff);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.popupBoxMouseMove);
            this.MouseHover += new System.EventHandler(this.mouseOverOnPU);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label link_Label;
        private System.Windows.Forms.ImageList imageList1;
	}
}
