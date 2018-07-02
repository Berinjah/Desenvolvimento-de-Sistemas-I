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
    public partial class frmTamanhos : Form
    {
        public frmTamanhos()
        {
            InitializeComponent();
        }

        private void btnResul_Click(object sender, EventArgs e)
        {
            double a = 1.5, m = 1.1;
            int anos = 0;
            while (m < a)
            {
                anos++;
                a += 0.02;
                m += 0.03;
            }
            lblResult.Text = "Manoel será mais alto que arlindo daqui " + anos + " anos";
        }

        
    }
}
