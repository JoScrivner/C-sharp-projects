using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvesboltMintaVizsga
{
    static class ABKezelo  // statikus osztály = egyetlen példányban létezik
    {
        static SqlConnection conn;

        static ABKezelo()  // statikus konstruktor
        {
            conn = new SqlConnection(Properties.Settings.Default.KonyvConnectionString);
            conn.Open();
        }

        public static KonyvLista Listaz()
        {
            KonyvLista lista = new KonyvLista();
            SqlCommand cmd = new SqlCommand("select * from [Konyv] left join [TudomanyosKonyv] on [Konyv].[Id] = [TudomanyosKonyv].[Id] left join [IrodalmiKonyv] on [Konyv].[Id] = [IrodalmiKonyv].[Id]", conn);
            using (SqlDataReader r = cmd.ExecuteReader())
            {
                while (r.Read())
                {
                    Konyv k = null;
                    // r.IsDBNull(10) megadja, hogy a 10-es sorszámú oszlopban NULL érték van
                    if (r["Kategoria"] == DBNull.Value)  // a "Kategoria" oszlopban NULL van
                    {
                        k = new TudomanyosKonyv(r["Cim"].ToString(), r["Szerzo"].ToString(), (int)r["Oldalszam"], (int)r["Ar"], (int)r["KiadasEve"], (TudomanyTeruletTipus)(int)r["TudomanyTerulet"], (bool)r["Elismert"]);
                    }
                    else  // irodalmi könyv
                    {
                        k = new IrodalmiKonyv(r["Cim"].ToString(), r["Szerzo"].ToString(), (int)r["Oldalszam"], (int)r["Ar"], (int)r["KiadasEve"], (KategoriaTipus)(int)r["Kategoria"]);
                    }
                    k.DBID = (int)r["Id"];  // ID mentése az adatbázisból
                    lista.Add(k);
                }
            }

            return lista;
        }

        public static void Beszuras(Konyv k)
        {
            SqlTransaction tr = conn.BeginTransaction();  // tranzakció indítása
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Konyv]([Cim],[Szerzo],[Oldalszam],[Ar],[KiadasEve]) OUTPUT INSERTED.Id VALUES(@cim, @szerzo, @osz, @ar, @ke)", conn, tr);
                cmd.Parameters.Add(new SqlParameter("@cim", k.Cim));
                cmd.Parameters.Add(new SqlParameter("@szerzo", k.Szerzo));
                cmd.Parameters.Add(new SqlParameter("@osz", k.Oldalszam));
                cmd.Parameters.Add(new SqlParameter("@ar", k.Ar));
                cmd.Parameters.Add(new SqlParameter("@ke", k.KiadasEve));

                int ID = (int)cmd.ExecuteScalar();  // az OUTPUT INSERTED eredményét vesszük át!
                k.DBID = ID;  // ID mentése az adatbázisból

                switch (k)
                {
                    case TudomanyosKonyv tk:
                        cmd = new SqlCommand("INSERT INTO [TudomanyosKonyv] VALUES(@id, @tt, @ei)", conn, tr);
                        cmd.Parameters.Add(new SqlParameter("@id", ID));
                        cmd.Parameters.Add(new SqlParameter("@tt", (int)tk.TudomanyTerulet));
                        cmd.Parameters.Add(new SqlParameter("@ei", tk.Elismert));
                        break;
                    case IrodalmiKonyv ik:
                        cmd = new SqlCommand("INSERT INTO [IrodalmiKonyv] VALUES(@id, @kat)", conn, tr);
                        cmd.Parameters.Add(new SqlParameter("@id", ID));
                        cmd.Parameters.Add(new SqlParameter("@kat", (int)ik.Kategoria));
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

        public static void Torles(Konyv k)
        {
            SqlTransaction tr = conn.BeginTransaction();  // tranzakció indítása
            try
            {
                string tablanev = k is IrodalmiKonyv ? "IrodalmiKonyv" : "TudomanyosKonyv";
                SqlCommand cmd = new SqlCommand($"DELETE FROM [{tablanev}] WHERE [Id] = {k.DBID}", conn, tr);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand($"DELETE FROM [Konyv] WHERE [Id] = {k.DBID}", conn, tr);
                cmd.ExecuteNonQuery();
                tr.Commit();
            }
            catch (Exception ex)
            {
                tr.Rollback();  // visszavonjuk az elvégzett műveleteket
                System.Diagnostics.Debug.WriteLine(ex.Message);  // a kivétel szövegét az Output ablakba írjuk
            }
        }

        public static void Modositas(Konyv k)
        {
            SqlTransaction tr = conn.BeginTransaction();  // tranzakció indítása
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE [Konyv] SET [Cim] = @cim, [Szerzo] = @szerzo, [Oldalszam] = @osz, [Ar] = @ar, [KiadasEve] = @ke WHERE [Id] = @id", conn, tr);
                cmd.Parameters.Add(new SqlParameter("@cim", k.Cim));
                cmd.Parameters.Add(new SqlParameter("@szerzo", k.Szerzo));
                cmd.Parameters.Add(new SqlParameter("@osz", k.Oldalszam));
                cmd.Parameters.Add(new SqlParameter("@ar", k.Ar));
                cmd.Parameters.Add(new SqlParameter("@ke", k.KiadasEve));
                cmd.Parameters.Add(new SqlParameter("@id", k.DBID));  // ÚJ !!!!

                cmd.ExecuteNonQuery();

                switch (k)
                {
                    case TudomanyosKonyv tk:
                        cmd = new SqlCommand("UPDATE [TudomanyosKonyv] SET [TudomanyTerulet] = @tt, [Elismert] = @ei WHERE [Id] = @id", conn, tr);
                        cmd.Parameters.Add(new SqlParameter("@id", k.DBID));
                        cmd.Parameters.Add(new SqlParameter("@tt", (int)tk.TudomanyTerulet));
                        cmd.Parameters.Add(new SqlParameter("@ei", tk.Elismert));
                        break;
                    case IrodalmiKonyv ik:
                        cmd = new SqlCommand("UPDATE [IrodalmiKonyv] SET [Kategoria] = @kat WHERE [Id] = @id", conn, tr);
                        cmd.Parameters.Add(new SqlParameter("@id", k.DBID));
                        cmd.Parameters.Add(new SqlParameter("@kat", (int)ik.Kategoria));
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
    }
}
