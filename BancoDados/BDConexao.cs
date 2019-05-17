using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;

namespace BancoDados
{
    public class BDConexao
    {
        protected FbConnection fbConnection;
        private string strConexao = @"DataBase=|DataDirectory|/Banco/trudatru.fdb;username=sysdba;password=masterkey;dialect=3";

        protected bool Conectar()
        {
            fbConnection = new FbConnection(strConexao);
            try
            {
                fbConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        protected bool Desconectar()
        {
            try
            {
                if (fbConnection.State != ConnectionState.Closed)
                {
                    fbConnection.Close();
                    fbConnection.Dispose();
                    return true;
                }
                else
                {
                    fbConnection.Dispose();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
