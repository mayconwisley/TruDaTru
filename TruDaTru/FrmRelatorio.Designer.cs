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
            this.RbMarca = new System.Windows.Forms.RadioButton();
            this.RbProduto = new System.Windows.Forms.RadioButton();
            this.RbCompetencia = new System.Windows.Forms.RadioButton();
            this.CbxMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MktPerInicio = new System.Windows.Forms.MaskedTextBox();
            this.LblA = new System.Windows.Forms.Label();
            this.MktPerFinal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxProduto = new System.Windows.Forms.ComboBox();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.RbPeriodo = new System.Windows.Forms.RadioButton();
            this.CbMarc = new System.Windows.Forms.CheckBox();
            this.CbProd = new System.Windows.Forms.CheckBox();
            this.GbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbOpcoes
            // 
            this.GbOpcoes.Controls.Add(this.RbMarca);
            this.GbOpcoes.Controls.Add(this.RbProduto);
            this.GbOpcoes.Controls.Add(this.RbPeriodo);
            this.GbOpcoes.Controls.Add(this.RbCompetencia);
            this.GbOpcoes.Location = new System.Drawing.Point(15, 12);
            this.GbOpcoes.Name = "GbOpcoes";
            this.GbOpcoes.Size = new System.Drawing.Size(300, 45);
            this.GbOpcoes.TabIndex = 0;
            this.GbOpcoes.TabStop = false;
            this.GbOpcoes.Text = "Opção";
            // 
            // RbMarca
            // 
            this.RbMarca.AutoSize = true;
            this.RbMarca.Location = new System.Drawing.Point(236, 19);
            this.RbMarca.Name = "RbMarca";
            this.RbMarca.Size = new System.Drawing.Size(55, 17);
            this.RbMarca.TabIndex = 0;
            this.RbMarca.Text = "Marca";
            this.RbMarca.UseVisualStyleBackColor = true;
            this.RbMarca.CheckedChanged += new System.EventHandler(this.RbMarca_CheckedChanged);
            // 
            // RbProduto
            // 
            this.RbProduto.AutoSize = true;
            this.RbProduto.Location = new System.Drawing.Point(168, 19);
            this.RbProduto.Name = "RbProduto";
            this.RbProduto.Size = new System.Drawing.Size(62, 17);
            this.RbProduto.TabIndex = 0;
            this.RbProduto.Text = "Produto";
            this.RbProduto.UseVisualStyleBackColor = true;
            this.RbProduto.CheckedChanged += new System.EventHandler(this.RbProduto_CheckedChanged);
            // 
            // RbCompetencia
            // 
            this.RbCompetencia.AutoSize = true;
            this.RbCompetencia.Checked = true;
            this.RbCompetencia.Location = new System.Drawing.Point(6, 19);
            this.RbCompetencia.Name = "RbCompetencia";
            this.RbCompetencia.Size = new System.Drawing.Size(87, 17);
            this.RbCompetencia.TabIndex = 0;
            this.RbCompetencia.Text = "Competência";
            this.RbCompetencia.UseVisualStyleBackColor = true;
            this.RbCompetencia.CheckedChanged += new System.EventHandler(this.RbCompetencia_CheckedChanged);
            // 
            // CbxMarca
            // 
            this.CbxMarca.DisplayMember = "Descricao";
            this.CbxMarca.Enabled = false;
            this.CbxMarca.FormattingEnabled = true;
            this.CbxMarca.Location = new System.Drawing.Point(46, 115);
            this.CbxMarca.Name = "CbxMarca";
            this.CbxMarca.Size = new System.Drawing.Size(269, 21);
            this.CbxMarca.TabIndex = 1;
            this.CbxMarca.ValueMember = "Id";
            this.CbxMarca.SelectedIndexChanged += new System.EventHandler(this.CbxMarca_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Competência";
            // 
            // MktPerInicio
            // 
            this.MktPerInicio.Location = new System.Drawing.Point(15, 76);
            this.MktPerInicio.Mask = "00/0000";
            this.MktPerInicio.Name = "MktPerInicio";
            this.MktPerInicio.Size = new System.Drawing.Size(81, 20);
            this.MktPerInicio.TabIndex = 4;
            this.MktPerInicio.ValidatingType = typeof(System.DateTime);
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(102, 79);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(13, 13);
            this.LblA.TabIndex = 5;
            this.LblA.Text = "a";
            this.LblA.Visible = false;
            // 
            // MktPerFinal
            // 
            this.MktPerFinal.Location = new System.Drawing.Point(121, 76);
            this.MktPerFinal.Mask = "00/00/0000";
            this.MktPerFinal.Name = "MktPerFinal";
            this.MktPerFinal.Size = new System.Drawing.Size(81, 20);
            this.MktPerFinal.TabIndex = 4;
            this.MktPerFinal.ValidatingType = typeof(System.DateTime);
            this.MktPerFinal.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Produto";
            // 
            // CbxProduto
            // 
            this.CbxProduto.DisplayMember = "Produto_Marca";
            this.CbxProduto.Enabled = false;
            this.CbxProduto.FormattingEnabled = true;
            this.CbxProduto.Location = new System.Drawing.Point(46, 155);
            this.CbxProduto.Name = "CbxProduto";
            this.CbxProduto.Size = new System.Drawing.Size(269, 21);
            this.CbxProduto.TabIndex = 7;
            this.CbxProduto.ValueMember = "Id";
            this.CbxProduto.SelectedIndexChanged += new System.EventHandler(this.CbxProduto_SelectedIndexChanged);
            // 
            // BtnGerar
            // 
            this.BtnGerar.Location = new System.Drawing.Point(321, 12);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(74, 23);
            this.BtnGerar.TabIndex = 8;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = true;
            // 
            // RbPeriodo
            // 
            this.RbPeriodo.AutoSize = true;
            this.RbPeriodo.Location = new System.Drawing.Point(99, 19);
            this.RbPeriodo.Name = "RbPeriodo";
            this.RbPeriodo.Size = new System.Drawing.Size(63, 17);
            this.RbPeriodo.TabIndex = 0;
            this.RbPeriodo.Text = "Período";
            this.RbPeriodo.UseVisualStyleBackColor = true;
            this.RbPeriodo.CheckedChanged += new System.EventHandler(this.RbPeriodo_CheckedChanged);
            // 
            // CbMarc
            // 
            this.CbMarc.AutoSize = true;
            this.CbMarc.Location = new System.Drawing.Point(21, 118);
            this.CbMarc.Name = "CbMarc";
            this.CbMarc.Size = new System.Drawing.Size(15, 14);
            this.CbMarc.TabIndex = 9;
            this.CbMarc.UseVisualStyleBackColor = true;
            this.CbMarc.CheckedChanged += new System.EventHandler(this.CbMarc_CheckedChanged);
            // 
            // CbProd
            // 
            this.CbProd.AutoSize = true;
            this.CbProd.Location = new System.Drawing.Point(21, 158);
            this.CbProd.Name = "CbProd";
            this.CbProd.Size = new System.Drawing.Size(15, 14);
            this.CbProd.TabIndex = 9;
            this.CbProd.UseVisualStyleBackColor = true;
            this.CbProd.CheckedChanged += new System.EventHandler(this.CbProd_CheckedChanged);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 188);
            this.Controls.Add(this.CbProd);
            this.Controls.Add(this.CbMarc);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.CbxProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MktPerFinal);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.MktPerInicio);
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
        private System.Windows.Forms.RadioButton RbCompetencia;
        private System.Windows.Forms.RadioButton RbMarca;
        private System.Windows.Forms.ComboBox CbxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MktPerInicio;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.MaskedTextBox MktPerFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxProduto;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.RadioButton RbPeriodo;
        private System.Windows.Forms.CheckBox CbMarc;
        private System.Windows.Forms.CheckBox CbProd;
    }
}