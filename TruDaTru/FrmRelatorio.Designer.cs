namespace TruDaTru
{
    partial class FrmRelatorio
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
            this.GbOpcoes = new System.Windows.Forms.GroupBox();
            this.CbMarca = new System.Windows.Forms.CheckBox();
            this.CbPeriodo = new System.Windows.Forms.CheckBox();
            this.RbMarca = new System.Windows.Forms.RadioButton();
            this.RbProduto = new System.Windows.Forms.RadioButton();
            this.RbEstoque = new System.Windows.Forms.RadioButton();
            this.CbxMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MktDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MktDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxProduto = new System.Windows.Forms.ComboBox();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.GbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbOpcoes
            // 
            this.GbOpcoes.Controls.Add(this.CbMarca);
            this.GbOpcoes.Controls.Add(this.CbPeriodo);
            this.GbOpcoes.Controls.Add(this.RbMarca);
            this.GbOpcoes.Controls.Add(this.RbProduto);
            this.GbOpcoes.Controls.Add(this.RbEstoque);
            this.GbOpcoes.Location = new System.Drawing.Point(15, 13);
            this.GbOpcoes.Name = "GbOpcoes";
            this.GbOpcoes.Size = new System.Drawing.Size(220, 74);
            this.GbOpcoes.TabIndex = 0;
            this.GbOpcoes.TabStop = false;
            this.GbOpcoes.Text = "Opção";
            // 
            // CbMarca
            // 
            this.CbMarca.AutoSize = true;
            this.CbMarca.Location = new System.Drawing.Point(76, 42);
            this.CbMarca.Name = "CbMarca";
            this.CbMarca.Size = new System.Drawing.Size(56, 17);
            this.CbMarca.TabIndex = 7;
            this.CbMarca.Text = "Marca";
            this.CbMarca.UseVisualStyleBackColor = true;
            // 
            // CbPeriodo
            // 
            this.CbPeriodo.AutoSize = true;
            this.CbPeriodo.Location = new System.Drawing.Point(6, 42);
            this.CbPeriodo.Name = "CbPeriodo";
            this.CbPeriodo.Size = new System.Drawing.Size(64, 17);
            this.CbPeriodo.TabIndex = 6;
            this.CbPeriodo.Text = "Período";
            this.CbPeriodo.UseVisualStyleBackColor = true;
            // 
            // RbMarca
            // 
            this.RbMarca.AutoSize = true;
            this.RbMarca.Location = new System.Drawing.Point(144, 19);
            this.RbMarca.Name = "RbMarca";
            this.RbMarca.Size = new System.Drawing.Size(55, 17);
            this.RbMarca.TabIndex = 0;
            this.RbMarca.Text = "Marca";
            this.RbMarca.UseVisualStyleBackColor = true;
            // 
            // RbProduto
            // 
            this.RbProduto.AutoSize = true;
            this.RbProduto.Location = new System.Drawing.Point(76, 19);
            this.RbProduto.Name = "RbProduto";
            this.RbProduto.Size = new System.Drawing.Size(62, 17);
            this.RbProduto.TabIndex = 0;
            this.RbProduto.Text = "Produto";
            this.RbProduto.UseVisualStyleBackColor = true;
            // 
            // RbEstoque
            // 
            this.RbEstoque.AutoSize = true;
            this.RbEstoque.Checked = true;
            this.RbEstoque.Location = new System.Drawing.Point(6, 19);
            this.RbEstoque.Name = "RbEstoque";
            this.RbEstoque.Size = new System.Drawing.Size(64, 17);
            this.RbEstoque.TabIndex = 0;
            this.RbEstoque.TabStop = true;
            this.RbEstoque.Text = "Estoque";
            this.RbEstoque.UseVisualStyleBackColor = true;
            // 
            // CbxMarca
            // 
            this.CbxMarca.DisplayMember = "Descricao";
            this.CbxMarca.FormattingEnabled = true;
            this.CbxMarca.Location = new System.Drawing.Point(15, 145);
            this.CbxMarca.Name = "CbxMarca";
            this.CbxMarca.Size = new System.Drawing.Size(300, 21);
            this.CbxMarca.TabIndex = 1;
            this.CbxMarca.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Competência";
            // 
            // MktDataInicial
            // 
            this.MktDataInicial.Location = new System.Drawing.Point(15, 106);
            this.MktDataInicial.Mask = "00/00/0000";
            this.MktDataInicial.Name = "MktDataInicial";
            this.MktDataInicial.Size = new System.Drawing.Size(81, 20);
            this.MktDataInicial.TabIndex = 4;
            this.MktDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "a";
            // 
            // MktDataFinal
            // 
            this.MktDataFinal.Location = new System.Drawing.Point(121, 106);
            this.MktDataFinal.Mask = "00/00/0000";
            this.MktDataFinal.Name = "MktDataFinal";
            this.MktDataFinal.Size = new System.Drawing.Size(81, 20);
            this.MktDataFinal.TabIndex = 4;
            this.MktDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Produto";
            // 
            // CbxProduto
            // 
            this.CbxProduto.DisplayMember = "Produto_Marca";
            this.CbxProduto.FormattingEnabled = true;
            this.CbxProduto.Location = new System.Drawing.Point(15, 185);
            this.CbxProduto.Name = "CbxProduto";
            this.CbxProduto.Size = new System.Drawing.Size(300, 21);
            this.CbxProduto.TabIndex = 7;
            this.CbxProduto.ValueMember = "Id";
            // 
            // BtnGerar
            // 
            this.BtnGerar.Location = new System.Drawing.Point(241, 13);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(74, 23);
            this.BtnGerar.TabIndex = 8;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = true;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 218);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.CbxProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MktDataFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MktDataInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxMarca);
            this.Controls.Add(this.GbOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.GbOpcoes.ResumeLayout(false);
            this.GbOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbOpcoes;
        private System.Windows.Forms.RadioButton RbProduto;
        private System.Windows.Forms.RadioButton RbEstoque;
        private System.Windows.Forms.RadioButton RbMarca;
        private System.Windows.Forms.ComboBox CbxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MktDataInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MktDataFinal;
        private System.Windows.Forms.CheckBox CbPeriodo;
        private System.Windows.Forms.CheckBox CbMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxProduto;
        private System.Windows.Forms.Button BtnGerar;
    }
}