using Negocio.Competencia;
using Negocio.Estoque;
using Negocio.Marca;
using Negocio.Produto;
using System;
using System.Diagnostics;
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
        private void Informacao(int intOpc)
        {
            decimal decValorEntrada = 0, decValorSaida = 0, decValorTotal = 0;

            negEstConsulta = new NegEstConsulta();
            try
            {
                switch (intOpc)
                {
                    case 1: //Competencia;

                        if (CbProd.Checked == true && CbMarc.Checked == false)
                        {
                            decValorEntrada = NegEstCalculo.TotalEntradaCompProduto(compId, prodId);
                            decValorSaida = NegEstCalculo.TotalSaidaCompProduto(compId, prodId);
                        }
                        else if (CbProd.Checked == false && CbMarc.Checked == true)
                        {
                            decValorEntrada = NegEstCalculo.TotalEntradaCompMarca(compId, marcId);
                            decValorSaida = NegEstCalculo.TotalSaidaCompMarca(compId, marcId);
                        }
                        else if (CbProd.Checked == false && CbMarc.Checked == false)
                        {
                            decValorEntrada = NegEstCalculo.TotalEntradaCompetencia(compId);
                            decValorSaida = NegEstCalculo.TotalSaidaCompetencia(compId);
                        }
                        break;
                    case 2://Periodos
                        if (CbProd.Checked == true && CbMarc.Checked == false)
                        {
                            decValorEntrada = NegEstCalculo.TotalEntradaPerProduto(dtPerInicio, dtPerFinal, prodId);
                            decValorSaida = NegEstCalculo.TotalSaidaPerProduto(dtPerInicio, dtPerFinal, prodId);
                        }
                        else if (CbProd.Checked == false && CbMarc.Checked == true)
                        {
                            decValorEntrada = NegEstCalculo.TotalEntradaPerMarca(dtPerInicio, dtPerFinal, marcId);
                            decValorSaida = NegEstCalculo.TotalSaidaPerMarca(dtPerInicio, dtPerFinal, marcId);
                        }
                        else if (CbProd.Checked == false && CbMarc.Checked == false)
                        {
                            decValorEntrada = NegEstCalculo.TotalEntradaPeriodo(dtPerInicio, dtPerFinal);
                            decValorSaida = NegEstCalculo.TotalSaidaPeriodo(dtPerInicio, dtPerFinal);
                        }
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
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
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
                        if (CbProd.Checked == true && CbMarc.Checked == false)
                        {
                            DgvListaProduto.DataSource = negEstConsulta.ListaEstoqueCompProduto(compId, prodId);
                        }
                        else if (CbProd.Checked == false && CbMarc.Checked == true)
                        {
                            DgvListaProduto.DataSource = negEstConsulta.ListaEstoqueCompMarca(compId, marcId);
                        }
                        else if (CbProd.Checked == false && CbMarc.Checked == false)
                        {
                            DgvListaProduto.DataSource = negEstConsulta.ListaEstoqueCompetencia(compId,"%%");
                        }
                        break;
                    case 2: //Periodos
                        if (CbProd.Checked == true && CbMarc.Checked == false)
                        {
                            DgvListaProduto.DataSource = negEstConsulta.ListaEstoquePeriodoProd(dtPerInicio, dtPerFinal, prodId);
                        }
                        else if (CbProd.Checked == false && CbMarc.Checked == true)
                        {
                            DgvListaProduto.DataSource = negEstConsulta.ListaEstoquePeriodoMarc(dtPerInicio, dtPerFinal, marcId);
                        }
                        else if (CbProd.Checked == false && CbMarc.Checked == false)
                        {
                            DgvListaProduto.DataSource = negEstConsulta.ListaEstoquePeriodo(dtPerInicio, dtPerFinal);
                        }
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
            CompetenciaAtiva();
            Verificacao();
        }
    }
}
