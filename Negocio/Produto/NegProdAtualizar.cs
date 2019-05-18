using BancoDados;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Produto
{
    public class NegProdAtualizar
    {
        StringBuilder strSQL;
        BDCrud crud;

        public bool Atualizar(ModProduto produto)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();

            strSQL.Append("UPDATE Produto ");
            strSQL.Append("SET Descricao = @Descricao, Ativo = @Ativo, Id_Marca = @Id_Marca ");
            strSQL.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Descricao", produto.Descricao);
                crud.AdicionarParametro("Ativo", produto.Ativo);
                crud.AdicionarParametro("Id_Marca", produto.Marca.Id);
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
