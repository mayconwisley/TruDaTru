namespace TruDaTru
{
    partial class FrmPrincipal
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
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadComp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadMarc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadProd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstCada = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstCons = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusPrincipal = new System.Windows.Forms.StatusStrip();
            this.LblStaInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuPrincipal.SuspendLayout();
            this.StatusPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuEstoque,
            this.MenuRelatorio,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(1196, 24);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadComp,
            this.MenuCadMarc,
            this.MenuCadProd});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(66, 20);
            this.MenuCadastro.Text = "Cadastro";
            // 
            // MenuCadComp
            // 
            this.MenuCadComp.Name = "MenuCadComp";
            this.MenuCadComp.Size = new System.Drawing.Size(145, 22);
            this.MenuCadComp.Text = "Competência";
            this.MenuCadComp.Click += new System.EventHandler(this.MenuCadComp_Click);
            // 
            // MenuCadMarc
            // 
            this.MenuCadMarc.Name = "MenuCadMarc";
            this.MenuCadMarc.Size = new System.Drawing.Size(145, 22);
            this.MenuCadMarc.Text = "Marca";
            this.MenuCadMarc.Click += new System.EventHandler(this.MenuCadMarc_Click);
            // 
            // MenuCadProd
            // 
            this.MenuCadProd.Name = "MenuCadProd";
            this.MenuCadProd.Size = new System.Drawing.Size(145, 22);
            this.MenuCadProd.Text = "Produto";
            this.MenuCadProd.Click += new System.EventHandler(this.MenuCadProd_Click);
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEstCada,
            this.MenuEstCons});
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(61, 20);
            this.MenuEstoque.Text = "Estoque";
            // 
            // MenuEstCada
            // 
            this.MenuEstCada.Name = "MenuEstCada";
            this.MenuEstCada.Size = new System.Drawing.Size(121, 22);
            this.MenuEstCada.Text = "Cadastro";
            this.MenuEstCada.Click += new System.EventHandler(this.MenuEstCada_Click);
            // 
            // MenuEstCons
            // 
            this.MenuEstCons.Name = "MenuEstCons";
            this.MenuEstCons.Size = new System.Drawing.Size(121, 22);
            this.MenuEstCons.Text = "Consulta";
            this.MenuEstCons.Click += new System.EventHandler(this.MenuEstCons_Click);
            // 
            // MenuRelatorio
            // 
            this.MenuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRelRelatorio});
            this.MenuRelatorio.Name = "MenuRelatorio";
            this.MenuRelatorio.Size = new System.Drawing.Size(66, 20);
            this.MenuRelatorio.Text = "Relatório";
            // 
            // MenuRelRelatorio
            // 
            this.MenuRelRelatorio.Name = "MenuRelRelatorio";
            this.MenuRelRelatorio.Size = new System.Drawing.Size(180, 22);
            this.MenuRelRelatorio.Text = "Relatório";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // StatusPrincipal
            // 
            this.StatusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStaInfo});
            this.StatusPrincipal.Location = new System.Drawing.Point(0, 680);
            this.StatusPrincipal.Name = "StatusPrincipal";
            this.StatusPrincipal.Size = new System.Drawing.Size(1196, 22);
            this.StatusPrincipal.TabIndex = 2;
            this.StatusPrincipal.Text = "statusStrip1";
            // 
            // LblStaInfo
            // 
            this.LblStaInfo.Name = "LblStaInfo";
            this.LblStaInfo.Size = new System.Drawing.Size(248, 17);
            this.LblStaInfo.Text = "Versão 1.0 - Desenvolvido por: Maycon Wisley";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 702);
            this.Controls.Add(this.StatusPrincipal);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tru da Tru";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.StatusPrincipal.ResumeLayout(false);
            this.StatusPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuCadComp;
        private System.Windows.Forms.ToolStripMenuItem MenuCadMarc;
        private System.Windows.Forms.ToolStripMenuItem MenuCadProd;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuEstCada;
        private System.Windows.Forms.ToolStripMenuItem MenuEstCons;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem MenuRelRelatorio;
        private System.Windows.Forms.StatusStrip StatusPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripStatusLabel LblStaInfo;
    }
}

