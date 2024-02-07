using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class DbManager
    {
        private string connectionString = "server=localhost;user=root;database=kleidershop;password=;";

        public void ConnectToDatabase()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Erfolgreich mit der Datenbank verbunden.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Fehler beim Verbinden mit der Datenbank: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }

    // Weitere Methoden zum Ausführen verschiedener Arten von Abfragen können hier hinzugefügt werden
}


