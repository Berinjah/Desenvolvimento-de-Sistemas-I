namespace WindowsFormsApplication1
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdicao = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDivisivel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTriangulo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMeses = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUmAoCinquenta = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBrasil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTamanhos = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdicao,
            this.toolStripButtonDivisivel,
            this.toolStripButtonTriangulo,
            this.toolStripButtonMeses,
            this.toolStripButtonUmAoCinquenta,
            this.toolStripButtonBrasil,
            this.toolStripButtonTamanhos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(853, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdicao
            // 
            this.toolStripButtonAdicao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdicao.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdicao.Image")));
            this.toolStripButtonAdicao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdicao.Name = "toolStripButtonAdicao";
            this.toolStripButtonAdicao.Size = new System.Drawing.Size(48, 22);
            this.toolStripButtonAdicao.Text = "Adição";
            this.toolStripButtonAdicao.Click += new System.EventHandler(this.toolStripButtonAdicao_Click);
            // 
            // toolStripButtonDivisivel
            // 
            this.toolStripButtonDivisivel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDivisivel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDivisivel.Image")));
            this.toolStripButtonDivisivel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDivisivel.Name = "toolStripButtonDivisivel";
            this.toolStripButtonDivisivel.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonDivisivel.Text = "Divisível";
            this.toolStripButtonDivisivel.Click += new System.EventHandler(this.toolStripButtonDivisivel_Click);
            // 
            // toolStripButtonTriangulo
            // 
            this.toolStripButtonTriangulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTriangulo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTriangulo.Image")));
            this.toolStripButtonTriangulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTriangulo.Name = "toolStripButtonTriangulo";
            this.toolStripButtonTriangulo.Size = new System.Drawing.Size(62, 22);
            this.toolStripButtonTriangulo.Text = "Triangulo";
            this.toolStripButtonTriangulo.Click += new System.EventHandler(this.toolStripButtonTriangulo_Click);
            // 
            // toolStripButtonMeses
            // 
            this.toolStripButtonMeses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonMeses.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMeses.Image")));
            this.toolStripButtonMeses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMeses.Name = "toolStripButtonMeses";
            this.toolStripButtonMeses.Size = new System.Drawing.Size(84, 22);
            this.toolStripButtonMeses.Text = "Meses do ano";
            this.toolStripButtonMeses.Click += new System.EventHandler(this.toolStripButtonMeses_Click);
            // 
            // toolStripButtonUmAoCinquenta
            // 
            this.toolStripButtonUmAoCinquenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUmAoCinquenta.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUmAoCinquenta.Image")));
            this.toolStripButtonUmAoCinquenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUmAoCinquenta.Name = "toolStripButtonUmAoCinquenta";
            this.toolStripButtonUmAoCinquenta.Size = new System.Drawing.Size(48, 22);
            this.toolStripButtonUmAoCinquenta.Text = "1 ao 50";
            this.toolStripButtonUmAoCinquenta.Click += new System.EventHandler(this.toolStripButtonUmAoCinquenta_Click);
            // 
            // toolStripButtonBrasil
            // 
            this.toolStripButtonBrasil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBrasil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBrasil.Image")));
            this.toolStripButtonBrasil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBrasil.Name = "toolStripButtonBrasil";
            this.toolStripButtonBrasil.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonBrasil.Text = "Brasil";
            this.toolStripButtonBrasil.Click += new System.EventHandler(this.toolStripButtonBrasil_Click);
            // 
            // toolStripButtonTamanhos
            // 
            this.toolStripButtonTamanhos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTamanhos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTamanhos.Image")));
            this.toolStripButtonTamanhos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTamanhos.Name = "toolStripButtonTamanhos";
            this.toolStripButtonTamanhos.Size = new System.Drawing.Size(67, 22);
            this.toolStripButtonTamanhos.Text = "Tamanhos";
            this.toolStripButtonTamanhos.Click += new System.EventHandler(this.toolStripButtonTamanhos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 262);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdicao;
        private System.Windows.Forms.ToolStripButton toolStripButtonDivisivel;
        private System.Windows.Forms.ToolStripButton toolStripButtonTriangulo;
        private System.Windows.Forms.ToolStripButton toolStripButtonMeses;
        private System.Windows.Forms.ToolStripButton toolStripButtonUmAoCinquenta;
        private System.Windows.Forms.ToolStripButton toolStripButtonBrasil;
        private System.Windows.Forms.ToolStripButton toolStripButtonTamanhos;
    }
}

