using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace YazilimSinamaFinal
{
    public static class DataBaseQueries
    {
        public static List<Project> GetProjects()
        {
            List<Project> projects = new List<Project> { };
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ScrumboarddbConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from Projeler";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projects.Add(new Project(Convert.ToInt32(reader["Projeid"].ToString()),reader["Projeadi"].ToString()));
                        }
                    }
                    connection.Close();
                }
            }
            return projects;
        }
        public static List<Personel> GetAllPersonel()
        {
            List<Personel> personels = new List<Personel> { };
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ScrumboarddbConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from TeknikUzmanlar";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personels.Add(new Personel(Convert.ToInt32(reader["Uzmanid"].ToString()), reader["Uzmanisim"].ToString()));
                        }
                    }
                    connection.Close();
                }
            }
            return personels;
        }
        public static List<Personel> GetProjectPersonel(Project project)
        {
            List<int> personelid = new List<int> { };
            List<Personel> personels = new List<Personel> { };
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ScrumboarddbConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from ProjeTeknikUzmanlar WHERE Projeid=@Projeid";
                    command.Parameters.AddWithValue("@Projeid", project.projectid);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personelid.Add((Convert.ToInt32(reader["Uzmanid"].ToString())));
                        }
                    }
                    connection.Close();
                }
                foreach (int id in personelid)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * from TeknikUzmanlar WHERE Uzmanid=@Uzmanid";
                        command.Parameters.AddWithValue("@Uzmanid", id);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                personels.Add(new Personel(id, reader["Uzmanisim"].ToString()));
                            }
                        }
                        connection.Close();
                    }
                }
            }
            return personels;
        }
        public static void AddNewProject(string prjname,List<Personel> personels)
        {
            int projeid=0;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ScrumboarddbConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT into Projeler (Projeadi) OUTPUT inserted.Projeid VALUES(@Projeadi)";
                    command.Parameters.AddWithValue("@Projeadi", prjname);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                projeid = Convert.ToInt32(reader["Projeid"].ToString());
                            }

                        }
                    }
                    catch (SqlException)
                    {
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                foreach (Personel personel in personels)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT into ProjeTeknikUzmanlar (Projeid,Uzmanid) VALUES(@Projeid,@Uzmanid)";
                        command.Parameters.AddWithValue("@Projeid", projeid);
                        command.Parameters.AddWithValue("@Uzmanid", personel.personelid);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {

                            throw;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }
        public static void AddNewPersonel(string personelname)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ScrumboarddbConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT into TeknikUzmanlar (Uzmanisim) VALUES(@Uzmanisim)";
                    command.Parameters.AddWithValue("@Uzmanisim", personelname);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        public static int GetPersonelID(string personelname,int id)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ScrumboarddbConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from TeknikUzmanlar WHERE Uzmanisim=@Uzmanisim";
                    command.Parameters.AddWithValue("@Uzmanisim", personelname);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                id = Convert.ToInt32(reader["Uzmanid"]);
                            }
                        }
                    }
                    catch (SqlException)
                    {
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return id;
        }
        public static ScrumCard AddNewCardToProject(ScrumCard card)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ScrumboarddbConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT into Kartlar (Kartadi,Projeid,Durum,Olusturulmatarihi,Aciklama,Notlar) OUTPUT inserted.Kartid " +
                        "VALUES(@Kartadi,@Projeid,@Durum,@Olusturulmatarihi,@Aciklama,@Notlar)";
                    command.Parameters.AddWithValue("@Kartadi", card.cardname);
                    command.Parameters.AddWithValue("@Projeid", card.projectid);
                    command.Parameters.AddWithValue("@Durum", card.panelname);
                    command.Parameters.AddWithValue("@Olusturulmatarihi", card.date);
                    command.Parameters.AddWithValue("@Aciklama", card.description);
                    command.Parameters.AddWithValue("@Notlar", card.notes);                
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                card.cardid = Convert.ToInt32(reader["Kartid"].ToString());
                            }

                        }
                    }
                    catch (SqlException)
                    {
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                foreach (Personel personel in card.cardpersonel)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT into KartTeknikUzmanlar (Kartid,Uzmanid) VALUES(@Kartid,@Uzmanid)";
                        command.Parameters.AddWithValue("@Kartid", card.cardid);
                        command.Parameters.AddWithValue("@Uzmanid", personel.personelid);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                foreach (IsTakip takip in card.isTakiplist)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT into IsTakip (Kartid,Tarih,Durum,Yapilacakis,Aciklama) VALUES(@Kartid,@Tarih,@Durum,@Yapilacakis,@Aciklama)";
                        command.Parameters.AddWithValue("@Kartid", card.cardid);
                        command.Parameters.AddWithValue("@Tarih", takip.date);
                        command.Parameters.AddWithValue("@Durum", takip.durum);
                        command.Parameters.AddWithValue("@Yapilacakis", takip.yapilacak);
                        command.Parameters.AddWithValue("@Aciklama", takip.aciklama);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {

                            throw;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }

                }

            }
            return card;
        }
        public static List<ScrumCard> GetProjectCards(Project project)
        {
            List<ScrumCard> projectcards = new List<ScrumCard> { };
            
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ScrumboarddbConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from Kartlar WHERE Projeid=@Projeid";
                    command.Parameters.AddWithValue("@Projeid", project.projectid);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectcards.Add(new ScrumCard(Convert.ToInt32(reader["Kartid"].ToString()),
                            Convert.ToInt32(reader["Projeid"].ToString()),
                            reader["Durum"].ToString(),
                            (DateTime)reader["Olusturulmatarihi"],
                            reader["Aciklama"].ToString(),
                            reader["Notlar"].ToString(),
                            reader["Kartadi"].ToString()
                            ));
                        }
                    }
                    connection.Close();
                }
            }
            return projectcards;
        }
        public static ScrumCard GetCardDetails(int cardid)
        {
            ScrumCard card = new ScrumCard();
            List<Personel> personels = new List<Personel> { };
            List<int> personelid = new List<int> { };
            List<IsTakip> takip = new List<IsTakip> { };
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ScrumboarddbConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from Kartlar WHERE Kartid=@Kartid";
                    command.Parameters.AddWithValue("@Kartid", cardid);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            card = new ScrumCard(Convert.ToInt32(reader["Kartid"].ToString()),
                            Convert.ToInt32(reader["Projeid"].ToString()),
                            reader["Durum"].ToString(),
                            (DateTime)reader["Olusturulmatarihi"],
                            reader["Aciklama"].ToString(),
                            reader["Notlar"].ToString(),
                            reader["Kartadi"].ToString()
                            );
                        }
                    }
                    connection.Close();
                }
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from KartTeknikUzmanlar WHERE Kartid=@Kartid";
                    command.Parameters.AddWithValue("@Kartid", cardid);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personelid.Add((int)reader["Uzmanid"]);
                        }
                    }
                    connection.Close();
                }
                foreach (int id in personelid)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * from TeknikUzmanlar WHERE Uzmanid=@Uzmanid";
                        command.Parameters.AddWithValue("@Uzmanid", id);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                personels.Add(new Personel(id, reader["Uzmanisim"].ToString()));
                            }
                        }
                        connection.Close();
                    }
                }
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from Istakip WHERE Kartid=@Kartid";
                    command.Parameters.AddWithValue("@Kartid", cardid);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            takip.Add(new IsTakip(cardid, (DateTime)reader["Tarih"], reader["Durum"].ToString(),
                                reader["Yapilacakis"].ToString(), reader["Aciklama"].ToString()));
                        }
                    }
                    connection.Close();
                }
            }
            card.cardpersonel = personels;
            card.isTakiplist = takip;
            return card;
        }
        public static void UpdateCard(ScrumCard card)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ScrumboarddbConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Kartlar SET Aciklama=@Aciklama, Notlar=@Notlar, Kartadi=@Kartadi WHERE Kartid=@Kartid";
                    command.Parameters.AddWithValue("@Kartid", card.cardid);
                    command.Parameters.AddWithValue("@Kartadi", card.cardname);
                    command.Parameters.AddWithValue("@Aciklama", card.description);
                    command.Parameters.AddWithValue("@Notlar", card.notes);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE From KartTeknikUzmanlar WHERE Kartid=@Kartid";
                    command.Parameters.AddWithValue("@Kartid", card.cardid);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                foreach (Personel personel in card.cardpersonel)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT into KartTeknikUzmanlar (Kartid,Uzmanid) VALUES(@Kartid,@Uzmanid)";
                        command.Parameters.AddWithValue("@Kartid", card.cardid);
                        command.Parameters.AddWithValue("@Uzmanid", personel.personelid);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE From Istakip WHERE Kartid=@Kartid";
                    command.Parameters.AddWithValue("@Kartid", card.cardid);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                foreach (IsTakip takip in card.isTakiplist)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT into IsTakip (Kartid,Tarih,Durum,Yapilacakis,Aciklama) VALUES(@Kartid,@Tarih,@Durum,@Yapilacakis,@Aciklama)";
                        command.Parameters.AddWithValue("@Kartid", card.cardid);
                        command.Parameters.AddWithValue("@Tarih", takip.date);
                        command.Parameters.AddWithValue("@Durum", takip.durum);
                        command.Parameters.AddWithValue("@Yapilacakis", takip.yapilacak);
                        command.Parameters.AddWithValue("@Aciklama", takip.aciklama);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }

                }

            }
        }
        public static void UpdateCardPanel(int cardid,string parent)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ScrumboarddbConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Kartlar SET Durum=@Durum WHERE Kartid=@Kartid";
                    command.Parameters.AddWithValue("@Kartid", cardid);
                    command.Parameters.AddWithValue("@Durum", parent);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
