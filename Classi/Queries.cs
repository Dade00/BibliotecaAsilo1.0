using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Classi
{
    public class Queries
    {
        public static void addBambino(Bambino bambino)
        {
            try
            {
                string sql = "INSERT INTO Bambini VALUES (@nome, @cognome, @Data_Nascita, @Classe, @Path_Foto)";

                SqlCommand cmd = new SqlCommand(sql, Sql.getInstance());

                cmd.Parameters.AddWithValue("@Nome", bambino.Nome);
                cmd.Parameters.AddWithValue("@Cognome", bambino.Cognome);
                cmd.Parameters.AddWithValue("@Data_Nascita", bambino.DataNascita);
                cmd.Parameters.AddWithValue("@Classe", bambino.Classe);
                cmd.Parameters.AddWithValue("@Path_Foto", bambino.Cognome);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool getBambini(ref List<Bambino> listaBambini)
        {
            bool result = true;
            try
            {
                string sql = "SELECT * FROM Bambini";

                if (listaBambini.Count > 0)
                    listaBambini.Clear();

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                        while (dr.Read())
                        {
                            Bambino bambinoTmp = new Bambino();

                            // DO NOT DO THAT
                            //if (!dr.IsDBNull(dr.GetOrdinal("ID"))) bambinoTmp.ID = dr.GetInt32(dr.GetOrdinal("ID"));
                            //if (!dr.IsDBNull(dr.GetOrdinal("Nome"))) bambinoTmp.Nome = dr.GetString(dr.GetOrdinal("Nome"));
                            //if (!dr.IsDBNull(dr.GetOrdinal("Cognome"))) bambinoTmp.Cognome = dr.GetString(dr.GetOrdinal("Cognome"));

                            listaBambini.Add(bambinoTmp);
                        }
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }

            return result;
        }
    }
}
