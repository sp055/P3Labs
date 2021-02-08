using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolokwium2_1
{
    class Program
    {
        public class MagazynLogistyczny
        {
            public event EventHandler<PaczkaEventArgs> BrakPaczki;
            private List<int> listaid = new List<int>();
            public List<int> ListaId
            {
                get
                {
                    return listaid;
                }
                set
                {
                    listaid = value;
                }
            }

            public void Handler_SzukanoPaczki(object sender, PaczkaEventArgs e)
            {
                if (ListaId.Contains(e.IDpaczki))
                    Console.WriteLine($"Znaleziono paczkę o id: {e.IDpaczki}");
                else
                    BrakPaczki?.Invoke(this, new PaczkaEventArgs { IDpaczki = e.IDpaczki });
            }
        }


        public class PunktDystrybucji
        {
            public event EventHandler<PaczkaEventArgs> SzukanoPaczki;

            public void SzukajPaczki(int id)
            {
                SzukanoPaczki?.Invoke(this, new PaczkaEventArgs { IDpaczki = id });
            }

            public void Handler_BrakPaczki(object sender, PaczkaEventArgs e)
            {
                Console.WriteLine($"Paczka o id: {e.IDpaczki} nie została odnaleziona.");
            }
        }

        public class Paczkomat
        {
            public event EventHandler<PaczkaEventArgs> WyslanoPaczke;
            public void WyslijPaczke(int id)
            {
                WyslanoPaczke?.Invoke(this, new PaczkaEventArgs { IDpaczki = id });
            }
        }

        public class PaczkaEventArgs : EventArgs
        {
            public int IDpaczki { get; set; }
        }

        public class MojaKlasa<Typ1, Typ2>
        {
            public void GenerujSlownik(List<Typ1> typ1, List<Typ2> typ2)
            {
                Dictionary<Typ1, Typ2> openWith = new Dictionary<Typ1, Typ2>();

                for (int i = 0; i < typ1.Count; i++)
                {
                    openWith.Add(typ1[i], typ2[i]);
                }

                foreach (var item in openWith)
                {
                    Console.WriteLine($"{item.Key} | {item.Value}");
                }

            }
        }

        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
            Zadanie3();
        }

        static void Zadanie1()
        {
            string str;
            str = Console.ReadLine();
            char[] characters = str.ToCharArray();

            var collection = characters.OrderBy(x => x).Distinct();
            foreach (var item in collection)
            {
                Console.Write(item);
            }
        }
        static void Zadanie2()
        {
            var a = new List<int> { 1, 2, 3 };
            var b = new List<string> { "fajnie", "fajnie", "fajnie" };
            var klasa = new MojaKlasa<int, string>();

            klasa.GenerujSlownik(a, b);
        }
        static void Zadanie3()
        {
            var magazyn = new MagazynLogistyczny();
            var punktd = new PunktDystrybucji();
            var paczkomat = new Paczkomat();

            magazyn.ListaId.Add(12345);
            magazyn.ListaId.Add(67890);
            magazyn.ListaId.Add(14525);
            magazyn.ListaId.Add(13457);
            magazyn.ListaId.Add(97364);

            int idpaczki = 67890;

            punktd.SzukanoPaczki += magazyn.Handler_SzukanoPaczki;
            magazyn.BrakPaczki += punktd.Handler_BrakPaczki;

            punktd.SzukajPaczki(idpaczki);
        }













    }
}

