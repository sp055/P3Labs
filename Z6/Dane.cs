using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Z6
{
    public static class Dane
    {
        public static Sklep[] Sklepy = new[]
        {
            new Sklep("Żabka", "Kwiatowa 10"),
            new Sklep("Polomarket", "Żelazna 1"),
            new Sklep("Delikatesy", "Szkolna 200")
        };

        public static Produkt[] Produkty = new[]
        {
            new Produkt(1, "Bułka pszenna", 0.6m),
            new Produkt(2, "Snickers", 1.5m),
            new Produkt(3, "Śmietana 18%", 2.99m),
            new Produkt(4, "Pomidory", 4.99m),
            new Produkt(5, "Szynka", 25.99m)
        };
    }

    public class Sklep
    {
        public Sklep(string nazwa, string adres)
        {
            Nazwa = nazwa;
            Adres = adres;
        }

        public string Nazwa { get; set; }
        public string Adres { get; set; }
    }

    public class Produkt
    {
        public Produkt(int id, string nazwa, decimal cena)
        {
            Id = id;
            Nazwa = nazwa;
            Cena = cena;
        }

        public int Id { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }

        public override string ToString()
        {
            return Nazwa;
        }
    }
}
