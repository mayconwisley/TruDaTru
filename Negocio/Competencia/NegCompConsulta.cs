using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.Competencia
{
    public class NegCompConsulta
    {
        StringBuilder strSQL;
        BDCrud crud;
        DataTable lista;

        public DataTable ListaCompetencia()
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT Id, Data_Competencia, Ativo ");
            strSQL.Append("FROM Competencia ");
            strSQL.Append("ORDER BY Data_Competencia DESC");

            try
            {
                crud.LimparParametros();
                return lista = crud.Consulta(CommandType.Text, strSQL.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Id(DateTime competencia)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            int id;
            strSQL.Append("SELECT Id ");
            strSQL.Append("FROM Competencia ");
            strSQL.Append("WHERE Data_Competencia = @Data_Competencia");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Data_Competencia", competencia);
                id = int.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DateTime Competencia(int compId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            DateTime competencia;

            strSQL.Append("SELECT Data_Competencia ");
            strSQL.Append("FROM Competencia ");
            strSQL.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id", compId);
                competencia = DateTime.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                return competencia;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DateTime CompetenciaAtiva()
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            DateTime competencia;

            strSQL.Append("SELECT Data_Competencia ");
            strSQL.Append("FROM Competencia ");
            strSQL.Append("WHERE Ativo = 'S'");

            try
            {
                crud.LimparParametros();
                competencia = DateTime.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                return competencia;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int CompetenciaQtdAtiva()
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            int competenciaQtd;

            strSQL.Append("SELECT COUNT(*) ");
            strSQL.Append("FROM Competencia ");
            strSQL.Append("WHERE Ativo = 'S'");

            try
            {
                crud.LimparParametros();
                competenciaQtd = int.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                return competenciaQtd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public char Status(int compId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            char status;
            strSQL.Append("SELECT Ativo ");
            strSQL.Append("FROM Competencia ");
            strSQL.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id", compId);
                status = char.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                return status;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
