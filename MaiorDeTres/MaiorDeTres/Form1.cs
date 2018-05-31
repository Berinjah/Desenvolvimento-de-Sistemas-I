using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaiorDeTres
{
    public partial class frmMaiorValorDeTres : Form
    {
        public frmMaiorValorDeTres()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double valorA = double.Parse(txbValorA.Text);
            double valorB = double.Parse(txbValorB.Text);
            double valorC = double.Parse(txbValorC.Text);

            if (valorA > valorB && valorA > valorC)
            {
                lblResposta.Text = "O maior valor é A";
            }
            else if (valorB > valorA && valorB > valorC)
            {
                lblResposta.Text = "O maior valor é B";
            }
            else if(valorC > valorA && valorC > valorB)
            {
                lblResposta.Text = "O maior valor é C";
            }
        }

        
    }
}
