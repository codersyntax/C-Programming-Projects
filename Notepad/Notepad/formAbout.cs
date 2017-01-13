using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class formAbout : Form
    {
        public formAbout()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formAbout_Load(object sender, EventArgs e)
        {
                lblProductName.Text = String.Format("Product Name: Notepad");
                lblProductVersion.Text = String.Format("Version: 1.0");
                lblCopyright.Text = String.Format("Copyright: Copyright © Coder Syntax 2017");
        }
    }
}
