namespace WindowsFormsApplication1
{
    partial class frmBrasil
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblImpressao = new System.Windows.Forms.Label();
            this.txbEntrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(199, 131);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 28);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(3, 11);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(499, 17);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Digite a quantidade de vezes que você quer imprimir a palavra \"Brasil\" na tela";
            // 
            // lblImpressao
            // 
            this.lblImpressao.AutoSize = true;
            this.lblImpressao.Location = new System.Drawing.Point(89, 142);
            this.lblImpressao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpressao.Name = "lblImpressao";
            this.lblImpressao.Size = new System.Drawing.Size(0, 17);
            this.lblImpressao.TabIndex = 2;
            // 
            // txbEntrada
            // 
            this.txbEntrada.Location = new System.Drawing.Point(184, 53);
            this.txbEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txbEntrada.Name = "txbEntrada";
            this.txbEntrada.Size = new System.Drawing.Size(132, 22);
            this.txbEntrada.TabIndex = 3;
            // 
            // frmBrasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 169);
            this.Controls.Add(this.txbEntrada);
            this.Controls.Add(this.lblImpressao);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnImprimir);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBrasil";
            this.Text = "Brasil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblImpressao;
        private System.Windows.Forms.TextBox txbEntrada;
    }
}