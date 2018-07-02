using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmUmAoCinquenta : Form
    {
        public frmUmAoCinquenta()
        {
            InitializeComponent();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txbNum.Text);
            int i = 0;
            
            while (i < num)
            {
                i++;
                lblCont.Text += i + " ";
            }
        }
    }
}
