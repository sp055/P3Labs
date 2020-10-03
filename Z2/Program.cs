using System;
using System.Diagnostics;

namespace Z2
{
    class Program
    {
        enum Wyliczenia
        {
            Wariant1,
            Wariant2,
            Wariant3
        }

        enum Predkosc
        {
            Wolno,
            Szybko,
            BardzoSzybko
        }

        [Flags]
        enum RGB        //000
        {
            Czerwony = 1,   //001
            Zielony = 2,    //010
            Niebieski = 4   //100
        }

        static void Funkcja(int liczba)
        {
            Console.WriteLine("F: " + liczba);
            liczba = 200;
            Console.WriteLine("F: " + liczba);
        }

        static void FunkcjaTab(int[] tablica)
        {
            Console.WriteLine("F: " + tablica[0]);
            tablica[0] = 200;
            Console.WriteLine("F: " + tablica[0]);
        }

        static void Main(string[] args)
        {
            int zmienna = 100;
            float zmiennoprzecinkowaF = 2.5f;
            double zmiennoprzecinkowaD = 2.5;
            char litera = 'h';
            string slowo = "haha";
            var zmiennaVar = 25;
            int[] tablica = { 1, 2, 3 };
            bool warunek = true;

            #region
            /*Console.WriteLine("M: " + tablica[0]);
            FunkcjaTab(tablica);
            Console.WriteLine("M: " + tablica[0]);
            Console.WriteLine("Podaj słowo: ");
            string odpowiedz = Console.ReadLine();
            Console.WriteLine($"Wpisałeś słowo: {odpowiedz}");

            Console.WriteLine("Podaj liczbę: ");
            string odpowiedz = Console.ReadLine();
            Console.WriteLine($"Wpisałeś liczbę: {odpowiedz}");
            //try
            //{
            //var liczbaOdUzytkownika = Convert.ToInt32(odpowiedz);
            //var liczbaOdUzytkownika = int.Parse(odpowiedz);

            int liczbaOdUzytkownika;
            bool czySieUdalo = int.TryParse(odpowiedz, out liczbaOdUzytkownika);
            if (czySieUdalo)
            {
                int wynik = liczbaOdUzytkownika + 100;
                Console.WriteLine($"Twoja liczba + 100 to: {wynik}");
            }
            else
            {
                Console.WriteLine("Nie udało się sparsować liczby");
            }
                
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Nie udało się sparsować liczby");
            //    Console.WriteLine(e.Message);
            //}*/

            /*float wynik = 10.0f / 3.0f;
            double wynik2 = 10 / 3.0;

            Console.WriteLine(wynik);
            Console.WriteLine(wynik2);*/
            #endregion

            /*Wyliczenia wyliczenie = Wyliczenia.Wariant1;
            Wyliczenia wyliczenie2 = (Wyliczenia)2;
            Wyliczenia wyliczenie3 = (Wyliczenia)Enum.Parse(typeof(Wyliczenia), "Wariant2");
            Console.WriteLine(wyliczenie);
            Console.WriteLine(wyliczenie2);
            Console.WriteLine(wyliczenie3);*/

            Predkosc wybranaPredkosc = Predkosc.BardzoSzybko;

            switch (wybranaPredkosc)
            {
                case Predkosc.Wolno:
                    Console.WriteLine("Ustawiono predkosc na 0.1m/s");
                    break;
                case Predkosc.Szybko:
                    Console.WriteLine("Ustawiono predkosc na 0.5m/s");
                    break;
                case Predkosc.BardzoSzybko:
                    Console.WriteLine("Ustawiono predkosc na 1m/s");
                    break;
                default:
                    break;
            }

            RGB kolor = RGB.Czerwony;
            kolor |= RGB.Niebieski;

            switch (kolor)
            {
                case RGB.Czerwony:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case RGB.Zielony:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case RGB.Niebieski:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case RGB.Niebieski | RGB.Czerwony:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Koniec programu");
        }
    }
}
