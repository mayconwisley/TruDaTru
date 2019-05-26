using Negocio.Competencia;
using Negocio.Estoque;
using Negocio.Marca;
using Negocio.Produto;
using System;
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
    public partial class FrmConEstoque : Form
    {
        public FrmConEstoque()
        {
            InitializeComponent();
        }


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

        private void Informacao(int intOpc)
        {
            decimal decValorEntrada = 0, decValorSaida = 0, decValorTotal = 0;

            negEstConsulta = new NegEstConsulta();
            try
            {
                switch (intOpc)
                {
                    case 1: //Competencia;
                        decValorEntrada = NegEstCalculo.TotalEntradaCompetencia(compId);
                        decValorSaida = NegEstCalculo.TotalSaidaCompetencia(compId);
                        break;
                    case 2: //Periodos
                        decValorEntrada = NegEstCalculo.TotalEntradaPeriodo(dtPerInicio, dtPerFinal);
                        decValorSaida = NegEstCalculo.TotalSaidaPeriodo(dtPerInicio, dtPerFinal);
                        break;
                    case 3: //Marca
                        decValorEntrada = NegEstCalculo.TotalEntradaMarca(marcId);
                        decValorSaida = NegEstCalculo.TotalSaidaMarca(marcId);
                        break;
                    case 4: // Produto
                        decValorEntrada = NegEstCalculo.TotalEntradaProduto(prodId);
                        decValorSaida = NegEstCalculo.TotalSaidaProduto(prodId);
                        break;
                    default:
                        break;
                }

                decValorTotal = decValorEntrada - decValorSaida;

                Lblinfo.Text = "Valores\n" +
                               "Total Entrada: " + decValorEntrada.ToString("#,##0.00") + "\n" +
                               "Total Saída..: " + decValorSaida.ToString("#,##0.00") + "\n\n" +
                               "Total Geral..: " + decValorTotal.ToString("#,##0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MktPerInicio.Focus();
                MktPerInicio.Enabled = true;
                LblA.Visible = false;
                MktPerFinal.Visible = false;
                CbxMarca.Enabled = false;
                CbxProduto.Enabled = false;
            }
        }

        private void RbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbPeriodo.Checked)
            {
                opc = 2;
                MktPerInicio.Mask = "00/00/0000";
                MktPerInicio.Clear();
                MktPerFinal.Clear();
                MktPerInicio.Focus();
                MktPerInicio.Enabled = true;
                LblA.Visible = true;
                MktPerFinal.Visible = true;
                CbxMarca.Enabled = false;
                CbxProduto.Enabled = false;
            }
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
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            negCompConsulta = new NegCompConsulta();

            try
            {
                if (RbCompetencia.Checked)
                {
                    dtPerInicio = DateTime.Parse(MktPerInicio.Text);
                    compId = negCompConsulta.Id(dtPerInicio);
                    if (compId == 0)
                    {
                        MessageBox.Show("Competência não cadastrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (RbPeriodo.Checked)
                {
                    dtPerInicio = DateTime.Parse(MktPerInicio.Text);
                    dtPerFinal = DateTime.Parse(MktPerFinal.Text);
                }
                ListarConsulta(opc);
                Informacao(opc);
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

        private void ListarConsulta(int intOpc)
        {
            negEstConsulta = new NegEstConsulta();
            try
            {
                switch (intOpc)
                {
                    case 1: //Competencia;
                        DgvListaProduto.DataSource = negEstConsulta.ListaEstoqueCompetencia(compId);
                        break;
                    case 2: //Periodos
                        DgvListaProduto.DataSource = negEstConsulta.ListaEstoquePeriodo(dtPerInicio, dtPerFinal);
                        break;
                    case 3: //Marca
                        DgvListaProduto.DataSource = negEstConsulta.ListaEstoqueMarca(marcId);
                        break;
                    case 4: // Produto
                        DgvListaProduto.DataSource = negEstConsulta.ListaEstoqueProduto(prodId);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmConEstoque_Load(object sender, EventArgs e)
        {
            ListarMarcas();
            ListarProdutos();
        }
    }
}
