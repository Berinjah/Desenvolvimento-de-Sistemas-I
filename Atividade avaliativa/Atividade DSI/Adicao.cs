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
    public partial class frmAdicao : Form
    {
        public frmAdicao()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            double val1 = Double.Parse(txb1.Text);
            double val2 = Double.Parse(txb2.Text);
            double resul = val1 + val2;


            if (resul > 20)
            {
                resul = resul + 8;
                lblResult.Text = resul.ToString();
            }
            else 
            {
                resul = resul - 5;
                lblResult.Text = resul.ToString(); 
            }
        }

        
    }
}
