using Modelo;
using Negocio.Competencia;
using System;
using System.Windows.Forms;
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
                modCompetencia.Competencia = DateTime.Parse(MktCompetencia.Text);
                switch (interacao)
                {
                    case ModInteracao.Interacao.Gravar:
                        FecharAbrirCompAtiva('N');
                        modCompetencia.Ativo = compAtivo;
                        negCompInserir.Inserir(modCompetencia);
                        break;
                    case ModInteracao.Interacao.Alterar:
                        FecharAbrirCompAtiva('N');
                        modCompetencia.Id = compId;
                        modCompetencia.Ativo = compAtivo;
                        negCompAtualizar.Atualizar(modCompetencia);
                        break;
                    case ModInteracao.Interacao.Excluir:
                        modCompetencia.Id = compId;
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

        private void FecharAbrirCompAtiva(char chAtivo)
        {
            negCompConsulta = new NegCompConsulta();
            negCompAtualizar = new NegCompAtualizar();

            dtCompetencia = new DateTime();
            try
            {
                dtCompetencia = negCompConsulta.CompetenciaAtiva();

                if (dtCompetencia != new DateTime())
                {
                    compIdAtivo = negCompConsulta.Id(dtCompetencia);
                    modCompetencia.Id = compIdAtivo;
                    modCompetencia.Ativo = chAtivo;
                    negCompAtualizar.AtualizarStatus(modCompetencia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /* Não esta sendo utilizada
        private bool VerificaCompAtiva()
        {
            negCompConsulta = new NegCompConsulta();
            try
            {
                if (negCompConsulta.CompetenciaQtdAtiva() > 0)
                {
                    MessageBox.Show("Não é possível ATIVAR competência\n" +
                                    "quando já houver uma competência ativa.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }*/

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
