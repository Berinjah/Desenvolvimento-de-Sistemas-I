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
    public partial class frmDivisivel : Form
    {
        public frmDivisivel()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            //corrigir
            lblResult.Text = "";
            double div1 = Double.Parse(txbDividendo.Text);
            double resul2, resul5, resul10;

            resul2 = div1 % 2;
            resul5 = div1 % 5;
            resul10 = div1 % 10;

            if (resul2 == 0 || resul5 == 0 || resul10 == 0)
            {
                if (resul2 == 0)
                {
                    lblResult.Text += "Esse número é divisível por 2.\n";
                }
                else
                {
                    lblResult.Text += "Esse número não é divisível por 2.\n";
                }

                if (resul5 == 0)
                {
                    lblResult.Text += "Esse número é divisível por 5.\n";
                }
                else
                {
                    lblResult.Text += "Esse número não é divisível por 5.\n";
                }
                if (resul10 == 0)
                {
                    lblResult.Text += "Esse número é divisível por 10.";
                }
                else
                {
                    lblResult.Text += "Esse número não é divisível por 10.";
                }
            }
            else
            {
                lblResult.Text = "Esse número não é divisível por 2, nem por 5 e nem por 10";
            }
        }
    }
}
