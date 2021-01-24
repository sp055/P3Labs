using System;
using System.Collections.Generic;
using System.Text;

namespace Z9
{
    public class Kucharz
    {
        Queue<DanieWKolejce> KolejkaDan;
        public void Kelner_PrzyjetoZamowienie(object sender, PrzyjetoZamowienieEventArgs e)
        {
            Console.WriteLine($"Kucharz zauważaył zamówienie na {e.NazwaDania}");
            KolejkaDan.Enqueue(new DanieWKolejce() { Nazwa = e.NazwaDania });
        }

        public void Gotuj()
        {
            var danie = KolejkaDan.Dequeue();
            Console.WriteLine($"Kucharz gotuje {danie.Nazwa}");
        }
        public Kucharz()
        {
            KolejkaDan = new Queue<DanieWKolejce>();
        }
    }
}
