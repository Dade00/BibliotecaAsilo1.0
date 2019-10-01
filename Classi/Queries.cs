using System;
using System.Collections.Generic;
using System.Text;

namespace Classi
{
    class Queries
    {
        //public static string ConnectionString = "data source = " + Credenziali.sqlServerAddress + ";initial catalog = " + Credenziali.sqlServerDB + ";persist security info=True;user id = " + Credenziali.sqlServerUser + ";password = " + Credenziali.sqlServerPassword + ";MultipleActiveResultSets=True";
        //public static void addBambino(Bambino bambino)
        //{

        //    {
        //        bool result = true;

        //        try
        //        {
        //            using (SqlConnection cnn = new SqlConnection(ConnectionString))
        //            {
        //                cnn.Open();

        //                string sql = "INSERT INTO Utenti VALUES (@nome, @cognome, @isAbilitato)";

        //                using (SqlCommand cmd = new SqlCommand(sql, cnn))
        //                {
        //                    cmd.Parameters.AddWithValue("@nome", nuovoUtente.Nome);
        //                    cmd.Parameters.AddWithValue("@cognome", nuovoUtente.Cognome);
        //                    cmd.Parameters.AddWithValue("@isAbilitato", nuovoUtente.IsAbilitato);

        //                    cmd.ExecuteNonQuery();
        //                }

        //                cnn.Close();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            result = false;
        //            throw ex;
        //        }

        //        return result;
        //    }
        //}

        //public static bool GetAllUtenti(ref List<Datatype.Utente> listaUtenti)
        //{
        //    bool result = true;

        //    if (listaUtenti.Count > 0)
        //        listaUtenti.Clear();

        //    try
        //    {
        //        using (SqlConnection cnn = new SqlConnection(ConnectionString))
        //        {
        //            cnn.Open();

        //            string sql = "SELECT * FROM Utenti";

        //            using (SqlCommand cmd = new SqlCommand(sql, cnn))
        //            {
        //                using (SqlDataReader dr = cmd.ExecuteReader())
        //                    while (dr.Read())
        //                    {
        //                        Datatype.Utente userTmp = new Datatype.Utente();

        //                        if (!dr.IsDBNull(dr.GetOrdinal("ID"))) userTmp.ID = dr.GetInt32(dr.GetOrdinal("ID"));
        //                        if (!dr.IsDBNull(dr.GetOrdinal("Nome"))) userTmp.Nome = dr.GetString(dr.GetOrdinal("Nome"));
        //                        if (!dr.IsDBNull(dr.GetOrdinal("Cognome"))) userTmp.Cognome = dr.GetString(dr.GetOrdinal("Cognome"));
        //                        if (!dr.IsDBNull(dr.GetOrdinal("IsAbilitato"))) userTmp.IsAbilitato = dr.GetBoolean(dr.GetOrdinal("IsAbilitato"));

        //                        listaUtenti.Add(userTmp);
        //                    }
        //            }
        //            cnn.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result = false;
        //        throw ex;
        //    }

        //    return result;
        //}
    }
}
