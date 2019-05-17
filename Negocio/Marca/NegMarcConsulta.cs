using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.Marca
{
    public class NegMarcConsulta
    {
        StringBuilder strSQL;
        BDCrud crud;
        DataTable lista;

        public DataTable ListaMarca()
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT Id, Descricao, Ativo ");
            strSQL.Append("FROM Marca ");
            strSQL.Append("ORDER BY Descricao");

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

        public DataTable PesquisaMarca(string pesquisa)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT Id, Descricao, Ativo ");
            strSQL.Append("FROM Marca ");
            strSQL.Append("WHERE UPPER(Descricao) LIKE UPPER(@pesquisa) ");
            strSQL.Append("ORDER BY Descricao");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("pesquisa", pesquisa);
                return lista = crud.Consulta(CommandType.Text, strSQL.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
