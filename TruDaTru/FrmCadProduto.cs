using Modelo;
using Negocio.Marca;
using Negocio.Produto;
using System;
using System.Windows.Forms;

namespace TruDaTru
{
    public partial class FrmCadProduto : Form
    {
        public FrmCadProduto()
        {
            InitializeComponent();
        }

        #region Modelo e Negocio
        ModMarca modMarca;
        ModProduto modProduto;

        NegProdInserir negProdInserir;
        NegProdAtualizar negProdAtualizar;
        NegProdExcluir negProdExcluir;
        NegProdConsulta negProdConsulta;

        NegMarcConsulta negMarcConsulta;
        #endregion

        #region Variaveis
        char prodAtivo;
        int prodId = 0, marcaId = 0;
        string strProduto;
        #endregion
        private void BotoesReset()
        {
            BtnGravar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            TxtDescricao.Clear();
        }

        private void BotoesAlterarExcluir()
        {
            BtnGravar.Enabled = false;
            BtnAlterar.Enabled = true;
            BtnExcluir.Enabled = true;
        }

        private void ListaMarca()
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

        private void ListarProduto(string produto, int idMarca)
        {
            negProdConsulta = new NegProdConsulta();
            try
            {
                strProduto = "%" + produto + "%";
                marcaId = idMarca;

                DgvListaProduto.DataSource = negProdConsulta.PesquisaProduto(strProduto, marcaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                marcaId = int.Parse(CbxMarca.SelectedValue.ToString());
                ListarProduto(TxtPesquisa.Text.Trim(), marcaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Interacao(ModInteracao.Interacao.Gravar);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Interacao(ModInteracao.Interacao.Alterar);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Interacao(ModInteracao.Interacao.Excluir);
        }

        private void DgvListaProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                prodId = int.Parse(DgvListaProduto.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtDescricao.Text = DgvListaProduto.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                BotoesAlterarExcluir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            ListarProduto(TxtPesquisa.Text.Trim(), marcaId);
        }

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            ListaMarca();
        }

        private void Interacao(ModInteracao.Interacao interacao)
        {
            negProdInserir = new NegProdInserir();
            negProdAtualizar = new NegProdAtualizar();
            negProdExcluir = new NegProdExcluir();

            modMarca = new ModMarca();
            modProduto = new ModProduto();

            if (CbAtivo.Checked)
            {
                prodAtivo = 'S';
            }
            else
            {
                prodAtivo = 'N';
            }

            try
            {
                modProduto.Id = prodId;
                modProduto.Descricao = TxtDescricao.Text;
                modProduto.Ativo = prodAtivo;
                modProduto.Marca = new ModMarca();
                modProduto.Marca.Id = marcaId;

                switch (interacao)
                {
                    case ModInteracao.Interacao.Gravar:
                        negProdInserir.Inserir(modProduto);
                        break;
                    case ModInteracao.Interacao.Alterar:
                        negProdAtualizar.Atualizar(modProduto);
                        break;
                    case ModInteracao.Interacao.Excluir:
                        negProdExcluir.Excluir(modProduto);
                        break;
                    default:
                        MessageBox.Show("Função não cadastrada");
                        break;
                }
                BotoesReset();
                ListarProduto(strProduto, marcaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
