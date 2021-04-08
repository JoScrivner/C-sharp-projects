using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskolak
{
    static class ABKezelo  // statikus osztály = egyetlen példányban létezik
    {
        static SqlConnection conn;

        static ABKezelo()  // statikus konstruktor
        {
            conn = new SqlConnection(Properties.Settings.Default.IskolaConnectionString);
            conn.Open();
        }

        public static IskolaLista Listaz()
        {
            IskolaLista lista = new IskolaLista();
            SqlCommand cmd = new SqlCommand("select * from [Iskola] left join [Altalanos] on [Iskola].[Id] = [Altalanos].[Id] left join [Gimnazium] on [Iskola].[Id] = [Gimnazium].[Id]", conn);
            using (SqlDataReader r = cmd.ExecuteReader())
            {
                while (r.Read())
                {
                    Iskola i = null;
                    if (r["Tagozatok"] == DBNull.Value)  
                    {
                        i = new Gimnazium(r["Megnevezes"].ToString(), (int)r["AktivTanuloszam"], (int)r["MaxTanuloszam"], r["Cim"].ToString(), r["IgazgatoNeve"].ToString(), (bool)r["KozpontiFelveteli"], (bool)r["SportolasiLehetoseg"], (int)r["TermekSzama"]);
                    }
                    else  // Altalanos iskola
                    {
                        i = new Altalanos(r["Megnevezes"].ToString(), (int)r["AktivTanuloszam"], (int)r["MaxTanuloszam"], r["Cim"].ToString(), r["IgazgatoNeve"].ToString(), (int)r["OsztalyokSzama"], (bool)r["Tagozatok"], (bool)r["Szakkorok"]);
                    }
                    i.IID = (int)r["Id"];  // ID mentése az adatbázisból
                    lista.Add(i);
                }
            }

            return lista;
        }

        public static void Beszuras(Iskola i)
        {
            SqlTransaction tr = conn.BeginTransaction();  // tranzakció indítása
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Iskola]([Megnevezes],[AktivTanuloszam],[MaxTanuloszam],[Cim],[IgazgatoNeve]) OUTPUT INSERTED.Id VALUES(@megn, @aktivt, @maxt, @cim, @ignev)", conn, tr);
                cmd.Parameters.Add(new SqlParameter("@megn", i.Megnevezes));
                cmd.Parameters.Add(new SqlParameter("@aktivt", i.Aktivtanuloszam));
                cmd.Parameters.Add(new SqlParameter("@maxt", i.Maxtanuloszam));
                cmd.Parameters.Add(new SqlParameter("@cim", i.Cim));
                cmd.Parameters.Add(new SqlParameter("@ignev", i.Igazgato));

                int ID = (int)cmd.ExecuteScalar();  // az OUTPUT INSERTED eredményét vesszük át!
                i.IID = ID;  // ID mentése az adatbázisból

                switch (i)
                {
                    case Altalanos alt:
                        cmd = new SqlCommand("INSERT INTO [Altalanos] VALUES(@id, @osz, @tag, @szakk)", conn, tr);
                        cmd.Parameters.Add(new SqlParameter("@id", ID));
                        cmd.Parameters.Add(new SqlParameter("@osz", alt.Osztalyokszama));
                        cmd.Parameters.Add(new SqlParameter("@tag", alt.VanTagozat));
                        cmd.Parameters.Add(new SqlParameter("@szakk", alt.VanSzakkor));
                        break;
                    case Gimnazium gm:
                        cmd = new SqlCommand("INSERT INTO [Gimnazium] VALUES(@id, @kp, @sport, @tsz)", conn, tr);
                        cmd.Parameters.Add(new SqlParameter("@id", ID));
                        cmd.Parameters.Add(new SqlParameter("@kp", gm.VanKozponti));
                        cmd.Parameters.Add(new SqlParameter("@sport", gm.VanSport));
                        cmd.Parameters.Add(new SqlParameter("@tsz", gm.Termekszama));
                        break;
                }
                cmd.ExecuteNonQuery();
                tr.Commit();
            }
            catch (Exception ex)
            {
                tr.Rollback();  // visszavonjuk az elvégzett műveleteket
                System.Diagnostics.Debug.WriteLine(ex.Message);  // a kivétel szövegét az Output ablakba írjuk
            }
        }

        public static void Torles(Iskola i)
        {
            SqlTransaction tr = conn.BeginTransaction();  // tranzakció indítása
            try
            {
                string tablanev = i is Altalanos ? "Altalanos" : "Gimnazium";
                SqlCommand cmd = new SqlCommand($"DELETE FROM [{tablanev}] WHERE [Id] = {i.IID}", conn, tr);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand($"DELETE FROM [Iskola] WHERE [Id] = {i.IID}", conn, tr);
                cmd.ExecuteNonQuery();
                tr.Commit();
            }
            catch (Exception ex)
            {
                tr.Rollback();  // visszavonjuk az elvégzett műveleteket
                System.Diagnostics.Debug.WriteLine(ex.Message);  // a kivétel szövegét az Output ablakba írjuk
            }
        }

        /*
        public static void Modositas(Iskola i)
        {
            SqlTransaction tr = conn.BeginTransaction();  // tranzakció indítása
            try
            {
                
                SqlCommand cmd = new SqlCommand("UPDATE [Iskola] SET [Megnevezes] = @megn, [AktivTanuloszam] = @aktivt, [MaxTanuloszam] = @maxt, [Cim] = @cim, [IgazgatoNeve] = @ignev WHERE [Id] = @id", conn, tr);
                cmd.Parameters.Add(new SqlParameter("@megn", i.Megnevezes));
                cmd.Parameters.Add(new SqlParameter("@aktivt", i.Aktivtanuloszam));
                cmd.Parameters.Add(new SqlParameter("@maxt", i.Maxtanuloszam));
                cmd.Parameters.Add(new SqlParameter("@cim", i.Cim));
                cmd.Parameters.Add(new SqlParameter("@ignev", i.Igazgato));
                cmd.Parameters.Add(new SqlParameter("@id", i.IID));

                cmd.ExecuteNonQuery();

                switch (i)
                {
                    
                    case Altalanos alt:
                        cmd = new SqlCommand("UPDATE [Altalanos] SET [OsztalyokSzama] = @osz, [Tagozatok] = @tag, [Szakkorok] = @szakk WHERE [Id] = @id", conn, tr);
                        cmd.Parameters.Add(new SqlParameter("@id", i.IID));
                        cmd.Parameters.Add(new SqlParameter("@osz", alt.Osztalyokszama));
                        cmd.Parameters.Add(new SqlParameter("@tag", alt.VanTagozat));
                        cmd.Parameters.Add(new SqlParameter("@szakk", alt.VanSzakkor));
                        break;
                    case Gimnazium gm:
                        cmd = new SqlCommand("UPDATE [Gimnazium] SET [KozpontiFelveteli] = @kp, [SportolasiLehetoseg] = @sport, [TermekSzama] = @tsz WHERE [Id] = @id", conn, tr);
                        cmd.Parameters.Add(new SqlParameter("@id", i.IID));
                        cmd.Parameters.Add(new SqlParameter("@kp", gm.VanKozponti));
                        cmd.Parameters.Add(new SqlParameter("@sport", gm.VanSport));
                        cmd.Parameters.Add(new SqlParameter("@tsz", gm.Termekszama));
                        break;
                }
                cmd.ExecuteNonQuery();
                tr.Commit();
            }
            catch (Exception ex)
            {
                tr.Rollback();  // visszavonjuk az elvégzett műveleteket
                System.Diagnostics.Debug.WriteLine(ex.Message);  // a kivétel szövegét az Output ablakba írjuk
            }
        }
        */
    }
}
