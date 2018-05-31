using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoMediaAluno
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }
        double media, _1Bim, _2Bim, _3Bim, _4Bim;
        string nome;
        private void txbNome_TextChanged(object sender, EventArgs e)
        {
            nome = txbNome.Text;
        }

        private void txb1Bim_TextChanged(object sender, EventArgs e)
        {
            _1Bim = double.Parse(txb1Bim.Text);
        }

        private void txb2Bim_TextChanged(object sender, EventArgs e)
        {
            _2Bim = double.Parse(txb2Bim.Text);
        }

        private void txb3Bim_TextChanged(object sender, EventArgs e)
        {
            _3Bim = double.Parse(txb3Bim.Text);
        }

        private void txb4Bim_TextChanged(object sender, EventArgs e)
        {
            _4Bim = double.Parse(txb4Bim.Text);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            media = (_1Bim + _2Bim + _3Bim + _4Bim) / 4;
            lblNome.Text = nome;
            lblMedia.Text = media + "";
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblMedia_Click(object sender, EventArgs e)
        {

        }

      
       
    }
}
