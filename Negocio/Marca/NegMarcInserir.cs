using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using BancoDados;
using System.Data;

namespace Negocio.Marca
{
    public class NegMarcInserir
    {
        StringBuilder strSQL;
        BDCrud crud;
        public bool Inserir(ModMarca marca)
        {
            strSQL = new StringBuilder();
            crud = new BDCrud();

            strSQL.Append("INSERT INTO Marca (Descricao, Ativo) ");
            strSQL.Append("VALUES(@Descricao, @Ativo)");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametro("Descricao", marca.Descricao);
                crud.AdicionarParametro("Ativo", marca.Ativo);
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
