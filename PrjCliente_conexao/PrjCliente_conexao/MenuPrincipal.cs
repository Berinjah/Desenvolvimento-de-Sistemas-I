using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjCliente_conexao
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tsbCadastros_Click(object sender, EventArgs e)
        {
            frmCadastroClientes form = new frmCadastroClientes();
            form.MdiParent = this; //definindo que o objeto é "filho" do formulário principal
            form.Show();
        }
    }
}
