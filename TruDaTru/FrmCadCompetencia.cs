using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Negocio.Competencia;
namespace TruDaTru
{
    public partial class FrmCadCompetencia : Form
    {
        public FrmCadCompetencia()
        {
            InitializeComponent();
        }

        #region Modelo e Negocio
        ModCompetencia modCompetencia;

        NegCompInserir negCompInserir;
        NegCompAtualizar negCompAtualizar;
        NegCompExcluir negCompExcluir;
        NegCompConsulta negCompConsulta;
        #endregion

        #region Variaveis
        char compAtivo = 'N';
        int compId = 0, compIdAtivo = 0;
        DateTime dtCompetencia;
        #endregion

        private void BotoesReset()
        {
            BtnGravar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            MktCompetencia.Clear();
        }

        private void BotoesAlterarExcluir()
        {
            BtnGravar.Enabled = false;
            BtnAlterar.Enabled = true;
            BtnExcluir.Enabled = true;
        }

        private void Interacao(ModInteracao.Interacao interacao)
        {
            negCompInserir = new NegCompInserir();
            negCompAtualizar = new NegCompAtualizar();
            negCompExcluir = new NegCompExcluir();

            modCompetencia = new ModCompetencia();

            if (CbAtivo.Checked)
            {
                compAtivo = 'S';
            }
            else
            {
                compAtivo = 'N';
            }

            try
            {
                modCompetencia.Id = compId;
                modCompetencia.Competencia = DateTime.Parse(MktCompetencia.Text);
                modCompetencia.Ativo = compAtivo;

                switch (interacao)
                {
                    case ModInteracao.Interacao.Gravar:
                        negCompInserir.Inserir(modCompetencia);
                        FecharCompAtiva();
                        break;
                    case ModInteracao.Interacao.Alterar:
                        if (!VerificaCompAtiva())
                        {
                            negCompAtualizar.Atualizar(modCompetencia);
                        }
                        break;
                    case ModInteracao.Interacao.Excluir:
                        negCompExcluir.Excluir(modCompetencia);
                        break;
                    default:
                        MessageBox.Show("Comando Inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                ListarCompetencia();
                BotoesReset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarCompetencia()
        {
            negCompConsulta = new NegCompConsulta();
            try
            {
                DgvListaCompetencia.DataSource = negCompConsulta.ListaCompetencia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FecharCompAtiva()
        {
            negCompConsulta = new NegCompConsulta();
            negCompAtualizar = new NegCompAtualizar();

            modCompetencia = new ModCompetencia();

            dtCompetencia = new DateTime();
            try
            {
                dtCompetencia = negCompConsulta.CompetenciaAtiva();
                compIdAtivo = negCompConsulta.Id(dtCompetencia);

                modCompetencia.Id = compIdAtivo;
                modCompetencia.Ativo = 'N';

                negCompAtualizar.AtualizarStatus(modCompetencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool VerificaCompAtiva()
        {
            negCompConsulta = new NegCompConsulta();
            try
            {
                if (negCompConsulta.CompetenciaQtdAtiva() > 0)
                {
                    MessageBox.Show("Não é possível ATIVAR competência!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void CbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (CbAtivo.Checked)
            {
                compAtivo = 'S';
            }
            else
            {
                compAtivo = 'N';
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

        private void FrmCadCompetencia_Load(object sender, EventArgs e)
        {
            ListarCompetencia();
        }

        private void DgvListaCompetencia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime competencia;
            char chAtivo;
            try
            {
                compId = int.Parse(DgvListaCompetencia.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                competencia = DateTime.Parse(DgvListaCompetencia.Rows[e.RowIndex].Cells["Data_Competencia"].Value.ToString());
                chAtivo = char.Parse(DgvListaCompetencia.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());
                if (chAtivo == 'S')
                {
                    CbAtivo.Checked = true;
                }
                else
                {
                    CbAtivo.Checked = false;
                }
                MktCompetencia.Text = competencia.ToString("MM/yyyy");
                BotoesAlterarExcluir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
