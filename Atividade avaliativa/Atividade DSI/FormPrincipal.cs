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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButtonAdicao_Click(object sender, EventArgs e)
        {
            frmAdicao form = new frmAdicao();
            form.MdiParent = this; //definindo que o objeto é "filho" do formulário principal
            form.Show();
        }

        private void toolStripButtonDivisivel_Click(object sender, EventArgs e)
        {
            frmDivisivel form = new frmDivisivel();
            form.MdiParent = this; //definindo que o objeto é "filho" do formulário principal
            form.Show();
        }

        private void toolStripButtonTriangulo_Click(object sender, EventArgs e)
        {
            frmTriangulos form = new frmTriangulos();
            form.MdiParent = this; //definindo que o objeto é "filho" do formulário principal
            form.Show();
        }

        private void toolStripButtonMeses_Click(object sender, EventArgs e)
        {
            frmMeses form = new frmMeses();
            form.MdiParent = this; //definindo que o objeto é "filho" do formulário principal
            form.Show();
        }

        private void toolStripButtonUmAoCinquenta_Click(object sender, EventArgs e)
        {
            frmUmAoCinquenta form = new frmUmAoCinquenta();
            form.MdiParent = this; //definindo que o objeto é "filho" do formulário principal
            form.Show();
        }

        private void toolStripButtonBrasil_Click(object sender, EventArgs e)
        {
            frmBrasil form = new frmBrasil();
            form.MdiParent = this; //definindo que o objeto é "filho" do formulário principal
            form.Show();
        }

        private void toolStripButtonTamanhos_Click(object sender, EventArgs e)
        {
            frmTamanhos form = new frmTamanhos();
            form.MdiParent = this; //definindo que o objeto é "filho" do formulário principal
            form.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        
    }
}
