using System;
using System.Linq;

namespace Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, //ilosc regalow
                b = 6, // ilosc polek
                c = 10; // ilosc miejsc

            Ksiazka[][][] biblioteka = new Ksiazka[a][][];

            for (int i = 0; i < a; i++)
            {
                biblioteka[i] = new Ksiazka[b][];
                for (int j = 0; j < b; j++)
                {
                    biblioteka[i][j] = new Ksiazka[c];
                    for (int k = 0; k < c; k++)
                    {
                        biblioteka[i][j][k] = new Ksiazka("Mickiewicz", "Dziady", i, j, k);
                    }
                }
            }

            biblioteka[1][3][8].Autor = "Słowacki";
            biblioteka[1][3][8].Tytul = "Balladyna";

            Console.WriteLine("Podaj szukaną frazę:");
            var szukanyTekst = Console.ReadLine();

            var znalezioneKsiazki = biblioteka.SelectMany(x => x).SelectMany(x => x)
                .Where(x => x.Autor.Contains(szukanyTekst, StringComparison.OrdinalIgnoreCase) || x.Tytul.Contains(szukanyTekst, StringComparison.OrdinalIgnoreCase));

            var znalezionaKsiazka = znalezioneKsiazki.FirstOrDefault();

            if (znalezionaKsiazka is null)
            {
                Console.WriteLine("Nic nie znaleziono.");
                return;
            }

            var pozycja = znalezionaKsiazka.WypiszPozycje();
            Console.WriteLine($"Znaleziono: {znalezionaKsiazka.Tytul}: {pozycja.regal}, {pozycja.polka}, {pozycja.miejsce}");

        }
    }
}
