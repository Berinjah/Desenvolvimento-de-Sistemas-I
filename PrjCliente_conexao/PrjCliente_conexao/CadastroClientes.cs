using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PrjCliente_conexao
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
        }

            
        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //Declare o DataReader - table virtual somente leitura
        OleDbDataReader dr_clientes;
        //Declare o BindingSource - tabela virtual editável
        BindingSource bs_clientes = new BindingSource();
        //cria a variável que receberá a query (comando sql)
        String _query;

        private void carregar_grid()
        {
            //Determine a query desejada 
            _query = "Select * from cliente";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_clientes = _dataCommand.ExecuteReader();

            //teste para verificar se retornaram linhas
            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
                dgv_clientes.DataSource = bs_clientes;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos clientes cadastrados!!!!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void igualar_text()
        {
            lblNumMatricula.DataBindings.Add("Text", bs_clientes, "Matrícula");
            lblNumMatricula.DataBindings.Clear();
            txbNome.DataBindings.Add("Text", bs_clientes, "Nome");
            txbNome.DataBindings.Clear();
            dtpNasc.DataBindings.Add("Text", bs_clientes, "Nascimento");
            dtpNasc.DataBindings.Clear();
            txbEndereco.DataBindings.Add("Text", bs_clientes, "Endereço");
            txbEndereco.DataBindings.Clear();
            txbNum.DataBindings.Add("Text", bs_clientes, "Número");
            txbNum.DataBindings.Clear();
            txbCep.DataBindings.Add("Text", bs_clientes, "CEP");
        }
        private void frmCadastroClientes_Load(object sender, EventArgs e)
        { 
            //alimenta o datagridview com dados
            carregar_grid();
        }
        private void dgv_clientes_Click(object sender, EventArgs e)
        {
            igualar_text();
        }
        private void dgv_clientes_KeyUp(object sender, EventArgs e)
        {
            igualar_text();
        }
        private void txt_Pesquisar_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Clientes where nome like '" + txt_pesquisar.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_clientes = _dataCommand.ExecuteReader();

            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
            }
            else
            {
                MessageBox.Show("Não temos cliente cadastrado com este nome !!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_pesquisar.Text = "";
            }
        }
    }
}
