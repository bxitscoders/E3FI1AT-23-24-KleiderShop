using System;
using System.Collections.Generic;
using DataAccess;
using Model;

namespace DataAccess
{
    public static class DbManager
    {
        public static List<Produkt> alleProdukte = new List<Produkt>();
        public static Produkt aktuellerProdukt = new Produkt();
        static MySQLConnector mysqlConnector = new MySQLConnector();

        public static void loescheDantensatz()
        {
            string loeschString = "DELETE FROM produkt WHERE id="+ aktuellerProdukt.id + ";";
            mysqlConnector.executeNonQuery(loeschString);
        }

        public static void holeDatensatz()
        {
            string selectString = "SELECT id, Produktname, Beschreibung, Artikelnummer, Kategorie, Preis, Verfügbarkeit, Lagermenge FROM produkt";

            mysqlConnector.executeQuery(selectString);

        }

        public static void fuegeDatensatzHinzu()
        {
            string produkt = aktuellerProdukt.Produktname;
            string beschreibung = aktuellerProdukt.Beschreibung;
            string artikelnummer = aktuellerProdukt.Artikelnummer;
            string kategorie = aktuellerProdukt.Kategorie;
            string preis = aktuellerProdukt.Preis.ToString();
            string verfuegbarkeit = aktuellerProdukt.Verfuegbarkeit;
            string lagermenge = aktuellerProdukt.Lagermenge.ToString();
            string hinzufuegenString = "INSERT INTO produkt(Produktname, Beschreibung, Artikelnummer, Kategorie, Preis, Verfügbarkeit, Lagermenge) VALUES ("+ produkt + beschreibung + artikelnummer + kategorie + preis + verfuegbarkeit + lagermenge + ")";

            mysqlConnector.executeNonQuery(hinzufuegenString);
        }

        public static void updateDatenzsatz()
        {
            string updateString = "UPDATE produkt SET ";

            mysqlConnector.executeNonQuery(updateString);
        }
    }
}
