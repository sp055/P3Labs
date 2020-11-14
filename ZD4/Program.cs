using System;
using System.Text.RegularExpressions;

namespace ZD4
{
    public class Ksiazka
    {
        public string Tytul;
        public string Autor;
        public int NrRegalu;
        public int NrPolki;
        public int NrMiejsca;

        public Ksiazka(string autor, string tytul, int nrRegalu, int nrPolki, int nrMiejsca)
        {
            Autor = autor;
            Tytul = tytul;
            NrRegalu = nrRegalu;
            NrPolki = nrPolki;
            NrMiejsca = nrMiejsca;
        }
    }
    class Program
    {
        static readonly int pierwsza = 3, druga = 6, trzecia = 10;

        static void Main()
        {
            Ksiazka[,,] tablica = new Ksiazka[pierwsza, druga, trzecia];

            WstawienieNaMiejsca(tablica);
            //SprawdzenieCzyTamJest(tablica);
            Console.WriteLine("Czego szukasz?");
            string szukana = Console.ReadLine();
            Szukanie(tablica, szukana.ToUpper());                                                   // przesyła tablice i to co wpisał użytkownik w UPPERCASE
        }
        static void Szukanie(Ksiazka[,,] tablica, string szukana)                                   // funkcja wyszukuje czy dana książka gdzieś się znajduje
        {
            bool jest;
            for (int i = 0; i < pierwsza; i++)
            {
                for (int j = 0; j < druga; j++)
                {
                    for (int k = 0; k < trzecia; k++)
                    {
                        jest = tablica[i, j, k].Autor.ToUpper().Contains(szukana) ^ tablica[i, j, k].Tytul.ToUpper().Contains(szukana);       // sprawdza czy ciąg znaków podany przez użytkownika istnieje gdzieś w książkach
                        if (jest == true)                                                           // jeśli istnieje to wypisuje dane książki i w którym miejscu jest
                        {
                            Console.WriteLine($"Książka której prawdopodobnie szukasz: {tablica[i, j, k].Autor} '{tablica[i, j, k].Tytul}' " +
                                $"Znajduje się na {tablica[i, j, k].NrRegalu} regale, {tablica[i, j, k].NrPolki} półce i {tablica[i, j, k].NrMiejsca} miejscu");
                            System.Environment.Exit(1);
                        }
                    }
                }
            }
            Console.WriteLine("Nic nie znaleziono.");
        }

        static void WstawienieNaMiejsca(Ksiazka[,,] tablica)                                        // rozkłada książki na miejscach
        {
            Ksiazka a;
            Ksiazka b = new Ksiazka("Jonny Bravo", "Jak osiągnąć sukces w 30min", 2, 5, 3);

            for (int i = 0; i < pierwsza; i++)
            {
                for (int j = 0; j < druga; j++)
                {
                    for (int k = 0; k < trzecia; k++)
                    {
                        a = new Ksiazka("Shrek", "Moje bagno", i + 1, j + 1, k + 1);
                        tablica[i, j, k] = a;
                    }
                }
            }
            tablica[2, 5, 3] = b;
        }

        static void SprawdzenieCzyTamJest(Ksiazka[,,] tablica)                                      // testowa funkcja do sprawdzenia czy książki są tam gdzie powinny
        {
            for (int i = 0; i < pierwsza; i++)
            {
                for (int j = 0; j < druga; j++)
                {
                    for (int k = 0; k < trzecia; k++)
                    {
                        Console.WriteLine($"Autor: {tablica[i, j, k].Autor} '{tablica[i, j, k].Tytul}' " +
                            $"Regał: {tablica[i, j, k].NrRegalu} Półka: {tablica[i, j, k].NrPolki} Miejsce: {tablica[i, j, k].NrMiejsca}");
                    }
                }
            }
        }
    }
}