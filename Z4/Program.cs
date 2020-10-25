using System;

namespace Z4
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt nowyProdukt = new Produkt("Chleb", 10, "12345678");
            nowyProdukt.Stan = 25;
            var innyProdukt = new Produkt("Bułka", 0.5m, "43525");
            innyProdukt.Stan = 10;

            Transakcja transakcja = new Transakcja
            {
                Czas = DateTime.Now,
                Kwota = 20
            };

            Console.WriteLine(nowyProdukt.Cena);
            nowyProdukt.Cena = 15;
            Console.WriteLine(nowyProdukt.Cena);
            nowyProdukt.Sprzedaj();
            Console.WriteLine(nowyProdukt.Stan);
            Console.WriteLine(innyProdukt.Stan);

            Produkt.RozpocznijPromocje(nowyProdukt);

            var obiektAnonimowy = new
            {
                liczba = 10,
                produkt = nowyProdukt
            };
            Console.WriteLine(obiektAnonimowy.liczba + obiektAnonimowy.produkt.KodKreskowy);

            (int id, DateTime czas2, decimal kwota) = new Transakcja().ZwrocInfo();
            Console.WriteLine(czas2);
        }
    }
}
