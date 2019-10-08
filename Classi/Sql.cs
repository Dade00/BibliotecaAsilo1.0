using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Classi
{
    class Sql
    {
        private static SqlConnection DbInstance;
        public static SqlConnection getInstance()
        {
            string ConnectionString = "data source = " + Credenziali.sqlServerAddress + ";initial catalog = " + Credenziali.sqlServerDB + ";persist security info=True;user id = " + Credenziali.sqlServerUser + ";password = " + Credenziali.sqlServerPassword + ";MultipleActiveResultSets=True";
            if (DbInstance == null)
            {
                DbInstance = new SqlConnection(ConnectionString);
                DbInstance.Open();
            }
            return DbInstance;
        }
    }
}
