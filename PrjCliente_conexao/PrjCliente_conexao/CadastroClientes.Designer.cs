namespace PrjCliente_conexao
{
    partial class frmCadastroClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNumMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNasc = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.txbCep = new System.Windows.Forms.MaskedTextBox();
            this.colunaMatrícula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(18, 22);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(58, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula::";
            // 
            // lblNumMatricula
            // 
            this.lblNumMatricula.AutoSize = true;
            this.lblNumMatricula.Location = new System.Drawing.Point(109, 22);
            this.lblNumMatricula.Name = "lblNumMatricula";
            this.lblNumMatricula.Size = new System.Drawing.Size(0, 13);
            this.lblNumMatricula.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome::";
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Location = new System.Drawing.Point(18, 87);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(69, 13);
            this.lblNasc.TabIndex = 3;
            this.lblNasc.Text = "Nascimento::";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(18, 122);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(59, 13);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço::";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(18, 161);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(50, 13);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "Número::";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(212, 161);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 13);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP::";
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(18, 385);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(106, 13);
            this.lblPesquisar.TabIndex = 7;
            this.lblPesquisar.Text = "Pesquisar por nome::";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(336, 17);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(336, 46);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(336, 75);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(336, 104);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(21, 197);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeiro.TabIndex = 12;
            this.btnPrimeiro.Text = "Primeiro";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(264, 197);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 23);
            this.btnUltimo.TabIndex = 13;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(183, 197);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(75, 23);
            this.btnProx.TabIndex = 14;
            this.btnProx.Text = "Próximo";
            this.btnProx.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(102, 197);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 15;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(102, 51);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(179, 20);
            this.txbNome.TabIndex = 16;
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(102, 154);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(75, 20);
            this.txbNum.TabIndex = 19;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(102, 115);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(213, 20);
            this.txbEndereco.TabIndex = 20;
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(160, 382);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(179, 20);
            this.txt_pesquisar.TabIndex = 21;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaMatrícula,
            this.colunaNome,
            this.colunaNasc,
            this.colunaEndereco,
            this.colunaNumero,
            this.colunaCEP});
            this.dgv_clientes.Location = new System.Drawing.Point(21, 226);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(643, 150);
            this.dgv_clientes.TabIndex = 22;
            // 
            // dtpNasc
            // 
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNasc.Location = new System.Drawing.Point(102, 81);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(96, 20);
            this.dtpNasc.TabIndex = 23;
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(264, 154);
            this.txbCep.Mask = "00000-000";
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(59, 20);
            this.txbCep.TabIndex = 24;
            // 
            // colunaMatrícula
            // 
            this.colunaMatrícula.HeaderText = "Matrícula";
            this.colunaMatrícula.Name = "colunaMatrícula";
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.Name = "colunaNome";
            // 
            // colunaNasc
            // 
            dataGridViewCellStyle1.Format = "dd/mm/aaaa";
            this.colunaNasc.DefaultCellStyle = dataGridViewCellStyle1;
            this.colunaNasc.HeaderText = "Nascimento";
            this.colunaNasc.Name = "colunaNasc";
            // 
            // colunaEndereco
            // 
            this.colunaEndereco.HeaderText = "Endereço";
            this.colunaEndereco.Name = "colunaEndereco";
            // 
            // colunaNumero
            // 
            this.colunaNumero.HeaderText = "Número";
            this.colunaNumero.Name = "colunaNumero";
            // 
            // colunaCEP
            // 
            dataGridViewCellStyle2.Format = "00000-000";
            this.colunaCEP.DefaultCellStyle = dataGridViewCellStyle2;
            this.colunaCEP.HeaderText = "CEP";
            this.colunaCEP.Name = "colunaCEP";
            // 
            // frmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 410);
            this.Controls.Add(this.txbCep);
            this.Controls.Add(this.dtpNasc);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNumMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmCadastroClientes";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadastroClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNumMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.MaskedTextBox txbCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaMatrícula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCEP;
    }
}

