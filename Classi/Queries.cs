using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Classi
{
    public class Queries
    {
        public static bool bambinoExist(Bambino bambino)
        {
            DataTable dataTable = new DataTable();
            try
            {
                string sql = "SELECT * FROM Bambini WHERE Nome LIKE @nome and Cognome LIKE @cognome and Classe = @classe and Data_Nascita = @datanascita";  //Case sensitive

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@nome", bambino.Nome);
                    cmd.Parameters.AddWithValue("@cognome", bambino.Cognome);
                    cmd.Parameters.AddWithValue("@classe", bambino.Classe);
                    cmd.Parameters.AddWithValue("@datanascita", bambino.DataNascita);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch { throw; }
        }

        public static List<string> Classi()
        {
            DataTable dataTable = new DataTable();
            try
            {
                string sql = "SELECT DISTINCT Classe FROM Bambini";  //Case sensitive

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                }
            }
            catch { throw; }

            List<string> Classi = new List<string>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Classi.Add(dataTable.Rows[i][0].ToString());
            }

            return Classi;
        }

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
        public static bool delBambino(int id)
        {
            try
            {
                string sql = "DELETE FROM [Asilo].[dbo].[Bambini] WHERE ID=@id";

                SqlCommand cmd = new SqlCommand(sql, Sql.getInstance());

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            return true;
        }
        public static int getMaxIDfromBambini()
        {
            int queryResult = 0;
            DataTable dataTable = new DataTable();
            string sql = "SELECT MAX(ID) as n FROM[Asilo].[dbo].[Bambini]";
            try
            {

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);

                    queryResult = Int32.Parse(dataTable.Rows[0]["n"].ToString());
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return queryResult;
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
            string sql = "";
            try
            {
                if (nuovoBambino.Path != "")
                    sql = "UPDATE Bambini SET Nome = @nome, Cognome = @cognome, Data_Nascita = @Data_Nascita, Classe = @Classe, Path_Foto = @Path WHERE ID = @id";
                else
                    sql = "UPDATE Bambini SET Nome = @nome, Cognome = @cognome, Data_Nascita = @Data_Nascita, Classe = @Classe WHERE ID = @id";



                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id", nuovoBambino.ID);
                    cmd.Parameters.AddWithValue("@nome", nuovoBambino.Nome);
                    cmd.Parameters.AddWithValue("@cognome", nuovoBambino.Cognome);
                    cmd.Parameters.AddWithValue("@Data_Nascita", nuovoBambino.DataNascita);
                    cmd.Parameters.AddWithValue("@Classe", nuovoBambino.Classe);
                    if (nuovoBambino.Path != "")
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
                string sql = "SELECT * FROM Bambini WHERE Nome LIKE @nome and Cognome LIKE @cognome and Classe = @classi";  //Case sensitive

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@nome", bambinoRicercato.Nome);
                    cmd.Parameters.AddWithValue("@cognome", bambinoRicercato.Cognome);
                    cmd.Parameters.AddWithValue("@classi", bambinoRicercato.Classe);

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

        public static List<Libro> getLibri(int id)
        {

            List<Libro> listaLibri = new List<Libro>();
            DataTable dataTable = new DataTable();
            string sql = "SELECT DISTINCT Libri.ID, libri.Autore, libri.Titolo, Generi.Genere, libri.Path_Foto, libri.In_Prestito " +
                "FROM[Asilo].[dbo].[Libri], [Asilo].[dbo].[Generi]" +
                "where Libri.ID_Genere = Generi.ID and Libri.ID = @id";
            try
            {

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("id", id);

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

        public static bool delLibro(int id)
        {
            try
            {
                string sql = "DELETE FROM [Asilo].[dbo].[Libri] WHERE ID=@id";

                SqlCommand cmd = new SqlCommand(sql, Sql.getInstance());

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            return true;
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
        public static bool editLibro(string path, int id)
        {
            bool result = true;

            try
            {
                string sql = "UPDATE Libri SET Path_Foto = @path WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@path", path);
                    cmd.Parameters.AddWithValue("@id", id);


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

        public static List<Transazione> getTransazionibyBambino(int idBambino)
        {
            bool result = true;
            DataTable dataTable = new DataTable();
            List<Transazione> transaziones = new List<Transazione>();
            try
            {
                string sql = "SELECT * FROM [Transazioni] where ID_Bambino = @idb and Data_Restituzione is not null";

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@idb", idBambino);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dataTable);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Transazione transazione = new Transazione();

                        transazione.ID = Int32.Parse(dataTable.Rows[i]["ID"].ToString());
                        transazione.ID_Bambino = Int32.Parse(dataTable.Rows[i]["ID_Bambino"].ToString());
                        transazione.ID_Libro = Int32.Parse(dataTable.Rows[i]["ID_Libro"].ToString());

                        transaziones.Add(transazione);
                    }

                    return transaziones;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int getIDTransazionebyLibro(int idBambino, int idLibro)
        {
            bool result = true;
            DataTable dataTable = new DataTable();
            try
            {
                string sql = "SELECT ID FROM [Transazioni] where ID_Bambino = @idb and ID_Libro = @idl and Data_Restituzione is null";

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@idb", idBambino);
                    cmd.Parameters.AddWithValue("@idl", idLibro);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dataTable);

                    return Int32.Parse(dataTable.Rows[0][0].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static bool editLibro(Libro Libro_mod)
        {
            bool result = true;

            try
            {
                string sql = "UPDATE Libri SET Titolo = @titolo, Autore = @autore, ID_Genere = @genere WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@titolo", Libro_mod.Titolo);
                    cmd.Parameters.AddWithValue("@autore", Libro_mod.Autore);
                    cmd.Parameters.AddWithValue("@genere", getIDfromGenere(Libro_mod.Genere));
                    cmd.Parameters.AddWithValue("@id", Libro_mod.ID);

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
        public static int getMaxIDfromLibri()
        {
            int queryResult = 0;
            DataTable dataTable = new DataTable();
            string sql = "SELECT MAX(ID) as n FROM[Asilo].[dbo].[Libri]";
            try
            {

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);

                    queryResult = Int32.Parse(dataTable.Rows[0]["n"].ToString());
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return queryResult;
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

        public static List<Libro> getlibridaRestituire(int IDbambino)
        {
            //Prende tutti i libri di un genere specificato disponibili in deposito 
            List<Libro> listaLibri = new List<Libro>();
            DataTable dataTable = new DataTable();
            string sql = "SELECT DISTINCT libri.[ID] ,[Titolo] ,[Autore], Generi.Genere ,libri.[Path_Foto] ,[In_Prestito]" +
                " FROM[dbo].[Libri], dbo.Transazioni, dbo.Generi where Transazioni.ID_Libro = Libri.ID and Transazioni.ID_Bambino = @id and Generi.ID = ID_Genere and Libri.In_Prestito = 1";
            try
            {

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("id", IDbambino);

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

        public static bool PrendiLibro(Libro libro, Bambino bambino)
        {
            bool result = true;

            try
            {
                string sql = "INSERT INTO Transazioni (ID_Bambino, ID_Libro, Data_Prestito)  VALUES (@id_b, @id_l, @data) ";

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id_l", libro.ID);
                    cmd.Parameters.AddWithValue("@id_b", bambino.ID);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

            try
            {
                string sql = "UPDATE Libri SET In_Prestito=1 WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id", libro.ID);


                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }



            return true;
        }

        public static bool RestituisciLibro(int idTrans, int idLibro)
        {
            bool result = true;

            try
            {
                string sql = "UPDATE [Transazioni] SET [Data_Restituzione] = @dataNow WHERE ID = @idTrans ";

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@idTrans", idTrans);
                    cmd.Parameters.AddWithValue("@dataNow", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

            try
            {
                string sql = "UPDATE Libri SET In_Prestito=0 WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("@id", idLibro);


                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }



            return true;
        }

        /// <summary>
        /// Prende tutti i bambini presi singolarmente che hanno letto quel libro
        /// </summary>
        /// <param name="id">ID del libro da controllare</param>
        /// <returns></returns>
        public static List<Bambino> getBambinichehannolettoillibro(int id)
        {

            List<Bambino> listaLibri = new List<Bambino>();
            DataTable dataTable = new DataTable();
            string sql = "SELECT DISTINCT Bambini.[ID], Bambini.[Nome], Bambini.[Cognome], Bambini.[Classe], Bambini.[Data_Nascita], Bambini.[Path_Foto] " +
                "FROM [Asilo].[dbo].[Transazioni], [Asilo].[dbo].[Bambini]" +
                "WHERE Bambini.ID = Transazioni.ID_Bambino and ID_Libro = @id";
            try
            {

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("id", id);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);

                    //Converto la tabella della query in Classi.Bambino
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Bambino bambino = new Bambino();

                        bambino.ID = Int32.Parse(dataTable.Rows[i]["ID"].ToString());
                        bambino.Nome = dataTable.Rows[i]["Nome"].ToString();
                        bambino.Cognome = dataTable.Rows[i]["Cognome"].ToString();
                        bambino.Classe = dataTable.Rows[i]["Classe"].ToString();
                        bambino.DataNascita = (DateTime)dataTable.Rows[i]["Data_Nascita"];
                        bambino.Path = dataTable.Rows[i]["Path_Foto"].ToString();

                        listaLibri.Add(bambino);
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
        /// 
        /// </summary>
        /// <param name="id">Sempre l'Id del libro</param>
        /// <returns></returns>
        public static int nVolteLibroLetto(int id)
        {

            List<Bambino> listaLibri = new List<Bambino>();
            DataTable dataTable = new DataTable();
            string sql = "SELECT ID " +
                "FROM [Asilo].[dbo].[Transazioni]" +
                "WHERE ID_Libro = @id";
            try
            {

                using (SqlCommand cmd = new SqlCommand(sql, Sql.getInstance()))
                {
                    cmd.Parameters.AddWithValue("id", id);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    return dataTable.Rows.Count;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }

}
