﻿namespace TruDaTru
{
    partial class FrmCadCompetencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MktCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbAtivo = new System.Windows.Forms.CheckBox();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DgvListaCompetencia = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCompetencia)).BeginInit();
            this.SuspendLayout();
            // 
            // MktCompetencia
            // 
            this.MktCompetencia.Location = new System.Drawing.Point(15, 26);
            this.MktCompetencia.Mask = "##/####";
            this.MktCompetencia.Name = "MktCompetencia";
            this.MktCompetencia.PromptChar = ' ';
            this.MktCompetencia.Size = new System.Drawing.Size(76, 20);
            this.MktCompetencia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Competência";
            // 
            // CbAtivo
            // 
            this.CbAtivo.AutoSize = true;
            this.CbAtivo.Checked = true;
            this.CbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbAtivo.Location = new System.Drawing.Point(97, 28);
            this.CbAtivo.Name = "CbAtivo";
            this.CbAtivo.Size = new System.Drawing.Size(50, 17);
            this.CbAtivo.TabIndex = 2;
            this.CbAtivo.Text = "Ativo";
            this.CbAtivo.UseVisualStyleBackColor = true;
            this.CbAtivo.CheckedChanged += new System.EventHandler(this.CbAtivo_CheckedChanged);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(12, 52);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 3;
            this.BtnGravar.Text = "&Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(93, 51);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 3;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(174, 51);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // DgvListaCompetencia
            // 
            this.DgvListaCompetencia.AllowUserToAddRows = false;
            this.DgvListaCompetencia.AllowUserToDeleteRows = false;
            this.DgvListaCompetencia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListaCompetencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCompetencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Data_Competencia,
            this.Ativo});
            this.DgvListaCompetencia.Location = new System.Drawing.Point(12, 104);
            this.DgvListaCompetencia.MultiSelect = false;
            this.DgvListaCompetencia.Name = "DgvListaCompetencia";
            this.DgvListaCompetencia.ReadOnly = true;
            this.DgvListaCompetencia.RowHeadersWidth = 35;
            this.DgvListaCompetencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaCompetencia.Size = new System.Drawing.Size(237, 164);
            this.DgvListaCompetencia.TabIndex = 4;
            this.DgvListaCompetencia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaCompetencia_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Data_Competencia
            // 
            this.Data_Competencia.DataPropertyName = "Data_Competencia";
            dataGridViewCellStyle1.Format = "MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.Data_Competencia.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data_Competencia.HeaderText = "Competência";
            this.Data_Competencia.Name = "Data_Competencia";
            this.Data_Competencia.ReadOnly = true;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de competências";
            // 
            // FrmCadCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvListaCompetencia);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.CbAtivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MktCompetencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadCompetencia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Competência";
            this.Load += new System.EventHandler(this.FrmCadCompetencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCompetencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MktCompetencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CbAtivo;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView DgvListaCompetencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
    }
}