namespace WindowsFormsApplication1
{
    partial class frmUmAoCinquenta
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.lblCont = new System.Windows.Forms.Label();
            this.btnCont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(0, 0);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(685, 17);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Digite um número abaixo para definir o limite de número a serem imprimidos (por p" +
    "adrão ele irá do 1 ao 50)";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(253, 63);
            this.txbNum.Margin = new System.Windows.Forms.Padding(4);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(132, 22);
            this.txbNum.TabIndex = 1;
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Location = new System.Drawing.Point(263, 102);
            this.lblCont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(0, 17);
            this.lblCont.TabIndex = 2;
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(267, 138);
            this.btnCont.Margin = new System.Windows.Forms.Padding(4);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(100, 28);
            this.btnCont.TabIndex = 3;
            this.btnCont.Text = "Contar!";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // frmUmAoCinquenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 182);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.lblDesc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUmAoCinquenta";
            this.Text = "Um ao Cinquenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Button btnCont;
    }
}