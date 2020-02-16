using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Competencia;
using Negocio.Estoque;
using Negocio.Marca;
using Negocio.Produto;

namespace TruDaTru
{
    public partial class FrmRelatorio : Form
    {
        #region Modelos e Negocios
        NegEstConsulta negEstConsulta;
        NegCompConsulta negCompConsulta;
        NegMarcConsulta negMarcConsulta;
        NegProdConsulta negProdConsulta;
        #endregion

        #region Variaveis
        int opc = 1, compId = 0, prodId = 0, marcId = 0;
        DateTime dtPerInicio, dtPerFinal;
        #endregion

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            CompetenciaAtiva();
            ListarMarcas();
            ListarProdutos();
            Verificacao();
        }

        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void CbMarc_CheckedChanged(object sender, EventArgs e)
        {
            if (RbCompetencia.Checked || RbPeriodo.Checked)
            {
                if (CbMarc.Checked)
                {
                    CbxMarca.Enabled = true;
                    CbProd.Enabled = false;
                    CbxProduto.Enabled = false;
                }
                else
                {
                    CbxMarca.Enabled = false;
                    CbProd.Enabled = true;
                }
            }
        }

        private void CbProd_CheckedChanged(object sender, EventArgs e)
        {
            if (RbCompetencia.Checked || RbPeriodo.Checked)
            {
                if (CbProd.Checked)
                {
                    CbxProduto.Enabled = true;
                    CbMarc.Enabled = false;
                    CbxMarca.Enabled = false;
                }
                else
                {
                    CbxProduto.Enabled = false;
                    CbMarc.Enabled = true;
                }
            }
        }

        private void CbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcId = int.Parse(CbxMarca.SelectedValue.ToString());
        }

        private void CbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            prodId = int.Parse(CbxProduto.SelectedValue.ToString());
        }

        private void RbCompetencia_CheckedChanged(object sender, EventArgs e)
        {
            if (RbCompetencia.Checked)
            {
                opc = 1;
                MktPerInicio.Mask = "00/0000";
                MktPerFinal.Clear();
                MktPerFinal.Clear();
                MktPerInicio.Enabled = true;
                LblA.Visible = false;
                MktPerFinal.Visible = false;
                CbxMarca.Enabled = false;
                CbxProduto.Enabled = false;
                CbMarc.Checked = false;
                CbProd.Checked = false;
                CbProd.Enabled = true;
                CbMarc.Enabled = true;
            }
            MktPerInicio.Focus();
        }

        private void RbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbPeriodo.Checked)
            {
                opc = 2;
                MktPerInicio.Mask = "00/00/0000";
                MktPerInicio.Clear();
                MktPerFinal.Clear();
                MktPerInicio.Enabled = true;
                LblA.Visible = true;
                MktPerFinal.Visible = true;
                CbxMarca.Enabled = false;
                CbxProduto.Enabled = false;
                CbMarc.Checked = false;
                CbProd.Checked = false;
                CbProd.Enabled = true;
                CbMarc.Enabled = true;
            }
            MktPerInicio.Focus();
        }

        private void RbMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (RbMarca.Checked)
            {
                opc = 3;
                MktPerInicio.Mask = "00/0000";
                MktPerFinal.Clear();
                MktPerFinal.Clear();
                MktPerInicio.Enabled = false;
                LblA.Visible = false;
                MktPerFinal.Visible = false;
                CbxMarca.Enabled = true;
                CbxProduto.Enabled = false;
                CbMarc.Checked = false;
                CbProd.Checked = false;
                CbProd.Enabled = false;
                CbMarc.Enabled = false;
            }
        }

        private void RbProduto_CheckedChanged(object sender, EventArgs e)
        {
            if (RbProduto.Checked)
            {
                opc = 4;
                MktPerInicio.Mask = "00/0000";
                MktPerFinal.Clear();
                MktPerFinal.Clear();
                MktPerInicio.Enabled = false;
                LblA.Visible = false;
                MktPerFinal.Visible = false;
                CbxMarca.Enabled = false;
                CbxProduto.Enabled = true;
                CbMarc.Checked = false;
                CbProd.Checked = false;
                CbProd.Enabled = false;
                CbMarc.Enabled = false;
            }
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            FrmRelVisualizar frmRelVisualizar = new FrmRelVisualizar();
            frmRelVisualizar.Show();
        }

        private void Verificacao()
        {
            if (RbCompetencia.Checked || RbPeriodo.Checked)
            {
                if (CbMarc.Checked)
                {
                    CbxMarca.Enabled = true;
                    CbProd.Enabled = false;
                    CbxProduto.Enabled = false;
                }
                else
                {
                    CbxMarca.Enabled = false;
                    CbProd.Enabled = true;
                }
            }

        }

        private void CompetenciaAtiva()
        {
            negCompConsulta = new NegCompConsulta();
            try
            {
                MktPerInicio.Text = negCompConsulta.CompetenciaAtiva().ToString("MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ListarMarcas()
        {
            negMarcConsulta = new NegMarcConsulta();

            try
            {
                CbxMarca.DataSource = negMarcConsulta.ListaMarcaAtiva();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ListarProdutos()
        {
            negProdConsulta = new NegProdConsulta();

            try
            {
                CbxProduto.DataSource = negProdConsulta.ListaProdutoAtivo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
