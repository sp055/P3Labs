using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Z6
{
    class Program
    {

        public Dictionary<Produkt, int> Magazyn = new Dictionary<Produkt, int>()
        {
            {Dane.Produkty[0], 500 },
            {Dane.Produkty[0], 100 },
            {Dane.Produkty[0], 50 },
            {Dane.Produkty[0], 1000 },
            {Dane.Produkty[0], 750 }

        };

        public static Zamowienie[] Zamowienia = new[]
        {
            new Zamowienie(Dane.Sklepy[0],
                Enumerable.Repeat(Dane.Produkty[0], 30)
                .Concat(Enumerable.Repeat(Dane.Produkty[2], 50))
                .ToList()),
            new Zamowienie(Dane.Sklepy[1], Enumerable.Repeat(Dane.Produkty[2], 10).ToList()),
            new Zamowienie(Dane.Sklepy[2], Enumerable.Repeat(Dane.Produkty[4], 45).ToList()),
        };

        static void Main(string[] args)
        {
            #region
            /* foreach (var item in Zamowienia)
              {
                  Console.WriteLine($"{item.Sklep.Nazwa} {item.Produkty.Sum(x=>x.Cena)}");

                  var grupa = item.Produkty
                      .GroupBy((x) => x.Id);

                  foreach (var item2 in grupa)
                  {
                      Console.Write(item2.Key + " ");
                      Console.WriteLine(item2.Count());
                  }
              }*/
            #endregion
            #region
            /*
            var rand = new Random();

            var zmienna = Enumerable.Range(1, 100)
                .Select(x => new Produkt(x, $"Produkt{x}", (decimal)(rand.NextDouble() * 100)));

            var przefiltrowaneProdukty = zmienna.Where(x => x.Cena < 50);

            foreach (var item in przefiltrowaneProdukty)
            {
                Console.WriteLine($"{item.Nazwa} {item.Cena}");
            }*/
            #endregion

            var kolekcja = new[]
            {
                Dane.Produkty[0],
                Dane.Produkty[0],
                Dane.Produkty[1],
                Dane.Produkty[1],
                Dane.Produkty[2],
                Dane.Produkty[2],
                Dane.Produkty[3],
                Dane.Produkty[3],
                Dane.Produkty[4],
                Dane.Produkty[4],
            };

            var test = kolekcja.Except(new[] { Dane.Produkty[2], Dane.Produkty[4] }).ToList();

            foreach (var item in test)
            {
                Console.WriteLine(item.Nazwa);
            }

            Console.WriteLine(kolekcja.First().Cena);

            var teksty = new[] { "raz", "dwa", "trzy" };
            var liczby = new[] { 1, 2, 3 };

            var kolekcja2 = teksty.Zip(liczby, (x, y) => Enumerable.Repeat(x, y));

            foreach (var item in kolekcja2)
            {
                Console.WriteLine(item.FirstOrDefault());
            }
        }
    }
}
