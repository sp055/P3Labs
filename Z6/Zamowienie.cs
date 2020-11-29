using System;
using System.Collections.Generic;
using System.Text;

namespace Z6
{
    public class Zamowienie
    {
        public Zamowienie(Sklep sklep, List<Produkt> produkty)
        {
            Sklep = sklep;
            Produkty = produkty;
        }
        public Sklep Sklep { get; set; }
        public List<Produkt> Produkty { get; set; }
    }
}
