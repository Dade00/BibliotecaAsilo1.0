﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

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
                cmd.Parameters.AddWithValue("@Path_Foto", bambino.Path);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool getBambini(ref List<Bambino> listaBambini)
        {
            DataTable dataTable = new DataTable();
            bool result = true;
            try
            {
                string sql = "SELECT * FROM Bambini";

                if (listaBambini.Count > 0)
                    listaBambini.Clear();

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    
                    //Converto la tabella della query in Classi.Bambino
                    for(int i=0; i<dataTable.Rows.Count; i++)
                    {
                        Bambino bambinoTmp = new Bambino();

                        bambinoTmp.ID = Int32.Parse(dataTable.Rows[i]["ID"].ToString());
                        bambinoTmp.Nome = dataTable.Rows[i]["Nome"].ToString();
                        bambinoTmp.Cognome = dataTable.Rows[i]["Cognome"].ToString();
                        bambinoTmp.Classe = dataTable.Rows[i]["Classe"].ToString();
                        bambinoTmp.DataNascita = (DateTime)dataTable.Rows[i]["Data_Nascita"];
                        bambinoTmp.Path = dataTable.Rows[i]["Path_Foto"].ToString();

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

        public static bool editBambino(Bambino nuovoBambino)
        {
            bool result = true;

            try
            {
                string sql = "UPDATE Bambini SET Nome = @nome, Cognome = @cognome, DataNascita = @DataNascita, Classe = @Classe, Path = @Path WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id", nuovoBambino.ID);
                    cmd.Parameters.AddWithValue("@nome", nuovoBambino.Nome);
                    cmd.Parameters.AddWithValue("@cognome", nuovoBambino.Cognome);
                    cmd.Parameters.AddWithValue("@Data_Nascita", nuovoBambino.DataNascita);
                    cmd.Parameters.AddWithValue("@Classe", nuovoBambino.Classe);
                    cmd.Parameters.AddWithValue("@Path_Foto", nuovoBambino.Path);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }

            return result;
        }

        public static Bambino getBambino(Bambino bambinoRicercato, int anni)
        {
            Bambino b = null;
            List<Bambino> listaBambini = new List<Bambino>();

            try
            {
                string sql = "SELECT * FROM Bambini WHERE Nome = @nome and Cognome = @cognome";  //Case sensitive

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@nome", bambinoRicercato.Nome);
                    cmd.Parameters.AddWithValue("@cognome", bambinoRicercato.Cognome);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            Bambino bambinoTmp = new Bambino();

                            if (!dr.IsDBNull(dr.GetOrdinal("ID"))) bambinoTmp.ID = dr.GetOrdinal("ID");
                            if (!dr.IsDBNull(dr.GetOrdinal("Nome"))) bambinoTmp.Nome = dr.GetString(dr.GetOrdinal("Nome"));
                            if (!dr.IsDBNull(dr.GetOrdinal("Cognome"))) bambinoTmp.Cognome = dr.GetString(dr.GetOrdinal("Cognome"));
                            if (!dr.IsDBNull(dr.GetOrdinal("Data_Nascita"))) bambinoTmp.DataNascita = dr.GetDateTime(dr.GetOrdinal("Data_Nascita"));
                            if (!dr.IsDBNull(dr.GetOrdinal("Classe"))) bambinoTmp.Classe = dr.GetString(dr.GetOrdinal("Classe"));
                            if (!dr.IsDBNull(dr.GetOrdinal("Path_Foto"))) bambinoTmp.Path = dr.GetString(dr.GetOrdinal("Path_Foto"));

                            listaBambini.Add(bambinoTmp);
                        }
                    }
                }
                foreach (Bambino bam in listaBambini)
                {
                    if (Math.Truncate(DateTime.Now.Subtract(bam.DataNascita).TotalDays / 365) == anni) //Il risultato della prima non può mai essere esattamente il numero di anni quindi, troncando, considero solo la prima cifra senza quelle dopo la virgola e quindi rendo possibile il confonto
                        b = bam;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return b;
        }
    }
}
