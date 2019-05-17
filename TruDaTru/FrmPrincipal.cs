﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruDaTru
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        FrmCadCompetencia cadCompetencia;
        FrmCadEstoque cadEstoque;
        FrmCadMarca cadMarca;
        FrmCadProduto cadProduto;

        bool aberto;

        private void MenuCadComp_Click(object sender, EventArgs e)
        {
            aberto = true;
            foreach (Form item in Application.OpenForms)
            {
                cadCompetencia = new FrmCadCompetencia();
                cadCompetencia.MdiParent = this;
                if (item is FrmCadCompetencia)
                {
                    item.Focus();
                    aberto = false;
                }
            }
            if (aberto)
            {
                cadCompetencia.Show();
            }
        }

        private void MenuCadMarc_Click(object sender, EventArgs e)
        {
            aberto = true;
            foreach (Form item in Application.OpenForms)
            {
                cadMarca = new FrmCadMarca();
                cadMarca.MdiParent = this;
                if (item is FrmCadMarca)
                {
                    item.Focus();
                    aberto = false;
                }
            }
            if (aberto)
            {
                cadMarca.Show();
            }
        }

        private void MenuCadProd_Click(object sender, EventArgs e)
        {
            aberto = true;
            foreach (Form item in Application.OpenForms)
            {
                cadProduto = new FrmCadProduto();
                cadProduto.MdiParent = this;
                if (item is FrmCadProduto)
                {
                    item.Focus();
                    aberto = false;
                }
            }
            if (aberto)
            {
                cadProduto.Show();
            }
        }

        private void MenuEstCada_Click(object sender, EventArgs e)
        {
            aberto = true;
            foreach (Form item in Application.OpenForms)
            {
                cadEstoque = new FrmCadEstoque();
                cadEstoque.MdiParent = this;
                if (item is FrmCadEstoque)
                {
                    item.Focus();
                    aberto = false;
                }
            }
            if (aberto)
            {
                cadEstoque.Show();
            }
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}