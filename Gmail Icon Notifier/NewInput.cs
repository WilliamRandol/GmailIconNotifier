using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Gmail_Icon_Notifier
{
    public partial class NewAccountInput : Form
    {
        public NewAccountInput()
        {
            InitializeComponent();
        }
        
        private void AcceptClose(object Sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Controller.settings.setNewAccount(textBox1.Text);
                Close();
            }
            else
            {
                Close();
            }
        }

        private void CancelClose(object sender, EventArgs e)
        {
            Close();
        }
    }
}
