namespace CalculoMediaAluno
{
    partial class frmMedia
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
            this.lblAluno = new System.Windows.Forms.Label();
            this.lbl1Bim = new System.Windows.Forms.Label();
            this.lbl2Bim = new System.Windows.Forms.Label();
            this.lbl3Bim = new System.Windows.Forms.Label();
            this.lbl4Bim = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txb1Bim = new System.Windows.Forms.TextBox();
            this.txb3Bim = new System.Windows.Forms.TextBox();
            this.txb2Bim = new System.Windows.Forms.TextBox();
            this.txb4Bim = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(35, 20);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(79, 13);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Nome do aluno";
            // 
            // lbl1Bim
            // 
            this.lbl1Bim.AutoSize = true;
            this.lbl1Bim.Location = new System.Drawing.Point(10, 70);
            this.lbl1Bim.Name = "lbl1Bim";
            this.lbl1Bim.Size = new System.Drawing.Size(37, 13);
            this.lbl1Bim.TabIndex = 1;
            this.lbl1Bim.Text = "1º Bim";
            // 
            // lbl2Bim
            // 
            this.lbl2Bim.AutoSize = true;
            this.lbl2Bim.Location = new System.Drawing.Point(160, 70);
            this.lbl2Bim.Name = "lbl2Bim";
            this.lbl2Bim.Size = new System.Drawing.Size(37, 13);
            this.lbl2Bim.TabIndex = 2;
            this.lbl2Bim.Text = "2º Bim";
            // 
            // lbl3Bim
            // 
            this.lbl3Bim.AutoSize = true;
            this.lbl3Bim.Location = new System.Drawing.Point(10, 135);
            this.lbl3Bim.Name = "lbl3Bim";
            this.lbl3Bim.Size = new System.Drawing.Size(37, 13);
            this.lbl3Bim.TabIndex = 3;
            this.lbl3Bim.Text = "3º Bim";
            // 
            // lbl4Bim
            // 
            this.lbl4Bim.AutoSize = true;
            this.lbl4Bim.Location = new System.Drawing.Point(160, 135);
            this.lbl4Bim.Name = "lbl4Bim";
            this.lbl4Bim.Size = new System.Drawing.Size(37, 13);
            this.lbl4Bim.TabIndex = 4;
            this.lbl4Bim.Text = "4º Bim";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(145, 210);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(145, 240);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(0, 13);
            this.lblMedia.TabIndex = 6;
            this.lblMedia.Click += new System.EventHandler(this.lblMedia_Click);
            // 
            // txb1Bim
            // 
            this.txb1Bim.Location = new System.Drawing.Point(50, 65);
            this.txb1Bim.Name = "txb1Bim";
            this.txb1Bim.Size = new System.Drawing.Size(100, 20);
            this.txb1Bim.TabIndex = 7;
            this.txb1Bim.TextChanged += new System.EventHandler(this.txb1Bim_TextChanged);
            // 
            // txb3Bim
            // 
            this.txb3Bim.Location = new System.Drawing.Point(50, 130);
            this.txb3Bim.Name = "txb3Bim";
            this.txb3Bim.Size = new System.Drawing.Size(100, 20);
            this.txb3Bim.TabIndex = 8;
            this.txb3Bim.TextChanged += new System.EventHandler(this.txb3Bim_TextChanged);
            // 
            // txb2Bim
            // 
            this.txb2Bim.Location = new System.Drawing.Point(200, 65);
            this.txb2Bim.Name = "txb2Bim";
            this.txb2Bim.Size = new System.Drawing.Size(100, 20);
            this.txb2Bim.TabIndex = 9;
            this.txb2Bim.TextChanged += new System.EventHandler(this.txb2Bim_TextChanged);
            // 
            // txb4Bim
            // 
            this.txb4Bim.Location = new System.Drawing.Point(200, 130);
            this.txb4Bim.Name = "txb4Bim";
            this.txb4Bim.Size = new System.Drawing.Size(100, 20);
            this.txb4Bim.TabIndex = 10;
            this.txb4Bim.TextChanged += new System.EventHandler(this.txb4Bim_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(125, 170);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(120, 15);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 12;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 282);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txb4Bim);
            this.Controls.Add(this.txb2Bim);
            this.Controls.Add(this.txb3Bim);
            this.Controls.Add(this.txb1Bim);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lbl4Bim);
            this.Controls.Add(this.lbl3Bim);
            this.Controls.Add(this.lbl2Bim);
            this.Controls.Add(this.lbl1Bim);
            this.Controls.Add(this.lblAluno);
            this.Name = "frmMedia";
            this.Text = "Cálculo da Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lbl1Bim;
        private System.Windows.Forms.Label lbl2Bim;
        private System.Windows.Forms.Label lbl3Bim;
        private System.Windows.Forms.Label lbl4Bim;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TextBox txb1Bim;
        private System.Windows.Forms.TextBox txb3Bim;
        private System.Windows.Forms.TextBox txb2Bim;
        private System.Windows.Forms.TextBox txb4Bim;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbNome;
    }
}

