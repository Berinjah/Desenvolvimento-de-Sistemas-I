namespace PrjCliente_conexao
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCadastros = new System.Windows.Forms.ToolStripButton();
            this.tsbConsulta = new System.Windows.Forms.ToolStripButton();
            this.tsbRelatorios = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadastros,
            this.tsbConsulta,
            this.tsbRelatorios});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCadastros
            // 
            this.tsbCadastros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCadastros.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadastros.Image")));
            this.tsbCadastros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadastros.Name = "tsbCadastros";
            this.tsbCadastros.Size = new System.Drawing.Size(63, 22);
            this.tsbCadastros.Text = "Cadastros";
            this.tsbCadastros.Click += new System.EventHandler(this.tsbCadastros_Click);
            // 
            // tsbConsulta
            // 
            this.tsbConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbConsulta.Image = ((System.Drawing.Image)(resources.GetObject("tsbConsulta.Image")));
            this.tsbConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsulta.Name = "tsbConsulta";
            this.tsbConsulta.Size = new System.Drawing.Size(63, 22);
            this.tsbConsulta.Text = "Consultas";
            // 
            // tsbRelatorios
            // 
            this.tsbRelatorios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("tsbRelatorios.Image")));
            this.tsbRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRelatorios.Name = "tsbRelatorios";
            this.tsbRelatorios.Size = new System.Drawing.Size(63, 22);
            this.tsbRelatorios.Text = "Relatórios";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCadastros;
        private System.Windows.Forms.ToolStripButton tsbConsulta;
        private System.Windows.Forms.ToolStripButton tsbRelatorios;
    }
}