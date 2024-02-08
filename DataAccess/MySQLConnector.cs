using System;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class MySQLConnector
    {
        public const string DB_CONNECTION_SUCCESSFUL = "DB-Verbindung erfolgreich";

        private MySqlConnection dbVerbindung = null;

        // Hostname oder IP-Adresse des Datenbankservers
        private String dBHost = "localhost";
        public String DBHost
        {
            get { return dBHost; }
            set { dBHost = value; }
        }

        // Benutzername für die Datenbankverbindung
        private String dBUser = "root";
        public String DBUser
        {
            get { return dBUser; }
            set { dBUser = value; }
        }

        // Passwort für die Datenbankverbindung
        private String dBPass = "";
        public String DBPasswort
        {
            get { return dBPass; }
            set { dBPass = value; }
        }

        // Name der Datenbank
        private String dbName = "kleidershop";
        public String DbName
        {
            get { return dbName; }
            set { dbName = value; }
        }

        private MySqlConnectionStringBuilder mysqlConnectionStringBuilder = new MySqlConnectionStringBuilder();

        // Verbindungszeichenfolge für die MySQL-Datenbank
        public String ConnectionString
        {
            get
            {
                mysqlConnectionStringBuilder.Server = DBHost;
                mysqlConnectionStringBuilder.UserID = DBUser;
                mysqlConnectionStringBuilder.Password = DBPasswort;
                mysqlConnectionStringBuilder.Database = DbName;

                return mysqlConnectionStringBuilder.ConnectionString;
            }
        }

        /// <summary>
        /// Schließt vorhandene Datenbankverbindungen.
        /// </summary>
        public void CloseConnection()
        {
            if (dbVerbindung != null && dbVerbindung.State == System.Data.ConnectionState.Open)
                dbVerbindung.Close();
        }

        /// <summary>
        /// Führt eine SQL-Abfrage aus und gibt einen MySqlDataReader zurück.
        /// </summary>
        public MySqlDataReader executeQuery(string sql)
        {
            MySqlDataReader datareader = null;
            dbVerbindung = new MySqlConnection(this.ConnectionString);

            dbVerbindung.Open();

            MySqlCommand sqlcommand = dbVerbindung.CreateCommand();
            sqlcommand.CommandText = sql;
            datareader = sqlcommand.ExecuteReader();

            return datareader;
        }

        /// <summary>
        /// Führt eine SQL-Anweisung aus, die keine Abfrage ist, und gibt die Anzahl der betroffenen Zeilen zurück.
        /// </summary>
        public int executeNonQuery(String dml)
        {
            int retValue = -1;

            using (MySqlConnection connection = new MySqlConnection(this.ConnectionString))
            {
                connection.Open();

                MySqlCommand sqlcommand = new MySqlCommand(dml, connection);
                retValue = sqlcommand.ExecuteNonQuery();
            }

            return retValue;
        }

        /// <summary>
        /// Testet die Datenbankverbindung, indem versucht wird, eine Abfrage auszuführen.
        /// </summary>
        public String testConnection()
        {
            String msg = DB_CONNECTION_SUCCESSFUL;
            String sql = "SHOW tables; ";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand sqlcommand = new MySqlCommand(sql, connection);
                sqlcommand.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                msg = ex.GetBaseException().Message;
            }
            return msg;
        }
    }
}
