using BancoDados;
using Modelo;
using System;
using System.Data;
using System.Text;

namespace Negocio.Produto
{
    public class NegProdExcluir
    {
        StringBuilder strSQL;
        BDCrud crud;

        public bool Excluir(ModProduto produto)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();

            strSQL.Append("DELETE FROM Produto ");
            strSQL.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id", produto.Id);
                crud.Executar(CommandType.Text, strSQL.ToString());
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
