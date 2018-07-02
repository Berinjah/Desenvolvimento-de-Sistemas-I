namespace WindowsFormsApplication1
{
    partial class frmAdicao
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
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lbl1Num = new System.Windows.Forms.Label();
            this.lbl2Num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(3, 30);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(356, 80);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Insira dois dúmeros para realizar uma adição. \r\nSe o resultado da soma for maior " +
    "que 20 será \r\nsomado mais 8, se for menor ou igual, será \r\nsubtraído 5.";
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(93, 193);
            this.txb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(132, 22);
            this.txb2.TabIndex = 1;
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(93, 146);
            this.txb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(132, 22);
            this.txb1.TabIndex = 2;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(106, 245);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(100, 28);
            this.btnSomar.TabIndex = 3;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(118, 224);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 4;
            // 
            // lbl1Num
            // 
            this.lbl1Num.AutoSize = true;
            this.lbl1Num.Location = new System.Drawing.Point(108, 125);
            this.lbl1Num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1Num.Name = "lbl1Num";
            this.lbl1Num.Size = new System.Drawing.Size(112, 17);
            this.lbl1Num.TabIndex = 5;
            this.lbl1Num.Text = "Primeiro número";
            // 
            // lbl2Num
            // 
            this.lbl2Num.AutoSize = true;
            this.lbl2Num.Location = new System.Drawing.Point(103, 172);
            this.lbl2Num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2Num.Name = "lbl2Num";
            this.lbl2Num.Size = new System.Drawing.Size(117, 17);
            this.lbl2Num.TabIndex = 6;
            this.lbl2Num.Text = "Segundo número";
            // 
            // frmAdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 287);
            this.Controls.Add(this.lbl2Num);
            this.Controls.Add(this.lbl1Num);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.lblDescricao);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdicao";
            this.Text = "Adicao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lbl1Num;
        private System.Windows.Forms.Label lbl2Num;

    }
}