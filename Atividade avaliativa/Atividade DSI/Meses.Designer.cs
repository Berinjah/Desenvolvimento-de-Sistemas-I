namespace WindowsFormsApplication1
{
    partial class frmMeses
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnVerfic = new System.Windows.Forms.Button();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(1, 11);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(322, 34);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Digite um número entre 1 e 12 abaixo para saber \r\nqual o mês do ano referente ao " +
    "mesmo";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(82, 118);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 1;
            // 
            // btnVerfic
            // 
            this.btnVerfic.Location = new System.Drawing.Point(102, 153);
            this.btnVerfic.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerfic.Name = "btnVerfic";
            this.btnVerfic.Size = new System.Drawing.Size(100, 28);
            this.btnVerfic.TabIndex = 2;
            this.btnVerfic.Text = "Verificar";
            this.btnVerfic.UseVisualStyleBackColor = true;
            this.btnVerfic.Click += new System.EventHandler(this.btnVerfic_Click);
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(85, 77);
            this.txbNum.Margin = new System.Windows.Forms.Padding(4);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(132, 22);
            this.txbNum.TabIndex = 3;
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 194);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.btnVerfic);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDesc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMeses";
            this.Text = "Meses do ano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnVerfic;
        private System.Windows.Forms.TextBox txbNum;
    }
}