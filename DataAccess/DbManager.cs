using System;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public static class DbManager
    {
        private const string connectionString = "server=localhost;user=root;database=kleidershop;password=;";

        private static MySqlConnection ConnectToDatabase()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            return connection;
        }

        public static void DbConnection()
        {
            MySqlConnection connection = ConnectToDatabase();
            try
            {
                string query = "INSERT INTO produkt (ProduktID, Produktname, Artikelnummer, Beschreibung, Preis, Kategorie, Verfügbarkeit, Lagermenge) " +
                               "VALUES (@ProduktID, @Produktname, @Artikelnummer, @Beschreibung, @Preis, @Kategorie, @Verfügbarkeit, @Lagermenge)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ProduktID", 2);
                cmd.Parameters.AddWithValue("@Produktname", "Name");
                cmd.Parameters.AddWithValue("@Artikelnummer", "464");
                cmd.Parameters.AddWithValue("@Beschreibung", "Beispiel.");
                cmd.Parameters.AddWithValue("@Preis", 40);
                cmd.Parameters.AddWithValue("@Kategorie", "BspKategorie");
                cmd.Parameters.AddWithValue("@Verfügbarkeit", 100);
                cmd.Parameters.AddWithValue("@Lagermenge", 1000);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Produkt erfolgreich eingefügt.");
                }
                else
                {
                    Console.WriteLine("Fehler beim Einfügen des Produkts.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Fehler beim Einfügen des Produkts: " + ex.Message);
            }
            finally
            {
                connection.Close(); // Verbindung schließen
            }
        }

    }
}
