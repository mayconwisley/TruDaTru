using BancoDados;
using Modelo;
using System;
using System.Data;
using System.Text;

namespace Negocio.Produto
{
    public class NegProdInserir
    {
        StringBuilder strSQL;
        BDCrud crud;
        public bool Inserir(ModProduto produto)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();

            strSQL.Append("INSERT INTO Produto (Descricao, Ativo, Id_Marca) ");
            strSQL.Append("VALUES(@Descricao, @Ativo, @Id_Marca)");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Descricao", produto.Descricao);
                crud.AdicionarParametro("Ativo", produto.Ativo);
                crud.AdicionarParametro("Id_Marca", produto.Marca.Id);
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
