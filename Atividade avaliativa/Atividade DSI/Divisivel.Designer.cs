namespace WindowsFormsApplication1
{
    partial class frmDivisivel
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txbDividendo = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblDividendo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(304, 34);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Saiba se um número é divisível por 2, 5, 10 ou \r\npor nenhum desses.";
            // 
            // txbDividendo
            // 
            this.txbDividendo.Location = new System.Drawing.Point(82, 68);
            this.txbDividendo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDividendo.Name = "txbDividendo";
            this.txbDividendo.Size = new System.Drawing.Size(132, 22);
            this.txbDividendo.TabIndex = 1;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(95, 181);
            this.btnVerifica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(100, 28);
            this.btnVerifica.TabIndex = 4;
            this.btnVerifica.Text = "Verificar";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(111, 47);
            this.lblDividendo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(71, 17);
            this.lblDividendo.TabIndex = 5;
            this.lblDividendo.Text = "Dividendo";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(92, 106);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 7;
            // 
            // frmDivisivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 222);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDividendo);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txbDividendo);
            this.Controls.Add(this.lblDescricao);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDivisivel";
            this.Text = "Divisivel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txbDividendo;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.Label lblResult;
    }
}