using BancoDados;
using Modelo;
using System;
using System.Data;
using System.Text;

namespace Negocio.Estoque
{
    public class NegEstInserir
    {
        StringBuilder strSQL;
        BDCrud crud;
        public bool Inserir(ModEstoque estoque)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();

            strSQL.Append("INSERT INTO Estoque (Tipo_ES, Data_Cadastro, Qtd_Produto, Valor_Unitario, Id_Produto, Id_Competencia) ");
            strSQL.Append("VALUES(@Tipo_ES, @Data_Cadastro, @Qtd_Produto, @Valor_Unitario, @Id_Produto, @Id_Competencia)");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Tipo_ES", estoque.TipoES);
                crud.AdicionarParametro("Data_Cadastro", estoque.DataCadastro);
                crud.AdicionarParametro("Qtd_Produto", estoque.QtdProduto);
                crud.AdicionarParametro("Valor_Unitario", estoque.ValorProduto);
                crud.AdicionarParametro("Id_Produto", estoque.Produto.Id);
                crud.AdicionarParametro("Id_Competencia", estoque.Competencia.Id);
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
