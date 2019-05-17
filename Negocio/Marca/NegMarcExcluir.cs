using BancoDados;
using Modelo;
using System;
using System.Data;
using System.Text;

namespace Negocio.Marca
{
    public class NegMarcExcluir
    {
        StringBuilder strSQL;
        BDCrud crud;

        public bool Excluir(ModMarca marca)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();

            strSQL.Append("DELETE FROM Marca ");
            strSQL.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id", marca.Id);
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
