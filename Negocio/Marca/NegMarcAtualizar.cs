using BancoDados;
using Modelo;
using System;
using System.Data;
using System.Text;

namespace Negocio.Marca
{
    public class NegMarcAtualizar
    {
        StringBuilder strSQL;
        BDCrud crud;

        public bool Atualizar(ModMarca marca)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();

            strSQL.Append("UPDATE Marca ");
            strSQL.Append("SET Descricao = @Descricao, Ativo = @Ativo ");
            strSQL.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Descricao", marca.Descricao);
                crud.AdicionarParametro("Ativo", marca.Ativo);
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
