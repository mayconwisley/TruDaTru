using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.Produto
{
    public class NegProdConsulta
    {
        StringBuilder strSQL;
        BDCrud crud;
        DataTable lista;

        public DataTable ListaProduto()
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT P.Id, P.Descricao, P.Ativo, P.Id_Marca, M.Descricao ");
            strSQL.Append("FROM Produto P ");
            strSQL.Append("INNER JOIN Marca M ON P.Id_Marca = M.Id ");
            strSQL.Append("ORDER BY P.Descricao");

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

        public DataTable PesquisaProduto(string pesquisa)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT P.Id, P.Descricao, P.Ativo, P.Id_Marca, M.Descricao ");
            strSQL.Append("FROM Produto P ");
            strSQL.Append("INNER JOIN Marca M ON P.Id_Marca = M.Id ");
            strSQL.Append("WHERE UPPER(P.Descricao) LIKE UPPER(@pesquisa) ");
            strSQL.Append("ORDER BY P.Descricao");

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
