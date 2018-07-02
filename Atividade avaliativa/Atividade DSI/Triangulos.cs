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
    public partial class frmTriangulos : Form
    {
        public frmTriangulos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            if (txb1.Text == txb2.Text && txb2.Text == txb3.Text)
            {
                lblResult.Text = "Este é um triangulo equilátero";
            }
            else if (txb1.Text == txb2.Text || txb2.Text == txb3.Text || txb1.Text == txb3.Text)
            {
                lblResult.Text = "Este é um triangulo isóceles";
            }
            else
            {
                lblResult.Text = "Este é um triangulo escaleno";
            }
        }
    }
}
