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
        int compId = 0;
        #endregion


        private void Interacao(ModInteracao.Interacao interacao)
        {
            negCompInserir = new NegCompInserir();
            negCompAtualizar = new NegCompAtualizar();
            negCompExcluir = new NegCompExcluir();

            modCompetencia = new ModCompetencia();

            try
            {

                modCompetencia.Id = compId;
                modCompetencia.Competencia = DateTime.Parse(MktCompetencia.Text);
                modCompetencia.Ativo = compAtivo;

                switch (interacao)
                {
                    case ModInteracao.Interacao.Gravar:
                        negCompInserir.Inserir(modCompetencia);
                        break;
                    case ModInteracao.Interacao.Alterar:
                        negCompAtualizar.Atualizar(modCompetencia);
                        break;
                    case ModInteracao.Interacao.Excluir:
                        negCompExcluir.Excluir(modCompetencia);
                        break;
                    default:
                        MessageBox.Show("Comando Inválido", "Aviso", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        break;
                }
                ListarCompetencia();
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
    }
}
