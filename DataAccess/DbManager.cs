using System;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public static class DbManager
    {
      
        public static void loesceDantensatz()
        {
            string loeschString = "DELETE FROM produkt WHERE id=";
        }

        public static void holenDatensatz()
        {
            string selectString = "SELECT id, Produktname, Beschreibung, Artikelnummer, Kategorie, Preis, Verfügbarkeit, Lagermenge FROM produkt";
        }


        public static void fuegeDatensatzHinzu()
        {
            string hinzufuegenString = "INSERT INTO produkt(Produktname, Beschreibung, Artikelnummer, Kategorie, Preis, Verfügbarkeit, Lagermenge) VALUES ()";
        }

        public static void updateDatenzsatz()
        {
            string updateString = "UPDATE produkt SET ";
        }
    }
}
