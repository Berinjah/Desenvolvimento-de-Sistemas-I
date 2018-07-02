namespace WindowsFormsApplication1
{
    partial class frmTriangulos
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
            this.lbl1Lado = new System.Windows.Forms.Label();
            this.lbl2Lado = new System.Windows.Forms.Label();
            this.lbl3Lado = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(75, 11);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(235, 34);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Digite o valor dos lados do triangulo\r\n para identificar o seu tipo ";
            // 
            // lbl1Lado
            // 
            this.lbl1Lado.AutoSize = true;
            this.lbl1Lado.Location = new System.Drawing.Point(157, 71);
            this.lbl1Lado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1Lado.Name = "lbl1Lado";
            this.lbl1Lado.Size = new System.Drawing.Size(52, 17);
            this.lbl1Lado.TabIndex = 1;
            this.lbl1Lado.Text = "1º lado";
            // 
            // lbl2Lado
            // 
            this.lbl2Lado.AutoSize = true;
            this.lbl2Lado.Location = new System.Drawing.Point(157, 117);
            this.lbl2Lado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2Lado.Name = "lbl2Lado";
            this.lbl2Lado.Size = new System.Drawing.Size(52, 17);
            this.lbl2Lado.TabIndex = 2;
            this.lbl2Lado.Text = "2º lado";
            // 
            // lbl3Lado
            // 
            this.lbl3Lado.AutoSize = true;
            this.lbl3Lado.Location = new System.Drawing.Point(157, 164);
            this.lbl3Lado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3Lado.Name = "lbl3Lado";
            this.lbl3Lado.Size = new System.Drawing.Size(52, 17);
            this.lbl3Lado.TabIndex = 3;
            this.lbl3Lado.Text = "3º lado";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(136, 260);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(139, 254);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(120, 185);
            this.txb3.Margin = new System.Windows.Forms.Padding(4);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(132, 22);
            this.txb3.TabIndex = 6;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(120, 138);
            this.txb2.Margin = new System.Windows.Forms.Padding(4);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(132, 22);
            this.txb2.TabIndex = 7;
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(120, 91);
            this.txb1.Margin = new System.Windows.Forms.Padding(4);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(132, 22);
            this.txb1.TabIndex = 8;
            // 
            // frmTriangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 290);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lbl3Lado);
            this.Controls.Add(this.lbl2Lado);
            this.Controls.Add(this.lbl1Lado);
            this.Controls.Add(this.lblDescricao);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTriangulos";
            this.Text = "Triangulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lbl1Lado;
        private System.Windows.Forms.Label lbl2Lado;
        private System.Windows.Forms.Label lbl3Lado;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb1;
    }
}