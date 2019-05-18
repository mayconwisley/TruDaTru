using BancoDados;
using Modelo;
using System;
using System.Data;
using System.Text;

namespace Negocio.Estoque
{
    public class NegEstAtualizar
    {
        StringBuilder strSQL;
        BDCrud crud;

        public bool Atualizar(ModEstoque estoque)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();

            strSQL.Append("UPDATE Estoque ");
            strSQL.Append("SET Tipo_ES = @Tipo_ES, Data_Cadastro = @Data_Cadastro, Qtd_Produto = @Qtd_Produto, " +
                          "Valor_Unitario = @Valor_Unitario, Id_Produto = @Id_Produto ");
            strSQL.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Tipo_ES", estoque.TipoES);
                crud.AdicionarParametro("Data_Cadastro", estoque.DataCadastro);
                crud.AdicionarParametro("Qtd_Produto", estoque.QtdProduto);
                crud.AdicionarParametro("Valor_Unitario", estoque.ValorProduto);
                crud.AdicionarParametro("Id_Produto", estoque.Produto.Id);
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
