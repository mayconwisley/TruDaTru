using BancoDados;
using Modelo;
using System;
using System.Data;
using System.Text;

namespace Negocio.Estoque
{
    public class NegEstExcluir
    {
        StringBuilder strSQL;
        BDCrud crud;

        public bool Excluir(ModEstoque estoque)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();

            strSQL.Append("DELETE FROM Estoque ");
            strSQL.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id", estoque.Id);
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
