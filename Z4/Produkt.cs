using System;
using System.Collections.Generic;
using System.Text;

namespace Z4
{
    public class Produkt
    {
        public int Id { get; private set; }
        public string Nazwa { get; set; }

        private decimal _cena;
        public decimal Cena
        {
            get
            {
                return _cena;
            }
            set
            {
                if (value >= 0)
                {
                    _cena = value;
                }
                else
                {
                    throw new ArgumentException("Cena nie może być ujemna");
                }
            }
        }

        public string KodKreskowy;
        public readonly string Tekst; // tylko można odczytać
        private static int _maxId = 1;


        public static void RozpocznijPromocje(Produkt produkt)
        {
            produkt.Cena /= 2;
        }
        /// <summary>
        /// Ilość produktów na magazynie
        /// </summary>
        public decimal Stan;

        public void Sprzedaj()
        {
            Stan--;
        }

        private Produkt()
        {

        }
        public Produkt(string nazwa, decimal cena, string kodKreskowy)
        {
            Id = _maxId++;
            Nazwa = nazwa;
            Cena = cena;
            KodKreskowy = kodKreskowy;
        }
    }
}
