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
    }
}
