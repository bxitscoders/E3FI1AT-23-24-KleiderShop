using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produkt
    {
        public int id { get; set; }
        public string Produktname { get; set; }
        public string Beschreibung { get; set; }
        public string Artikelnummer { get; set; }
        public string Kategorie { get; set; }
        public double Preis { get; set; }
        public string Verfuegbarkeit { get; set; }
        public int Lagermenge { get; set; }

    }
}
