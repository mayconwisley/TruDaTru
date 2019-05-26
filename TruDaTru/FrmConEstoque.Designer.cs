namespace TruDaTru
{
    partial class FrmConEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxProduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxMarca = new System.Windows.Forms.ComboBox();
            this.RbProduto = new System.Windows.Forms.RadioButton();
            this.RbMarca = new System.Windows.Forms.RadioButton();
            this.LblA = new System.Windows.Forms.Label();
            this.MktPerFinal = new System.Windows.Forms.MaskedTextBox();
            this.MktPerInicio = new System.Windows.Forms.MaskedTextBox();
            this.RbPeriodo = new System.Windows.Forms.RadioButton();
            this.RbCompetencia = new System.Windows.Forms.RadioButton();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.DgvListaProduto = new System.Windows.Forms.DataGridView();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lblinfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProduto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxProduto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CbxMarca);
            this.groupBox1.Controls.Add(this.RbProduto);
            this.groupBox1.Controls.Add(this.RbMarca);
            this.groupBox1.Controls.Add(this.LblA);
            this.groupBox1.Controls.Add(this.MktPerFinal);
            this.groupBox1.Controls.Add(this.MktPerInicio);
            this.groupBox1.Controls.Add(this.RbPeriodo);
            this.groupBox1.Controls.Add(this.RbCompetencia);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções de consulta";
            // 
            // CbxProduto
            // 
            this.CbxProduto.DisplayMember = "Produto_Marca";
            this.CbxProduto.Enabled = false;
            this.CbxProduto.FormattingEnabled = true;
            this.CbxProduto.Location = new System.Drawing.Point(6, 121);
            this.CbxProduto.Name = "CbxProduto";
            this.CbxProduto.Size = new System.Drawing.Size(285, 21);
            this.CbxProduto.TabIndex = 8;
            this.CbxProduto.ValueMember = "Id";
            this.CbxProduto.SelectedIndexChanged += new System.EventHandler(this.CbxProduto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marca";
            // 
            // CbxMarca
            // 
            this.CbxMarca.DisplayMember = "Descricao";
            this.CbxMarca.Enabled = false;
            this.CbxMarca.FormattingEnabled = true;
            this.CbxMarca.Location = new System.Drawing.Point(6, 81);
            this.CbxMarca.Name = "CbxMarca";
            this.CbxMarca.Size = new System.Drawing.Size(285, 21);
            this.CbxMarca.TabIndex = 7;
            this.CbxMarca.ValueMember = "Id";
            this.CbxMarca.SelectedIndexChanged += new System.EventHandler(this.CbxMarca_SelectedIndexChanged);
            // 
            // RbProduto
            // 
            this.RbProduto.AutoSize = true;
            this.RbProduto.Location = new System.Drawing.Point(227, 19);
            this.RbProduto.Name = "RbProduto";
            this.RbProduto.Size = new System.Drawing.Size(62, 17);
            this.RbProduto.TabIndex = 4;
            this.RbProduto.TabStop = true;
            this.RbProduto.Text = "Produto";
            this.RbProduto.UseVisualStyleBackColor = true;
            this.RbProduto.CheckedChanged += new System.EventHandler(this.RbProduto_CheckedChanged);
            // 
            // RbMarca
            // 
            this.RbMarca.AutoSize = true;
            this.RbMarca.Location = new System.Drawing.Point(166, 19);
            this.RbMarca.Name = "RbMarca";
            this.RbMarca.Size = new System.Drawing.Size(55, 17);
            this.RbMarca.TabIndex = 3;
            this.RbMarca.TabStop = true;
            this.RbMarca.Text = "Marca";
            this.RbMarca.UseVisualStyleBackColor = true;
            this.RbMarca.CheckedChanged += new System.EventHandler(this.RbMarca_CheckedChanged);
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(99, 45);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(13, 13);
            this.LblA.TabIndex = 3;
            this.LblA.Text = "a";
            this.LblA.Visible = false;
            // 
            // MktPerFinal
            // 
            this.MktPerFinal.Location = new System.Drawing.Point(118, 42);
            this.MktPerFinal.Mask = "00/00/0000";
            this.MktPerFinal.Name = "MktPerFinal";
            this.MktPerFinal.Size = new System.Drawing.Size(87, 20);
            this.MktPerFinal.TabIndex = 6;
            this.MktPerFinal.ValidatingType = typeof(System.DateTime);
            this.MktPerFinal.Visible = false;
            // 
            // MktPerInicio
            // 
            this.MktPerInicio.Location = new System.Drawing.Point(6, 42);
            this.MktPerInicio.Mask = "00/0000";
            this.MktPerInicio.Name = "MktPerInicio";
            this.MktPerInicio.Size = new System.Drawing.Size(87, 20);
            this.MktPerInicio.TabIndex = 5;
            this.MktPerInicio.ValidatingType = typeof(System.DateTime);
            // 
            // RbPeriodo
            // 
            this.RbPeriodo.AutoSize = true;
            this.RbPeriodo.Location = new System.Drawing.Point(99, 19);
            this.RbPeriodo.Name = "RbPeriodo";
            this.RbPeriodo.Size = new System.Drawing.Size(61, 17);
            this.RbPeriodo.TabIndex = 2;
            this.RbPeriodo.Text = "Periodo";
            this.RbPeriodo.UseVisualStyleBackColor = true;
            this.RbPeriodo.CheckedChanged += new System.EventHandler(this.RbPeriodo_CheckedChanged);
            // 
            // RbCompetencia
            // 
            this.RbCompetencia.AutoSize = true;
            this.RbCompetencia.Checked = true;
            this.RbCompetencia.Location = new System.Drawing.Point(6, 19);
            this.RbCompetencia.Name = "RbCompetencia";
            this.RbCompetencia.Size = new System.Drawing.Size(87, 17);
            this.RbCompetencia.TabIndex = 1;
            this.RbCompetencia.TabStop = true;
            this.RbCompetencia.Text = "Competência";
            this.RbCompetencia.UseVisualStyleBackColor = true;
            this.RbCompetencia.CheckedChanged += new System.EventHandler(this.RbCompetencia_CheckedChanged);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(530, 12);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(110, 31);
            this.BtnConsultar.TabIndex = 9;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
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
            this.DgvListaProduto.Location = new System.Drawing.Point(12, 178);
            this.DgvListaProduto.MultiSelect = false;
            this.DgvListaProduto.Name = "DgvListaProduto";
            this.DgvListaProduto.ReadOnly = true;
            this.DgvListaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaProduto.Size = new System.Drawing.Size(628, 234);
            this.DgvListaProduto.TabIndex = 10;
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
            this.Tipo_Es.HeaderText = "Tipo ES";
            this.Tipo_Es.Name = "Tipo_Es";
            this.Tipo_Es.ReadOnly = true;
            // 
            // Data_Cadastro
            // 
            this.Data_Cadastro.DataPropertyName = "Data_Cadastro";
            this.Data_Cadastro.HeaderText = "Data Cadastro";
            this.Data_Cadastro.Name = "Data_Cadastro";
            this.Data_Cadastro.ReadOnly = true;
            // 
            // Qtd_Produto
            // 
            this.Qtd_Produto.DataPropertyName = "Qtd_Produto";
            this.Qtd_Produto.HeaderText = "Qtd Produto";
            this.Qtd_Produto.Name = "Qtd_Produto";
            this.Qtd_Produto.ReadOnly = true;
            // 
            // Valor_Unitario
            // 
            this.Valor_Unitario.DataPropertyName = "Valor_Unitario";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Valor_Unitario.DefaultCellStyle = dataGridViewCellStyle5;
            this.Valor_Unitario.HeaderText = "Valor Unitário";
            this.Valor_Unitario.Name = "Valor_Unitario";
            this.Valor_Unitario.ReadOnly = true;
            // 
            // Valor_Total
            // 
            this.Valor_Total.DataPropertyName = "Valor_Total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Valor_Total.DefaultCellStyle = dataGridViewCellStyle6;
            this.Valor_Total.HeaderText = "Valor Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lblinfo);
            this.groupBox2.Location = new System.Drawing.Point(325, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 120);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // Lblinfo
            // 
            this.Lblinfo.AutoSize = true;
            this.Lblinfo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblinfo.Location = new System.Drawing.Point(6, 20);
            this.Lblinfo.Name = "Lblinfo";
            this.Lblinfo.Size = new System.Drawing.Size(28, 14);
            this.Lblinfo.TabIndex = 0;
            this.Lblinfo.Text = "...";
            // 
            // FrmConEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DgvListaProduto);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConEstoque";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Estoque";
            this.Load += new System.EventHandler(this.FrmConEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProduto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbCompetencia;
        private System.Windows.Forms.RadioButton RbPeriodo;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.MaskedTextBox MktPerFinal;
        private System.Windows.Forms.MaskedTextBox MktPerInicio;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.RadioButton RbProduto;
        private System.Windows.Forms.RadioButton RbMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxProduto;
        private System.Windows.Forms.DataGridView DgvListaProduto;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lblinfo;
    }
}