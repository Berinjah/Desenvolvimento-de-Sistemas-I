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
    public partial class frmBrasil : Form
    {
        public frmBrasil()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int resul = int.Parse(txbEntrada.Text);
            int i = 0;
            while (i < resul) 
            {
                i++;
                lblImpressao.Text += "Brasil!. ";
            } 
        }
    }
}
