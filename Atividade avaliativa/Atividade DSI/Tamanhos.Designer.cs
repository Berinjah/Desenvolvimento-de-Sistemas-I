namespace WindowsFormsApplication1
{
    partial class frmTamanhos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTamanhos));
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnResul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(0, 0);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(394, 68);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = resources.GetString("lblDesc.Text");
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(97, 140);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 1;
            // 
            // btnResul
            // 
            this.btnResul.Location = new System.Drawing.Point(134, 88);
            this.btnResul.Margin = new System.Windows.Forms.Padding(4);
            this.btnResul.Name = "btnResul";
            this.btnResul.Size = new System.Drawing.Size(100, 28);
            this.btnResul.TabIndex = 2;
            this.btnResul.Text = "Clique aqui!";
            this.btnResul.UseVisualStyleBackColor = true;
            this.btnResul.Click += new System.EventHandler(this.btnResul_Click);
            // 
            // frmTamanhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 180);
            this.Controls.Add(this.btnResul);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDesc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTamanhos";
            this.Text = "Tamanhos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnResul;
    }
}