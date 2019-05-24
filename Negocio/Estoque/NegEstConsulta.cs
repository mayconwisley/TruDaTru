using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.Estoque
{
    public class NegEstConsulta
    {
        StringBuilder strSQL;
        BDCrud crud;
        DataTable lista;

        public DataTable ListaEstoque()
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT VW.Id_Estoque, VW.Id_Competecia, VW.Id_Marca, VW.Id_Produto, " +
                          "VW.Competencia, VW.Marca, VW.Produto, VW.Tipo_Es, VW.Data_Cadastro, " +
                          "VW.Qtd_Produto, VW.Valor_Unitario, VW.Valor_Total ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("ORDER BY VW.Data_Cadastro DESC");

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

        public DataTable ListaEstoqueCompetencia(int compId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT VW.Id_Estoque, VW.Id_Competecia, VW.Id_Marca, VW.Id_Produto, " +
                          "VW.Competencia, VW.Marca, VW.Produto, VW.Tipo_Es, VW.Data_Cadastro, " +
                          "VW.Qtd_Produto, VW.Valor_Unitario, VW.Valor_Total ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Id_Competecia = @Id_Competecia ");
            strSQL.Append("ORDER BY VW.Data_Cadastro DESC, " +
                          "UPPER(VW.Produto) ASC");


            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id_Competecia", compId);
                return lista = crud.Consulta(CommandType.Text, strSQL.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public DataTable PesquisaMarca(string pesquisa)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();


            strSQL.Append("SELECT VW.Id_Estoque, VW.Id_Competecia, VW.Id_Marca, VW.Id_Produto, " +
                          "VW.Competencia, VW.Marca, VW.Produto, VW.Tipo_Es, VW.Data_Cadastro, " +
                          "VW.Qtd_Produto, VW.Valor_Unitario, VW.Valor_Total ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE UPPER(VW.Produto) LIKE UPPER(@pesquisa) ");
            strSQL.Append("ORDER BY VW.Data_Cadastro DESC");

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
