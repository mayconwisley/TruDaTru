using Modelo;
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
    public partial class FrmCadEstoque : Form
    {
        public FrmCadEstoque()
        {
            InitializeComponent();
        }
        #region Modelo e Negocio
        ModCompetencia modCompetencia;
        ModProduto modProduto;
        ModEstoque modEstoque;

        NegEstInserir negEstInserir;
        NegEstAtualizar negEstAtualizar;
        NegEstExcluir negEstExcluir;
        NegEstConsulta negEstConsulta;

        NegCompConsulta negCompConsulta;

        NegProdConsulta negProdConsulta;

        NegMarcConsulta negMarcConsulta;
        #endregion

        #region Variaveis
        char tipoES;
        int qtdProduto = 0, prodId = 0, CompId = 0, estId = 0, marcId = 0;
        decimal vlrProduto;
        string strPesquisa;
        DateTime dtCompetencia;
        #endregion
        private void CompetenciaAtiva()
        {
            negCompConsulta = new NegCompConsulta();
            try
            {
                dtCompetencia = negCompConsulta.CompetenciaAtiva();
                CompId = negCompConsulta.Id(dtCompetencia);
                LblCompetencia.Text = "Competência: " + dtCompetencia.ToString("MM/yyyy");
                MktDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ListaProdutoAtivo()
        {
            negEstConsulta = new NegEstConsulta();
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

        private void ListaEstoqueCompetencia(int compId)
        {
            negEstConsulta = new NegEstConsulta();
            try
            {
                DgvListaProduto.DataSource = negEstConsulta.ListaEstoqueCompetencia(compId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BotoesReset()
        {
            BtnGravar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            TxtQuantidade.Text = "0";
            TxtValor.Text = "0,00";
            TxtValorTotal.Text = "0,00";

        }

        private void BotoesAlterarExcluir()
        {
            BtnGravar.Enabled = false;
            BtnAlterar.Enabled = true;
            BtnExcluir.Enabled = true;
        }


        private void Integracao(ModInteracao.Interacao interacao)
        {
            negEstInserir = new NegEstInserir();
            negEstAtualizar = new NegEstAtualizar();
            negEstExcluir = new NegEstExcluir();

            modCompetencia = new ModCompetencia();
            modProduto = new ModProduto();
            modEstoque = new ModEstoque();

            if (CbxTipo.SelectedIndex == 0)
            {
                tipoES = 'E';
            }
            else
            {
                tipoES = 'S';
            }


            try
            {
                modEstoque.Id = estId;
                modEstoque.DataCadastro = DateTime.Parse(MktDataCadastro.Text);
                modEstoque.TipoES = tipoES;
                modEstoque.QtdProduto = int.Parse(TxtQuantidade.Text.Trim());
                modEstoque.ValorProduto = decimal.Parse(TxtValor.Text);
                modEstoque.Competencia = new ModCompetencia();
                modEstoque.Competencia.Id = CompId;
                modEstoque.Produto = new ModProduto();
                modEstoque.Produto.Id = prodId;

                switch (interacao)
                {
                    case ModInteracao.Interacao.Gravar:
                        negEstInserir.Inserir(modEstoque);
                        break;
                    case ModInteracao.Interacao.Alterar:
                        negEstAtualizar.Atualizar(modEstoque);
                        break;
                    case ModInteracao.Interacao.Excluir:
                        negEstExcluir.Excluir(modEstoque);
                        break;
                    default:
                        break;
                }
                BotoesReset();
                ListaEstoqueCompetencia(CompId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Integracao(ModInteracao.Interacao.Gravar);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Integracao(ModInteracao.Interacao.Alterar);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Integracao(ModInteracao.Interacao.Excluir);
        }

        private void DgvListaProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                estId = int.Parse(DgvListaProduto.Rows[e.RowIndex].Cells["Id_Estoque"].Value.ToString());
                prodId = int.Parse(DgvListaProduto.Rows[e.RowIndex].Cells["Id_Produto"].Value.ToString());
                CompId = int.Parse(DgvListaProduto.Rows[e.RowIndex].Cells["Id_Competecia"].Value.ToString());
                marcId = int.Parse(DgvListaProduto.Rows[e.RowIndex].Cells["Id_Marca"].Value.ToString());

                MktDataCadastro.Text = DgvListaProduto.Rows[e.RowIndex].Cells["Data_Cadastro"].Value.ToString();
                tipoES = char.Parse(DgvListaProduto.Rows[e.RowIndex].Cells["Tipo_Es"].Value.ToString());

                TxtQuantidade.Text = DgvListaProduto.Rows[e.RowIndex].Cells["Qtd_Produto"].Value.ToString();
                TxtValor.Text = DgvListaProduto.Rows[e.RowIndex].Cells["Valor_Unitario"].Value.ToString();
                TxtValorTotal.Text = DgvListaProduto.Rows[e.RowIndex].Cells["Valor_Total"].Value.ToString();

                CbxProduto.SelectedValue = prodId;

                BotoesAlterarExcluir();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                prodId = int.Parse(CbxProduto.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCadEstoque_Load(object sender, EventArgs e)
        {
            CompetenciaAtiva();
            ListaProdutoAtivo();
            ListaEstoqueCompetencia(CompId);
        }
    }
}
