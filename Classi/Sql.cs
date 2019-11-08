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
            XMLGesture xMLGesture = new XMLGesture();
            string ConnectionString = "data source = " + xMLGesture.ServerAddress() + ";initial catalog = " + xMLGesture.initialCatalog() + ";persist security info=True;user id = " + xMLGesture.user() + ";password = " + xMLGesture.pw() + ";MultipleActiveResultSets=True";
            if (DbInstance == null)
            {
                DbInstance = new SqlConnection(ConnectionString);
                DbInstance.Open();
            }
            return DbInstance;
        }
    }
}
