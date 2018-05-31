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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste1 form = new frmTeste1();
            form.MdiParent = this; //definindo que o objeto é "filho" do formulário principal
            form.Show();
        }

        private void teste2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste2 form = new frmTeste2();
            form.MdiParent = this; //definindo que o objeto é "filho" do formulário principal
            form.Show();
        }

        private void toolStripBtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
