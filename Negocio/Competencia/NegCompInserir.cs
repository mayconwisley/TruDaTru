using BancoDados;
using Modelo;
using System;
using System.Data;
using System.Text;

namespace Negocio.Competencia
{
    public class NegCompInserir
    {
        StringBuilder strSQL;
        BDCrud crud;
        public bool Inserir(ModCompetencia competencia)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();

            strSQL.Append("INSERT INTO Competencia (Data_Competencia, Ativo) ");
            strSQL.Append("VALUES(@Data_Competencia, Ativo)");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Data_Competencia", competencia.Competencia);
                crud.AdicionarParametro("Ativo", competencia.Ativo);
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
