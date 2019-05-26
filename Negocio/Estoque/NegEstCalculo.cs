using BancoDados;
using System;
using System.Data;
using System.Text;

namespace Negocio.Estoque
{
    public static class NegEstCalculo
    {

        static StringBuilder strSQL;
        static BDCrud crud;
        static decimal decTotal;

        public static decimal ValorTotal(int quantida, decimal valorUnitario)
        {
            return quantida * valorUnitario;
        }

        #region Total Entrada
        public static decimal TotalEntradaCompetencia(int compId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            decTotal = new decimal();

            strSQL.Append("SELECT SUM(VW.Valor_Total) ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Id_Competecia = @Id_Competecia AND VW.Tipo_Es = 'E' ");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id_Competecia", compId);
                string strVerificar = crud.Executar(CommandType.Text, strSQL.ToString()).ToString();
                if (strVerificar == "")
                {
                    return 0;
                }
                else
                {
                    return decTotal = decimal.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static decimal TotalEntradaPeriodo(DateTime dataInicio, DateTime dataFinal)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            decTotal = new decimal();

            strSQL.Append("SELECT SUM(VW.Valor_Total) ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Data_Cadastro BETWEEN @dataInicio AND @dataFinal AND VW.Tipo_Es = 'E' ");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("dataInicio", dataInicio);
                crud.AdicionarParametro("dataFinal", dataFinal);
                string strVerificar = crud.Executar(CommandType.Text, strSQL.ToString()).ToString();
                if (strVerificar == "")
                {
                    return 0;
                }
                else
                {
                    return decTotal = decimal.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static decimal TotalEntradaMarca(int marcaId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            decTotal = new decimal();

            strSQL.Append("SELECT SUM(VW.Valor_Total) ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Id_Marca = @Id_Marca AND VW.Tipo_Es = 'E' ");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id_Marca", marcaId);
                string strVerificar = crud.Executar(CommandType.Text, strSQL.ToString()).ToString();
                if (strVerificar == "")
                {
                    return 0;
                }
                else
                {
                    return decTotal = decimal.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static decimal TotalEntradaProduto(int produtoId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            decTotal = new decimal();

            strSQL.Append("SELECT SUM(VW.Valor_Total) ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Id_Produto = @Id_Produto AND VW.Tipo_Es = 'E' ");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id_Produto", produtoId);
                string strVerificar = crud.Executar(CommandType.Text, strSQL.ToString()).ToString();
                if (strVerificar == "")
                {
                    return 0;
                }
                else
                {
                    return decTotal = decimal.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Total Saida
        public static decimal TotalSaidaCompetencia(int compId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            decTotal = new decimal();

            strSQL.Append("SELECT SUM(VW.Valor_Total) ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Id_Competecia = @Id_Competecia AND VW.Tipo_Es = 'S' ");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id_Competecia", compId);
                string strVerificar = crud.Executar(CommandType.Text, strSQL.ToString()).ToString();
                if (strVerificar == "")
                {
                    return 0;
                }
                else
                {
                    return decTotal = decimal.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static decimal TotalSaidaPeriodo(DateTime dataInicio, DateTime dataFinal)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            decTotal = new decimal();

            strSQL.Append("SELECT SUM(VW.Valor_Total) ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Data_Cadastro BETWEEN @dataInicio AND @dataFinal AND VW.Tipo_Es = 'S' ");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("dataInicio", dataInicio);
                crud.AdicionarParametro("dataFinal", dataFinal);
                string strVerificar = crud.Executar(CommandType.Text, strSQL.ToString()).ToString();
                if (strVerificar == "")
                {
                    return 0;
                }
                else
                {
                    return decTotal = decimal.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static decimal TotalSaidaMarca(int marcaId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            decTotal = new decimal();

            strSQL.Append("SELECT SUM(VW.Valor_Total) ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Id_Marca = @Id_Marca AND VW.Tipo_Es = 'S' ");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id_Marca", marcaId);

                string strVerificar = crud.Executar(CommandType.Text, strSQL.ToString()).ToString();
                if (strVerificar == "")
                {
                    return 0;
                }
                else
                {
                    return decTotal = decimal.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static decimal TotalSaidaProduto(int produtoId)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();
            decTotal = new decimal();

            strSQL.Append("SELECT SUM(VW.Valor_Total) ");
            strSQL.Append("FROM VW_Estoque VW ");
            strSQL.Append("WHERE VW.Id_Produto = @Id_Produto AND VW.Tipo_Es = 'S' ");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Id_Produto", produtoId);
                string strVerificar = crud.Executar(CommandType.Text, strSQL.ToString()).ToString();
                if (strVerificar == "")
                {
                    return 0;
                }
                else
                {
                    return decTotal = decimal.Parse(crud.Executar(CommandType.Text, strSQL.ToString()).ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

    }
}
