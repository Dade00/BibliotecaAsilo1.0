using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Classi
{
    public class Queries
    {
        public static void addBambino(Bambino bambino)
        {
            try
            {
                string sql = "INSERT INTO Bambini (Nome, Cognome, Data_Nascita, Classe, Path_Foto)  VALUES (@nome, @cognome, @Data_Nascita, @Classe, @Path_Foto)";

                SqlCommand cmd = new SqlCommand(sql, Sql.getInstance());

                cmd.Parameters.AddWithValue("@nome", bambino.Nome);
                cmd.Parameters.AddWithValue("@cognome", bambino.Cognome);
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
                    for (int i = 0; i < dataTable.Rows.Count; i++)
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
                string sql = "UPDATE Bambini SET Nome = @nome, Cognome = @cognome, Data_Nascita = @Data_Nascita, Classe = @Classe, Path_Foto = @Path WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id", nuovoBambino.ID);
                    cmd.Parameters.AddWithValue("@nome", nuovoBambino.Nome);
                    cmd.Parameters.AddWithValue("@cognome", nuovoBambino.Cognome);
                    cmd.Parameters.AddWithValue("@Data_Nascita", nuovoBambino.DataNascita);
                    cmd.Parameters.AddWithValue("@Classe", nuovoBambino.Classe);
                    cmd.Parameters.AddWithValue("@Path", nuovoBambino.Path);

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
            DataTable dataTable = new DataTable();
            try
            {
                string sql = "SELECT * FROM Bambini WHERE Nome LIKE @nome and Cognome LIKE @cognome";  //Case sensitive

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@nome", bambinoRicercato.Nome);
                    cmd.Parameters.AddWithValue("@cognome", bambinoRicercato.Cognome);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);

                    //Converto la tabella della query in Classi.Bambino
                    for (int i = 0; i < dataTable.Rows.Count; i++)
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

        public static List<Bambino> getBambino(string NomeBambino, string CognomeBambino)
        {
            bool Nome = true, Cognome = true;
            Bambino b = null;
            List<Bambino> listaBambini = new List<Bambino>();
            DataTable dataTable = new DataTable();
            string sql = "SELECT * FROM Bambini WHERE Nome LIKE @nome and Cognome LIKE @cognome";  //Case sensitive (Di base ci sono tutti e due)
            if (CognomeBambino == "" && NomeBambino != "")
            {
                sql = "SELECT * FROM Bambini WHERE Nome LIKE @nome";
                Cognome = false;
            }
            else if (CognomeBambino != "" && NomeBambino == "")
            {
                sql = "SELECT * FROM Bambini WHERE Cognome LIKE @cognome";
                Nome = false;
            }
            try
            {

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    if (Nome)
                        cmd.Parameters.AddWithValue("@nome", NomeBambino);
                    if (Cognome)
                        cmd.Parameters.AddWithValue("@cognome", CognomeBambino);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);

                    //Converto la tabella della query in Classi.Bambino
                    for (int i = 0; i < dataTable.Rows.Count; i++)
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
                throw ex;
            }

            return listaBambini;
        }

        public static List<Libro> getLibri()
        {

            List<Libro> listaLibri = new List<Libro>();
            DataTable dataTable = new DataTable();
            string sql = "SELECT Libri.ID, libri.Autore, libri.Titolo, Generi.Genere, libri.Path_Foto, libri.In_Prestito " +
                "FROM[Asilo].[dbo].[Libri], [Asilo].[dbo].[Generi]" +
                "where Libri.ID_Genere = Generi.ID";
            try
            {

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);

                    //Converto la tabella della query in Classi.Bambino
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Libro libro = new Libro();

                        libro.ID = Int32.Parse(dataTable.Rows[i]["ID"].ToString());
                        libro.Titolo = dataTable.Rows[i]["Titolo"].ToString();
                        libro.Autore = dataTable.Rows[i]["Autore"].ToString();
                        libro.Genere = dataTable.Rows[i]["Genere"].ToString();
                        libro.Prestito = (bool)dataTable.Rows[i]["In_Prestito"];
                        libro.Path = dataTable.Rows[i]["Path_Foto"].ToString();

                        listaLibri.Add(libro);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaLibri;
        }

        private static int getIDfromGenere(string Genere)
        {
            int queryResult = 0;
            DataTable dataTable = new DataTable();
            try
            {
                string sql = "SELECT ID FROM [Asilo].[dbo].[Generi] WHERE Genere = @genere";

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@genere", Genere);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                    sqlDataAdapter.Fill(dataTable);
                }

                queryResult = Int32.Parse(dataTable.Rows[0]["ID"].ToString());
            }
            catch (Exception ex)
            {
                throw;
            }
            return queryResult;
        }

        public static List<string> getGenere()
        {
            List<string> vs = new List<string>();
            string queryResult = "";
            DataTable dataTable = new DataTable();
            try
            {
                string sql = "SELECT Genere FROM [Asilo].[dbo].[Generi]";

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                    sqlDataAdapter.Fill(dataTable);
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    vs.Add(dataTable.Rows[i]["Genere"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return vs;
        }

        public static void addLibro(Libro libro)
        {
            try
            {
                string sql = "INSERT INTO Libri (Titolo, Autore, ID_Genere, Path_Foto, In_Prestito) VALUES (@Titolo, @Autore, @ID_Genere, @Path_Foto, @In_Prestito)";

                SqlCommand cmd = new SqlCommand(sql, Sql.getInstance());

                cmd.Parameters.AddWithValue("@Titolo", libro.Titolo);
                cmd.Parameters.AddWithValue("@Autore", libro.Autore);
                cmd.Parameters.AddWithValue("@ID_Genere", getIDfromGenere(libro.Genere));
                cmd.Parameters.AddWithValue("@Path_Foto", libro.Path);
                cmd.Parameters.AddWithValue("@In_Prestito", false);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Libro> getLibribyGenereNOTin_prestito(string Genere)
        {
            //Prende tutti i libri di un genere specificato disponibili in deposito 
            List<Libro> listaLibri = new List<Libro>();
            DataTable dataTable = new DataTable();
            string sql = "SELECT Libri.ID, libri.Autore, libri.Titolo, libri.Path_Foto FROM [Asilo].[dbo].[Libri], [Asilo].[dbo].[Generi] " +
                "where Libri.ID_Genere = Generi.ID and Generi.Genere = @genere and libri.In_Prestito = 0";
            try
            {

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("genere", Genere);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);

                    //Converto la tabella della query in Classi.Bambino
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Libro libro = new Libro();

                        libro.ID = Int32.Parse(dataTable.Rows[i]["ID"].ToString());
                        libro.Titolo = dataTable.Rows[i]["Titolo"].ToString();
                        libro.Autore = dataTable.Rows[i]["Autore"].ToString();
                        libro.Path = dataTable.Rows[i]["Path_Foto"].ToString();

                        listaLibri.Add(libro);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaLibri;
        }

        /// <summary>
        /// Query per prendere libri ma con parametri variabili
        /// </summary>
        /// <returns></returns>
        public static List<Libro> getLibri(string Titolo, string Autore, string Genere)
        {
            bool autore = false, titolo = false, genere = false; 
            List<Libro> listaLibri = new List<Libro>();
            DataTable dataTable = new DataTable();
            //Crea la stinga di base (dando per scontato che abbia inserito tutti e tre i parametri)
            string sql = "SELECT Libri.ID, libri.Autore, libri.Titolo, Generi.Genere, libri.Path_Foto, libri.In_Prestito " +
                "FROM[Asilo].[dbo].[Libri], [Asilo].[dbo].[Generi]" +
                "where Libri.ID_Genere = Generi.ID";
            if (Titolo != "")
            {
                sql += " and Libri.Titolo LIKE @titolo";
                titolo = true;
            }
            if (Autore != "")
            {
                sql += " and Libri.Autore LIKE @autore";
                autore = true;
            }
            if (Genere != "")
            {
                sql += " and Generi.Genere = @genere";
                genere = true;
            }

            try
            {

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {

                    if (genere)
                        cmd.Parameters.AddWithValue("genere", Genere);
                    if (autore)
                        cmd.Parameters.AddWithValue("autore", "%" + Autore + "%");
                    if (titolo)
                        cmd.Parameters.AddWithValue("titolo", "%" + Titolo + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);

                    //Converto la tabella della query in Classi.Bambino
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Libro libro = new Libro();

                        libro.ID = Int32.Parse(dataTable.Rows[i]["ID"].ToString());
                        libro.Titolo = dataTable.Rows[i]["Titolo"].ToString();
                        libro.Autore = dataTable.Rows[i]["Autore"].ToString();
                        libro.Genere = dataTable.Rows[i]["Genere"].ToString();
                        libro.Prestito = (bool)dataTable.Rows[i]["In_Prestito"];
                        libro.Path = dataTable.Rows[i]["Path_Foto"].ToString();

                        listaLibri.Add(libro);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaLibri;
        }
    }

}
