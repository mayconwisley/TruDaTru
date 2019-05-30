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
                          "VW.Competencia, VW.Marca, VW.Produto, IIF(VW.Tipo_Es = 'E', 'Entrada','Saída') AS Tipo_ES, VW.Data_Cadastro, " +
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
        public DataTable ListaEstoqueCompetencia(int compId, string pesquisa)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT VW.Id_Estoque, VW.Id_Competecia, VW.Id_Marca, VW.Id_Produto, " +
                          "VW.Competencia, VW.Marca, VW.Produto, IIF(VW.Tipo_Es = 'E', 'Entrada','Saída') AS Tipo_ES, VW.Data_Cadastro, " +
                          "VW.Qtd_Produto, VW.Valor_Unitario, VW.Valor_Total ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE (VW.Id_Competecia = @Id_Competecia) AND " +
                          "(UPPER(VW.Produto) LIKE UPPER(@pesquisa) OR UPPER(VW.Marca) LIKE UPPER(@pesquisa)) ");
            strSQL.Append("ORDER BY VW.Data_Cadastro DESC, " +
                          "UPPER(VW.Produto) ASC");


            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id_Competecia", compId);
                crud.AdicionarParametro("pesquisa", pesquisa);
                return lista = crud.Consulta(CommandType.Text, strSQL.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListaEstoqueCompMarca(int compId, int marcId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT VW.Id_Estoque, VW.Id_Competecia, VW.Id_Marca, VW.Id_Produto, " +
                          "VW.Competencia, VW.Marca, VW.Produto, IIF(VW.Tipo_Es = 'E', 'Entrada','Saída') AS Tipo_ES, VW.Data_Cadastro, " +
                          "VW.Qtd_Produto, VW.Valor_Unitario, VW.Valor_Total ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Id_Competecia = @Id_Competecia AND VW.Id_Marca = @Id_Marca ");
            strSQL.Append("ORDER BY VW.Data_Cadastro DESC, " +
                          "UPPER(VW.Produto) ASC");


            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id_Competecia", compId);
                crud.AdicionarParametro("Id_Marca", marcId);
                return lista = crud.Consulta(CommandType.Text, strSQL.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListaEstoqueCompProduto(int compId, int prodId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT VW.Id_Estoque, VW.Id_Competecia, VW.Id_Marca, VW.Id_Produto, " +
                          "VW.Competencia, VW.Marca, VW.Produto, IIF(VW.Tipo_Es = 'E', 'Entrada','Saída') AS Tipo_ES, VW.Data_Cadastro, " +
                          "VW.Qtd_Produto, VW.Valor_Unitario, VW.Valor_Total ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Id_Competecia = @Id_Competecia AND VW.Id_Produto = @Id_Produto ");
            strSQL.Append("ORDER BY VW.Data_Cadastro DESC, " +
                          "UPPER(VW.Produto) ASC");


            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id_Competecia", compId);
                crud.AdicionarParametro("Id_Produto", prodId);
                return lista = crud.Consulta(CommandType.Text, strSQL.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListaEstoquePeriodo(DateTime dataInicio, DateTime dataFinal)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT VW.Id_Estoque, VW.Id_Competecia, VW.Id_Marca, VW.Id_Produto, " +
                          "VW.Competencia, VW.Marca, VW.Produto, IIF(VW.Tipo_Es = 'E', 'Entrada','Saída') AS Tipo_ES, VW.Data_Cadastro, " +
                          "VW.Qtd_Produto, VW.Valor_Unitario, VW.Valor_Total ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Data_Cadastro BETWEEN @dataInicio AND @dataFinal ");
            strSQL.Append("ORDER BY VW.Data_Cadastro DESC, " +
                          "UPPER(VW.Produto) ASC");


            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("dataInicio", dataInicio);
                crud.AdicionarParametro("dataFinal", dataFinal);
                return lista = crud.Consulta(CommandType.Text, strSQL.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListaEstoquePeriodoMarc(DateTime dataInicio, DateTime dataFinal, int marcId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT VW.Id_Estoque, VW.Id_Competecia, VW.Id_Marca, VW.Id_Produto, " +
                          "VW.Competencia, VW.Marca, VW.Produto, IIF(VW.Tipo_Es = 'E', 'Entrada','Saída') AS Tipo_ES, VW.Data_Cadastro, " +
                          "VW.Qtd_Produto, VW.Valor_Unitario, VW.Valor_Total ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Data_Cadastro BETWEEN @dataInicio AND @dataFinal AND VW.Id_Marca = @Id_Marca ");
            strSQL.Append("ORDER BY VW.Data_Cadastro DESC, " +
                          "UPPER(VW.Produto) ASC");


            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("dataInicio", dataInicio);
                crud.AdicionarParametro("dataFinal", dataFinal);
                crud.AdicionarParametro("Id_Marca", marcId);
                return lista = crud.Consulta(CommandType.Text, strSQL.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListaEstoquePeriodoProd(DateTime dataInicio, DateTime dataFinal, int prodId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT VW.Id_Estoque, VW.Id_Competecia, VW.Id_Marca, VW.Id_Produto, " +
                          "VW.Competencia, VW.Marca, VW.Produto, IIF(VW.Tipo_Es = 'E', 'Entrada','Saída') AS Tipo_ES, VW.Data_Cadastro, " +
                          "VW.Qtd_Produto, VW.Valor_Unitario, VW.Valor_Total ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Data_Cadastro BETWEEN @dataInicio AND @dataFinal AND VW.Id_Produto = @Id_Produto ");
            strSQL.Append("ORDER BY VW.Data_Cadastro DESC, " +
                          "UPPER(VW.Produto) ASC");


            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("dataInicio", dataInicio);
                crud.AdicionarParametro("dataFinal", dataFinal);
                crud.AdicionarParametro("Id_Produto", prodId);
                return lista = crud.Consulta(CommandType.Text, strSQL.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListaEstoqueMarca(int marcaId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT VW.Id_Estoque, VW.Id_Competecia, VW.Id_Marca, VW.Id_Produto, " +
                          "VW.Competencia, VW.Marca, VW.Produto, IIF(VW.Tipo_Es = 'E', 'Entrada','Saída') AS Tipo_ES, VW.Data_Cadastro, " +
                          "VW.Qtd_Produto, VW.Valor_Unitario, VW.Valor_Total ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Id_Marca = @Id_Marca ");
            strSQL.Append("ORDER BY VW.Data_Cadastro DESC, " +
                          "UPPER(VW.Produto) ASC");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id_Marca", marcaId);
                return lista = crud.Consulta(CommandType.Text, strSQL.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListaEstoqueProduto(int produtoId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            lista = new DataTable();

            strSQL.Append("SELECT VW.Id_Estoque, VW.Id_Competecia, VW.Id_Marca, VW.Id_Produto, " +
                          "VW.Competencia, VW.Marca, VW.Produto, IIF(VW.Tipo_Es = 'E', 'Entrada','Saída') AS Tipo_ES, VW.Data_Cadastro, " +
                          "VW.Qtd_Produto, VW.Valor_Unitario, VW.Valor_Total ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Id_Produto = @Id_Produto ");
            strSQL.Append("ORDER BY VW.Data_Cadastro DESC, " +
                          "UPPER(VW.Produto) ASC");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id_Produto", produtoId);
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
                          "VW.Competencia, VW.Marca, VW.Produto, IIF(VW.Tipo_Es = 'E', 'Entrada','Saída') AS Tipo_ES, VW.Data_Cadastro, " +
                          "VW.Qtd_Produto, VW.Valor_Unitario, VW.Valor_Total ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE UPPER(VW.Produto) LIKE UPPER(@pesquisa) OR UPPER(VW.Marca) LIKE UPPER(@pesquisa) ");
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
