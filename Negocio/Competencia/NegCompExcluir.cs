using BancoDados;
using Modelo;
using System;
using System.Data;
using System.Text;

namespace Negocio.Competencia
{
    public class NegCompExcluir
    {
        StringBuilder strSQL;
        BDCrud crud;

        public bool Excluir(ModCompetencia competencia)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();

            strSQL.Append("DELETE FROM Competencia ");
            strSQL.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
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
