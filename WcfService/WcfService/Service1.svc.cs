using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Database;

namespace WcfService
{
    class Felhasznalo
    {
        string nev;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        string pwd;

        int egyenleg;

        public int Egyenleg
        {
            get { return egyenleg; }
            set { egyenleg = value; }
        }

        public string Pwd
        {
            get
            {
                return pwd;
            }

            set
            {
                pwd = value;
            }
        }

        public string Uid
        {
            get
            {
                return uid;
            }

            set
            {
                uid = value;
            }
        }

        string uid;


        public Felhasznalo(string nev, string pwd, string uid, int egyenleg)
        {
            this.nev = nev;
            this.pwd = pwd;
            this.uid = uid;
            this.egyenleg = egyenleg;
        }
    }


    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IBank
    {
        static List<Felhasznalo> felh = new List<Felhasznalo>();

        Felhasznalo ellenorzes(string f)
        {
            lock (felh)
            {
                Felhasznalo fel = felh.Find(x => x.Uid == f);
                return fel;
            }
        }

        public string Bejelentkezes(string uname, string passwd)
        {
            SqlConnection conn = DatabaseManager.getConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM felhasznalok WHERE felhasznalonev= @uname AND jelszo= @passwd ;", conn);
                command.Parameters.AddWithValue("@uname", uname);
                command.Parameters.AddWithValue("@passwd", passwd);

                Int32 db = Convert.ToInt32(command.ExecuteScalar());


                SqlCommand command2 = new SqlCommand("SELECT bankiadatok.egyenleg FROM bankiadatok INNER JOIN felhasznalok ON bankiadatok.felh_id=felhasznalok.id WHERE felhasznalok.felhasznalonev= @uname;", conn);
                command2.Parameters.AddWithValue("@uname", uname);

                Int32 egyenleg = 0;

                SqlDataReader dataReader = command2.ExecuteReader();
                while (dataReader.Read())
                    egyenleg = Convert.ToInt32(dataReader["egyenleg"]);
                dataReader.Close();

                if (db == 1)
                {
                    string guid = Guid.NewGuid().ToString();

                    lock (felh)
                    {
                        felh.Add(new Felhasznalo(uname, passwd, guid, egyenleg));
                    }
                    return guid;
                }
                else
                {
                    return "0"; //Ha 0 akkor rossz a jelszo v. a felh.nev!!
                }

            }
            catch (SqlException)
            {
                Hiba hiba = new Hiba();
                hiba.HibaTipusa = "Adatbázis elérési hiba!";
                hiba.Muvelet = "Bejelentkezés";
                throw new FaultException<Hiba>(hiba);
            }
            catch (Exception)
            {
                Hiba hiba = new Hiba();
                hiba.HibaTipusa = "Valami nagy hiba történt, kérjük próbálja meg később!";
                hiba.Muvelet = "Bejelentkezés";
                throw new FaultException<Hiba>(hiba);
            }
            finally
            {
                conn.Close();
            }
        }

        public string Kijelentkezes(string uid)
        {
            try
            {
                Felhasznalo f = ellenorzes(uid);
                lock (felh)
                {
                    felh.Remove(f);
                }
                return string.Empty;
            }
            catch (Exception)
            {
                Hiba hiba = new Hiba();
                hiba.HibaTipusa = "Valami nagy hiba történt, kérjük próbálja meg később!";
                hiba.Muvelet = "Kijelentkezés";
                throw new FaultException<Hiba>(hiba);
            }
        }

        public string Feltoltes(int osszeg, string uid) //kliens ellenorizze az osszeget!!
        {
            Felhasznalo f = ellenorzes(uid);

            if (f == null)
            {
                return "Ez a funkció csak bejelentkezés után érhető el.";
            }

            SqlConnection conn = DatabaseManager.getConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT id FROM felhasznalok WHERE felhasznalonev= @uname;", conn);
                command.Parameters.AddWithValue("@uname", f.Nev);

                Int32 id = 0;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                }
                reader.Close();

                SqlCommand command2 = new SqlCommand("SELECT bankiadatok.egyenleg FROM bankiadatok INNER JOIN felhasznalok ON bankiadatok.felh_id=felhasznalok.id WHERE felhasznalok.id= @id;", conn);

                command2.Parameters.AddWithValue("@id", id);

                Int32 egyenleg = 0;

                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                    egyenleg = Convert.ToInt32(reader2["egyenleg"]);
                reader2.Close();

                f.Egyenleg = egyenleg;

                SqlCommand command3 = new SqlCommand("UPDATE bankiadatok SET egyenleg= @egyenleg WHERE felh_id= @id;", conn);
                command3.Parameters.AddWithValue("@egyenleg", egyenleg + osszeg);
                command3.Parameters.AddWithValue("@id", id);
                command3.ExecuteNonQuery();

                f.Egyenleg += osszeg;

                return (egyenleg + osszeg).ToString();
            }
            catch (SqlException)
            {
                Hiba hiba = new Hiba();
                hiba.HibaTipusa = "Adatbázis elérési hiba!";
                hiba.Muvelet = "Feltöltés";
                throw new FaultException<Hiba>(hiba);
            }
            catch (Exception)
            {
                Hiba hiba = new Hiba();
                hiba.HibaTipusa = "Valami nagy hiba történt, kérjük próbálja meg később!";
                hiba.Muvelet = "Feltöltés";
                throw new FaultException<Hiba>(hiba);
            }
            finally
            {
                conn.Close();
            }
        }

        public string Lekerdezes(string uid)
        {
            Felhasznalo f = ellenorzes(uid);

            if (f == null)
            {
                return "Ez a funkció csak bejelentkezés után érhető el.";
            }

            SqlConnection conn = DatabaseManager.getConnection();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT id FROM felhasznalok WHERE felhasznalonev= @uname;", conn);
                command.Parameters.AddWithValue("@uname", f.Nev);

                Int32 id = 0;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                }
                reader.Close();

                SqlCommand command2 = new SqlCommand("SELECT bankiadatok.egyenleg FROM bankiadatok INNER JOIN felhasznalok ON bankiadatok.felh_id=felhasznalok.id WHERE felhasznalok.id= @id;", conn);
                command2.Parameters.AddWithValue("@id", id);

                Int32 egyenleg = 0;

                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                    egyenleg = Convert.ToInt32(reader2["egyenleg"]);

                reader2.Close();

                f.Egyenleg = egyenleg;

                return egyenleg.ToString();
            }
            catch (SqlException)
            {
                Hiba hiba = new Hiba();
                hiba.HibaTipusa = "Adatbázis elérési hiba!";
                hiba.Muvelet = "Lekérdezés";
                throw new FaultException<Hiba>(hiba);
            }
            catch (Exception)
            {
                Hiba hiba = new Hiba();
                hiba.HibaTipusa = "Valami nagy hiba történt, kérjük próbálja meg később!";
                hiba.Muvelet = "Lekérdezés";
                throw new FaultException<Hiba>(hiba);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Utalasok> UtalasokList(string uid)
        {
            List<Utalasok> utalasok = new List<Utalasok>();

            Felhasznalo f = ellenorzes(uid);

            SqlConnection conn = DatabaseManager.getConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT id FROM felhasznalok WHERE felhasznalonev= @uname;", conn);
                command.Parameters.AddWithValue("@uname", f.Nev);

                Int32 sajatid = 0;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    sajatid = Convert.ToInt32(reader["id"]);
                }
                reader.Close();

                SqlCommand command2 = new SqlCommand("SELECT felhasznalok.felhasznalonev, utalasok.mikor, utalasok.mennyit FROM utalasok INNER JOIN felhasznalok ON utalasok.kinek = felhasznalok.id WHERE utalasok.kitol= @sajatid;", conn);
                command2.Parameters.AddWithValue("@sajatid", sajatid);

                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    string nev = reader2.GetString(0);
                    int osszeg = reader2.GetInt32(2);
                    DateTime ido = reader2.GetDateTime(1);
                    utalasok.Add(new Utalasok(nev, osszeg, ido));
                }
                reader2.Close();

                return utalasok;

            }
            catch (SqlException)
            {
                Hiba hiba = new Hiba();
                hiba.HibaTipusa = "Adatbázis elérési hiba!";
                hiba.Muvelet = "Utalások listázása";
                throw new FaultException<Hiba>(hiba);
            }
            catch (Exception)
            {
                Hiba hiba = new Hiba();
                hiba.HibaTipusa = "Valami nagy hiba történt, kérjük próbálja meg később!";
                hiba.Muvelet = "Utalások listázása";
                throw new FaultException<Hiba>(hiba);

            }
            finally
            {
                conn.Close();
            }
        }

        public Utal Utalas(string felhnev, int osszeg, string uid)
        {
            Felhasznalo f = ellenorzes(uid);

            SqlConnection conn = DatabaseManager.getConnection();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT id FROM felhasznalok WHERE felhasznalonev= @uname;", conn);
                command.Parameters.AddWithValue("@uname", f.Nev);

                Int32 kuldoid = 0;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    kuldoid = Convert.ToInt32(reader["id"]);
                }
                reader.Close();

                SqlCommand comman2 = new SqlCommand("SELECT bankiadatok.egyenleg FROM bankiadatok INNER JOIN felhasznalok ON bankiadatok.felh_id=felhasznalok.id WHERE felhasznalok.id= @id;", conn);
                comman2.Parameters.AddWithValue("@id", kuldoid);

                Int32 egyenlegkuldo = 0;

                SqlDataReader reade2 = comman2.ExecuteReader();

                while (reade2.Read())
                    egyenlegkuldo = Convert.ToInt32(reade2["egyenleg"]);
                reade2.Close();

                if (egyenlegkuldo < osszeg)
                {
                    Utal utal = new Utal();
                    utal.Felhnev = felhnev;
                    utal.Osszeg = osszeg;
                    utal.Eredmeny = false;
                    return utal;
                }

                SqlCommand command2 = new SqlCommand("SELECT id FROM felhasznalok WHERE felhasznalonev= @uname;", conn);
                command2.Parameters.AddWithValue("@uname", felhnev);

                Int32 cimzetid = 0;
                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    cimzetid = Convert.ToInt32(reader2["id"]);
                }
                reader2.Close();

                if (cimzetid > 0)
                {
                    SqlCommand command3 = new SqlCommand("INSERT INTO utalasok (kitol,kinek,mikor,mennyit) VALUES (@kuldoid,@cimzetid,@ido,@osszeg)", conn);
                    command3.Parameters.Add("@kuldoid", SqlDbType.BigInt).Value = kuldoid;
                    command3.Parameters.Add("@cimzetid", SqlDbType.BigInt).Value = cimzetid;
                    command3.Parameters.Add("@ido", SqlDbType.DateTime).Value = DateTime.Now;
                    command3.Parameters.Add("@osszeg", SqlDbType.BigInt).Value = osszeg;

                    command3.ExecuteNonQuery();

                    f.Egyenleg = egyenlegkuldo;
                    f.Egyenleg -= osszeg;

                    SqlCommand command5 = new SqlCommand("UPDATE bankiadatok SET egyenleg= @egyenleg WHERE felh_id= @id;", conn);
                    command5.Parameters.AddWithValue("@egyenleg", egyenlegkuldo - osszeg);
                    command5.Parameters.AddWithValue("@id", kuldoid);
                    command5.ExecuteNonQuery();


                    SqlCommand command4 = new SqlCommand("SELECT bankiadatok.egyenleg FROM bankiadatok INNER JOIN felhasznalok ON bankiadatok.felh_id=felhasznalok.id WHERE felhasznalok.id= @id;", conn);
                    command4.Parameters.AddWithValue("@id", cimzetid);

                    Int32 egyenlegcimzet = 0;

                    SqlDataReader reader4 = command4.ExecuteReader();

                    while (reader4.Read())
                        egyenlegcimzet = Convert.ToInt32(reader4["egyenleg"]);
                    reader4.Close();

                    SqlCommand command6 = new SqlCommand("UPDATE bankiadatok SET egyenleg= @egyenleg WHERE felh_id= @id;", conn);
                    command6.Parameters.AddWithValue("@egyenleg", egyenlegcimzet + osszeg);
                    command6.Parameters.AddWithValue("@id", cimzetid);
                    command6.ExecuteNonQuery();

                    Utal utal = new Utal();
                    utal.Felhnev = felhnev;
                    utal.Osszeg = osszeg;
                    utal.Eredmeny = true;
                    return utal;
                }
                else
                {
                    Utal utal = new Utal();
                    utal.Felhnev = felhnev;
                    utal.Osszeg = osszeg;
                    utal.Eredmeny = false;
                    return utal;
                }
            }
            catch (SqlException)
            {
                Hiba hiba = new Hiba();
                hiba.HibaTipusa = "Adatbázis elérési hiba!";
                hiba.Muvelet = "Utalás";
                throw new FaultException<Hiba>(hiba);
            }
            catch (Exception)
            {
                Hiba hiba = new Hiba();
                hiba.HibaTipusa = "Valami nagy hiba történt, kérjük próbálja meg később!";
                hiba.Muvelet = "Utalás";
                throw new FaultException<Hiba>(hiba);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
