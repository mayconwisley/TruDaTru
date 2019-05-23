namespace TruDaTru
{
    partial class FrmCadEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblCompetencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MktDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.CbxProduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DgvListaProduto = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.Id_Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Competecia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Es = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCompetencia
            // 
            this.LblCompetencia.AutoSize = true;
            this.LblCompetencia.Location = new System.Drawing.Point(13, 11);
            this.LblCompetencia.Name = "LblCompetencia";
            this.LblCompetencia.Size = new System.Drawing.Size(116, 13);
            this.LblCompetencia.TabIndex = 0;
            this.LblCompetencia.Text = "Competência: 00/0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Cadastro";
            // 
            // MktDataCadastro
            // 
            this.MktDataCadastro.Location = new System.Drawing.Point(13, 70);
            this.MktDataCadastro.Mask = "00/00/0000";
            this.MktDataCadastro.Name = "MktDataCadastro";
            this.MktDataCadastro.Size = new System.Drawing.Size(82, 20);
            this.MktDataCadastro.TabIndex = 2;
            this.MktDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // CbxProduto
            // 
            this.CbxProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxProduto.DisplayMember = "Produto_Marca";
            this.CbxProduto.FormattingEnabled = true;
            this.CbxProduto.Location = new System.Drawing.Point(101, 70);
            this.CbxProduto.Name = "CbxProduto";
            this.CbxProduto.Size = new System.Drawing.Size(347, 21);
            this.CbxProduto.TabIndex = 3;
            this.CbxProduto.ValueMember = "Id";
            this.CbxProduto.SelectedIndexChanged += new System.EventHandler(this.CbxProduto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produto";
            // 
            // CbxTipo
            // 
            this.CbxTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.CbxTipo.Location = new System.Drawing.Point(454, 70);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(93, 21);
            this.CbxTipo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantidade";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(13, 118);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(62, 20);
            this.TxtQuantidade.TabIndex = 8;
            this.TxtQuantidade.Text = "0";
            this.TxtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtQuantidade.TextChanged += new System.EventHandler(this.TxtQuantidade_TextChanged);
            this.TxtQuantidade.Enter += new System.EventHandler(this.TxtQuantidade_Enter);
            this.TxtQuantidade.Leave += new System.EventHandler(this.TxtQuantidade_Leave);
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(81, 118);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(67, 20);
            this.TxtValor.TabIndex = 9;
            this.TxtValor.Text = "0,00";
            this.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            this.TxtValor.Enter += new System.EventHandler(this.TxtValor_Enter);
            this.TxtValor.Leave += new System.EventHandler(this.TxtValor_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor Unitário";
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(566, 44);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 11;
            this.BtnGravar.Text = "&Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(566, 73);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 11;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(566, 102);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 11;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // DgvListaProduto
            // 
            this.DgvListaProduto.AllowUserToAddRows = false;
            this.DgvListaProduto.AllowUserToDeleteRows = false;
            this.DgvListaProduto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListaProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Estoque,
            this.Id_Competecia,
            this.Id_Marca,
            this.Id_Produto,
            this.Competencia,
            this.Produto,
            this.Marca,
            this.Tipo_Es,
            this.Data_Cadastro,
            this.Qtd_Produto,
            this.Valor_Unitario,
            this.Valor_Total});
            this.DgvListaProduto.Location = new System.Drawing.Point(13, 206);
            this.DgvListaProduto.MultiSelect = false;
            this.DgvListaProduto.Name = "DgvListaProduto";
            this.DgvListaProduto.ReadOnly = true;
            this.DgvListaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaProduto.Size = new System.Drawing.Size(628, 234);
            this.DgvListaProduto.TabIndex = 12;
            this.DgvListaProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaProduto_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lista Produto";
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Location = new System.Drawing.Point(154, 118);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.ReadOnly = true;
            this.TxtValorTotal.Size = new System.Drawing.Size(90, 20);
            this.TxtValorTotal.TabIndex = 14;
            this.TxtValorTotal.Text = "0,00";
            this.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Pesquisa";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(13, 157);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(628, 20);
            this.TxtPesquisa.TabIndex = 17;
            // 
            // Id_Estoque
            // 
            this.Id_Estoque.DataPropertyName = "Id_Estoque";
            this.Id_Estoque.HeaderText = "Id_Estoque";
            this.Id_Estoque.Name = "Id_Estoque";
            this.Id_Estoque.ReadOnly = true;
            this.Id_Estoque.Visible = false;
            // 
            // Id_Competecia
            // 
            this.Id_Competecia.DataPropertyName = "Id_Competecia";
            this.Id_Competecia.HeaderText = "Id_Competecia";
            this.Id_Competecia.Name = "Id_Competecia";
            this.Id_Competecia.ReadOnly = true;
            this.Id_Competecia.Visible = false;
            // 
            // Id_Marca
            // 
            this.Id_Marca.DataPropertyName = "Id_Marca";
            this.Id_Marca.HeaderText = "Id_Marca";
            this.Id_Marca.Name = "Id_Marca";
            this.Id_Marca.ReadOnly = true;
            this.Id_Marca.Visible = false;
            // 
            // Id_Produto
            // 
            this.Id_Produto.DataPropertyName = "Id_Produto";
            this.Id_Produto.HeaderText = "Id_Produto";
            this.Id_Produto.Name = "Id_Produto";
            this.Id_Produto.ReadOnly = true;
            this.Id_Produto.Visible = false;
            // 
            // Competencia
            // 
            this.Competencia.DataPropertyName = "Competencia";
            this.Competencia.HeaderText = "Competencia";
            this.Competencia.Name = "Competencia";
            this.Competencia.ReadOnly = true;
            this.Competencia.Visible = false;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Tipo_Es
            // 
            this.Tipo_Es.DataPropertyName = "Tipo_Es";
            this.Tipo_Es.HeaderText = "Tipo_Es";
            this.Tipo_Es.Name = "Tipo_Es";
            this.Tipo_Es.ReadOnly = true;
            // 
            // Data_Cadastro
            // 
            this.Data_Cadastro.DataPropertyName = "Data_Cadastro";
            this.Data_Cadastro.HeaderText = "Data_Cadastro";
            this.Data_Cadastro.Name = "Data_Cadastro";
            this.Data_Cadastro.ReadOnly = true;
            // 
            // Qtd_Produto
            // 
            this.Qtd_Produto.DataPropertyName = "Qtd_Produto";
            this.Qtd_Produto.HeaderText = "Qtd_Produto";
            this.Qtd_Produto.Name = "Qtd_Produto";
            this.Qtd_Produto.ReadOnly = true;
            // 
            // Valor_Unitario
            // 
            this.Valor_Unitario.DataPropertyName = "Valor_Unitario";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.Valor_Unitario.DefaultCellStyle = dataGridViewCellStyle13;
            this.Valor_Unitario.HeaderText = "Valor_Unitario";
            this.Valor_Unitario.Name = "Valor_Unitario";
            this.Valor_Unitario.ReadOnly = true;
            // 
            // Valor_Total
            // 
            this.Valor_Total.DataPropertyName = "Valor_Total";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.Valor_Total.DefaultCellStyle = dataGridViewCellStyle14;
            this.Valor_Total.HeaderText = "Valor_Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            // 
            // FrmCadEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtValorTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DgvListaProduto);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxProduto);
            this.Controls.Add(this.MktDataCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblCompetencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadEstoque";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Estoque";
            this.Load += new System.EventHandler(this.FrmCadEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCompetencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MktDataCadastro;
        private System.Windows.Forms.ComboBox CbxProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView DgvListaProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Competecia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Es;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
    }
}