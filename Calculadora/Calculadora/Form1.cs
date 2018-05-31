using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        
        double valor1 = 0, valor2 = 0, total = 0;

        private void txbValor1_TextChanged(object sender, EventArgs e)
        {
            valor1 = double.Parse(txbValor1.Text);
        }

        private void txbValor2_TextChanged(object sender, EventArgs e)
        {
            valor2 = double.Parse(txbValor2.Text);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            total = valor1 - valor2;
            lblResultado.Text = total + "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            total = valor1 / valor2;
            lblResultado.Text = total + "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            total = valor1 * valor2;
            lblResultado.Text = total + "";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            total = valor1 + valor2;
            lblResultado.Text = total + "";
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
           
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

    }
}
