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
        }

        public FrmRelatorio()
        {
            InitializeComponent();
        }


        private void CompetenciaAtiva()
        {
            negCompConsulta = new NegCompConsulta();
            try
            {
                MktDataInicial.Text = negCompConsulta.CompetenciaAtiva().ToString("MM/yyyy");
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
