namespace WindowsFormsApplication1
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitBtnAbrirTeste = new System.Windows.Forms.ToolStripSplitButton();
            this.teste1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBtnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitBtnAbrirTeste,
            this.toolStripBtnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(282, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitBtnAbrirTeste
            // 
            this.toolStripSplitBtnAbrirTeste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitBtnAbrirTeste.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teste1ToolStripMenuItem,
            this.teste2ToolStripMenuItem});
            this.toolStripSplitBtnAbrirTeste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitBtnAbrirTeste.Image")));
            this.toolStripSplitBtnAbrirTeste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitBtnAbrirTeste.Name = "toolStripSplitBtnAbrirTeste";
            this.toolStripSplitBtnAbrirTeste.Size = new System.Drawing.Size(100, 24);
            this.toolStripSplitBtnAbrirTeste.Text = "Abrir testes";
            // 
            // teste1ToolStripMenuItem
            // 
            this.teste1ToolStripMenuItem.Name = "teste1ToolStripMenuItem";
            this.teste1ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.teste1ToolStripMenuItem.Text = "Teste1";
            this.teste1ToolStripMenuItem.Click += new System.EventHandler(this.teste1ToolStripMenuItem_Click);
            // 
            // teste2ToolStripMenuItem
            // 
            this.teste2ToolStripMenuItem.Name = "teste2ToolStripMenuItem";
            this.teste2ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.teste2ToolStripMenuItem.Text = "Teste2";
            this.teste2ToolStripMenuItem.Click += new System.EventHandler(this.teste2ToolStripMenuItem_Click);
            // 
            // toolStripBtnSair
            // 
            this.toolStripBtnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSair.Image")));
            this.toolStripBtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSair.Name = "toolStripBtnSair";
            this.toolStripBtnSair.Size = new System.Drawing.Size(44, 24);
            this.toolStripBtnSair.Text = "SAIR";
            this.toolStripBtnSair.Click += new System.EventHandler(this.toolStripBtnSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.Text = "Exemplo de menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitBtnAbrirTeste;
        private System.Windows.Forms.ToolStripMenuItem teste1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripBtnSair;
    }
}

