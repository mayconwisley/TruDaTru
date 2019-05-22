using Modelo;
using Negocio.Marca;
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
    public partial class FrmCadMarca : Form
    {
        public FrmCadMarca()
        {
            InitializeComponent();
        }

        #region Modelo e Negocio
        ModMarca modMarca;

        NegMarcInserir negMarcInserir;
        NegMarcAtualizar negMarcAtualizar;
        NegMarcExcluir negMarcExcluir;
        NegMarcConsulta negMarcConsulta;
        #endregion

        #region Variaveis
        char marcaAtivo = 'S';
        int marcaId = 0;
        string strPesquisa;
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
        /*Lista no grid as marcas conforme a pesquisa é feita*/
        private void ListaMarcas(string pesquisa)
        {
            negMarcConsulta = new NegMarcConsulta();
            try
            {
                strPesquisa = "%" + pesquisa + "%";
                DgwListaMarcas.DataSource = negMarcConsulta.PesquisaMarca(strPesquisa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Interacao(ModInteracao.Interacao interacao)
        {
            negMarcInserir = new NegMarcInserir();
            negMarcAtualizar = new NegMarcAtualizar();
            negMarcExcluir = new NegMarcExcluir();

            modMarca = new ModMarca();

            if (CbAtivo.Checked)
            {
                marcaAtivo = 'S';
            }
            else
            {
                marcaAtivo = 'N';
            }

            try
            {
                modMarca.Id = marcaId;
                modMarca.Descricao = TxtDescricao.Text.Trim();
                modMarca.Ativo = marcaAtivo;

                switch (interacao)
                {
                    case ModInteracao.Interacao.Gravar:
                        negMarcInserir.Inserir(modMarca);
                        break;
                    case ModInteracao.Interacao.Alterar:
                        negMarcAtualizar.Atualizar(modMarca);
                        break;
                    case ModInteracao.Interacao.Excluir:
                        negMarcExcluir.Excluir(modMarca);
                        break;
                    default:
                        MessageBox.Show("Função não cadastrada.");
                        break;
                }
                BotoesReset();
                ListaMarcas(strPesquisa);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {

            ListaMarcas(TxtPesquisa.Text.Trim());
        }

        private void FrmCadMarca_Load(object sender, EventArgs e)
        {
            ListaMarcas(TxtPesquisa.Text.Trim());
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

        private void DgwListaMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                marcaAtivo = new char();
                marcaId = int.Parse(DgwListaMarcas.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtDescricao.Text = DgwListaMarcas.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                marcaAtivo = char.Parse(DgwListaMarcas.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());

                if (marcaAtivo == 'S')
                {
                    CbAtivo.Checked = true;
                }
                else
                {
                    CbAtivo.Checked = false;
                }
                BotoesAlterarExcluir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
