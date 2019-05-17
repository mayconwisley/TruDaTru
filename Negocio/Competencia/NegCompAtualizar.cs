using BancoDados;
using Modelo;
using System;
using System.Data;
using System.Text;

namespace Negocio.Competencia
{
    public class NegCompAtualizar
    {
        StringBuilder strSQL;
        BDCrud crud;

        public bool Atualizar(ModCompetencia competencia)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();

            strSQL.Append("UPDATE Competencia ");
            strSQL.Append("SET Data_Competencia = @Data_Competencia, Ativo = @Ativo ");
            strSQL.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Data_Competencia", competencia.Competencia);
                crud.AdicionarParametro("Ativo", competencia.Ativo);
                crud.AdicionarParametro("Id", competencia.Id);
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
