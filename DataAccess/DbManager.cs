﻿using System;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public static class DbManager
    {
        public List<Produkt> alleProdukte = new List<Produkt>();
        public Produkt aktuellerProdukt = new Produkt();
        MySQLConnector mysqlConnector = new MySQLConnector();

        public static void loescheDantensatz()
        {
            string loeschString = "DELETE FROM produkt WHERE id="+ aktuellerProdukt.id + ";";
            mysqlConnector.executeNonQuery(loeschString);
        }

        public static void holeDatensatz()
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
