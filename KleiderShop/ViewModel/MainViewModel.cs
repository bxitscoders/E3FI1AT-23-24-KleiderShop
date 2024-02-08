using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DataAccess;

namespace KleiderShop.ViewModel
{
    public class MainViewModel
    {
        private string produktName = "";
        public string ProduktName
        {
            get { return produktName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    produktName = value;
                }
            }
        }

        private string beschreibung = "";
        public string Beschreibung
        {
            get { return beschreibung; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    beschreibung = value;
                }
            }
        }

        private string artikelnummer = "";
        public string Artikelnummer
        {
            get { return artikelnummer; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    artikelnummer = value;
                }
            }
        }

        private string kategorie = "";
        public string Kategorie
        {
            get { return kategorie; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    kategorie = value;
                }
            }
        }

        private double preis = 0;
        public double Preis
        {
            get { return preis; }
            set
            {
                if (value > 0)
                {
                    preis = value;
                }
            }
        }

        private string verfuegbarkeit = "";
        public string Verfuegbarkeit
        {
            get { return verfuegbarkeit; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    verfuegbarkeit = value;
                }
            }
        }

        private int lagermenge = 0;
        public int Lagermenge
        {
            get { return lagermenge; }
            set
            {
                if (value > 0)
                {
                    lagermenge = value;
                }
            }
        }


    }
}

