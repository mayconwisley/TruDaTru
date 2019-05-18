using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;

namespace BancoDados
{
    public class BDConexao
    {
        protected FbConnection fbConnection;
        private string strConexao = @"User=sysdba;Password=masterkey;DataBase=C:\Programação\TruDaTru\TruDaTru\bin\x86\Debug\Banco\TRUDATRU.FDB.fdb;Dialect=3;ServerType=1";

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
