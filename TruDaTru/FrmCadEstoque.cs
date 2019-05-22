using Modelo;
using Negocio.Competencia;
using Negocio.Estoque;
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

        NegEstInserir negEstInserir;
        NegEstAtualizar negEstAtualizar;
        NegEstExcluir negEstExcluir;
        NegEstConsulta negEstConsulta;

        NegCompConsulta negCompConsulta;

        NegProdConsulta negProdConsulta;
        #endregion

        #region Variaveis
        char tipoES;
        int qtdProduto = 0, prodId = 0, CompId = 0;
        decimal vlrProduto;
        DateTime dtCompetencia;
        #endregion


        private void CompetenciaAtiva()
        {
            negCompConsulta = new NegCompConsulta();
            try
            {
                dtCompetencia = negCompConsulta.CompetenciaAtiva();
                LblCompetencia.Text = dtCompetencia.ToString("MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ListaProduto()
        {

        }
    }
}
