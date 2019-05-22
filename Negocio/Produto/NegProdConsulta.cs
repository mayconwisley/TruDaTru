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

        public DataTable PesquisaProduto(string pesquisa, int marcaId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT P.Id, P.Descricao, P.Ativo, P.Id_Marca, M.Descricao AS MarcaDescricao ");
            strSQL.Append("FROM Produto P ");
            strSQL.Append("INNER JOIN Marca M ON P.Id_Marca = M.Id ");
            strSQL.Append("WHERE UPPER(P.Descricao) LIKE UPPER(@pesquisa) AND ");
            strSQL.Append("M.Id = @marcaId ");
            strSQL.Append("ORDER BY UPPER(P.Descricao)");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("pesquisa", pesquisa);
                crud.AdicionarParametro("marcaId", marcaId);
                return lista = crud.Consulta(CommandType.Text, strSQL.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
