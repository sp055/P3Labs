using System;
using System.Collections.Generic;
using System.Text;

namespace Z5
{
    class Ksiazka
    {
        public string Autor { get; set; }
        public string Tytul { get; set; }
        private int Regal;
        private int Polka;
        private int Miejsce;

        public (int regal, int polka, int miejsce) WypiszPozycje()
        {
            return (Regal, Polka, Miejsce);
        }

        public Ksiazka(string autor, string tytul, int regal, int polka, int miejsce)
        {
            Autor = autor;
            Tytul = tytul;
            Regal = regal;
            Polka = polka;
            Miejsce = miejsce;
        }
    }
}
