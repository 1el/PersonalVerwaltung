using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PersonalVerwaltung
{
    public class Datenbank
    {
        private MySqlConnection dbConnection;

        public void dbConnect()
        {
            try
            {
                dbConnection = new MySqlConnection("SERVER=localhost; DATABASE=il14; UID=perschef; PASSWORD=1234; SSLMODE = NONE; Convert Zero Datetime = True;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editDB(string sqlText)
        {
            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = sqlText;
            dbConnection.Open();
            comm.ExecuteNonQuery();
            dbConnection.Close();
        }

        #region Mitarbeiter
        public List<Mitarbeiter> getMitarbeiterFromDB()
        {
            List<Mitarbeiter> lma = new List<Mitarbeiter>();

            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = "SELECT * FROM Mitarbeiter;";

            dbConnection.Open();
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                lma.Add(new Mitarbeiter(
                    reader.GetInt32(0), // id
                    reader.GetString(1), // nachname
                    reader.GetString(2), // vorname
                    reader.GetDateTime(3), // geburtsdatum
                    reader.IsDBNull(4) ? 0 : reader.GetInt32(4), // tagesarbeitszeit
                    reader.IsDBNull(5) ? 0 : reader.GetInt32(5) // urlaubsanspruch
                ));
            }

            reader.Close();
            dbConnection.Close();

            return lma;
        }

        public void saveNewMA(string id, string nachname, string vorname, DateTime geburtsdatum,
                                string arbeitszeit, string urlaubsanspruch)
        {
            editDB($"INSERT INTO Mitarbeiter VALUES ({id}, '{nachname}', '{vorname}', '{geburtsdatum.Year.ToString()}-{geburtsdatum.Month.ToString()}-{geburtsdatum.Day.ToString()}', {arbeitszeit}, {urlaubsanspruch});");
        }

        public void saveMA(string id, string nachname, string vorname, DateTime geburtsdatum,
                                string arbeitszeit, string urlaubsanspruch)
        {
            editDB($"UPDATE Mitarbeiter SET Nachname = '{nachname}', Vorname = '{vorname}', Geb_Datum = '{geburtsdatum.Year.ToString()}-{geburtsdatum.Month.ToString()}-{geburtsdatum.Day.ToString()}', Tagesarbeitszeit = {arbeitszeit}, UrlaubsanspruchJahr = {urlaubsanspruch} WHERE Ma_Id = {id};");
        }

        public void deleteMA(string id)
        {
            editDB($"DELETE FROM Mitarbeiter WHERE Ma_Id = {id};");
        }
        #endregion

        #region Einsatz
        public List<Einsatz> getEinsatzFromDB()
        {
            List<Einsatz> le = new List<Einsatz>();

            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = "SELECT * FROM einsatz;";

            dbConnection.Open();
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                le.Add(new Einsatz(
                    reader.GetInt32(0), // id
                    reader.GetInt32(1), // ma_id
                    reader.GetDateTime(2), // datum
                    reader.GetTimeSpan(3), // von
                    reader.GetTimeSpan(4) // bis
                ));
            }

            reader.Close();
            dbConnection.Close();

            return le;
        }

        public void saveNewEinsatz(string ma_id, DateTime datum, string von, string bis)
        {
            editDB($"INSERT INTO Einsatz VALUES (NULL, {ma_id}, '{datum.Year.ToString()}-{datum.Month.ToString()}-{datum.Day.ToString()}', '{von}', '{bis}');");
        }

        public void saveEinsatz(string id, string ma_id, DateTime datum, string von, string bis)
        {
            editDB($"UPDATE Einsatz SET Ma_Id = '{ma_id}', Datum = '{datum.Year.ToString()}-{datum.Month.ToString()}-{datum.Day.ToString()}', EinsatzVon_Zeit = '{von}', EinsatzBis_Zeit = '{bis}' WHERE E_Id = {id};");
        }

        public void deleteEinsatz(string id)
        {
            editDB($"DELETE FROM Einsatz WHERE E_Id = {id};");
        }
        #endregion

        #region Fehlgrund
        public List<Fehlgrund> getFehlgrundFromDB()
        {
            List<Fehlgrund> lfg = new List<Fehlgrund>();

            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = "SELECT * FROM fehlgrund;";

            dbConnection.Open();
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                lfg.Add(new Fehlgrund(
                    reader.GetInt32(0), // id
                    reader.GetString(1) // fehlgrund
                ));
            }

            reader.Close();
            dbConnection.Close();

            return lfg;
        }
        
        public void saveNewFehlgrund(string grund)
        {
            editDB($"INSERT INTO Fehlgrund VALUES (NULL, '{grund}');");
        }

        public void saveFehlgrund(string id, string grund)
        {
            editDB($"UPDATE Fehlgrund SET Grund = '{grund}' WHERE FG_Id = {id};");
        }

        public void deleteFehlgrund(string id)
        {
            editDB($"DELETE FROM Fehlgrund WHERE FG_Id = {id};");
        }
        #endregion

        #region Fehlzeit
        public List<Fehlzeit> getFehlzeitFromDB()
        {
            List<Fehlzeit> lfz = new List<Fehlzeit>();

            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = "SELECT FZ_Id, MA_Id, Von_Datum, Bis_Datum, Fehlgrund, DATEDIFF(bis_datum, von_datum)+1 as Fehltage FROM fehlzeit;";

            dbConnection.Open();
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                lfz.Add(new Fehlzeit(
                    reader.GetInt32(0), // id
                    reader.GetInt32(1), // ma_id
                    reader.GetDateTime(2), // von
                    reader.GetDateTime(3), // bis
                    reader.GetInt32(4), // fg_id
                    reader.GetInt32(5) // fehltage
                ));
            }

            reader.Close();
            dbConnection.Close();

            return lfz;
        }

        public void saveNewFehlzeit(string ma_id, DateTime von, DateTime bis, string fehlgrund)
        {
            editDB($"INSERT INTO Fehlzeit VALUES (NULL, {ma_id}, '{von.Year.ToString()}-{von.Month.ToString()}-{von.Day.ToString()}', '{bis.Year.ToString()}-{bis.Month.ToString()}-{bis.Day.ToString()}', {fehlgrund});");
        }

        public void saveFehlzeit(string id, string ma_id, DateTime von, DateTime bis, string fehlgrund)
        {
            editDB($"UPDATE Fehlzeit SET Ma_Id = {ma_id}, Von_Datum = '{von.Year.ToString()}-{von.Month.ToString()}-{von.Day.ToString()}', Bis_Datum = '{bis.Year.ToString()}-{bis.Month.ToString()}-{bis.Day.ToString()}', Fehlgrund = {fehlgrund} WHERE FZ_Id = {id};");
        }

        public void deleteFehlzeit(string id)
        {
            editDB($"DELETE FROM Fehlzeit WHERE FZ_Id = {id};");
        }
        #endregion
        
        public string[,] sendSelect(string s, int anzahl)
        {
            
            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = "SELECT COUNT(*)," + s;
            dbConnection.Open();

            MySqlDataReader reader = comm.ExecuteReader();
            reader.Read();
            int counter = reader.GetInt32(0);
            reader.Close();

            comm.CommandText = "SELECT" + s;

            MySqlDataReader reader2 = comm.ExecuteReader();
            string[,] queryResult = new string[counter, anzahl];
            int i = 0;
            while (reader2.Read())
            {
                for (int j = 0; j < anzahl; j++)
                    queryResult[i, j] = reader2.GetString(j);
                i++;
            }
            reader2.Close();
            dbConnection.Close();

            return queryResult;
        }

    } // end class
} // end namespace