using System;

namespace ZD3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablica();
            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.Write("Wpisz tekst: ");
            Zdanie(Console.ReadLine());                                         // czyta tekst wpisany do konsoli i przesyla do funkcji
        }

        static void Tablica()
        {
            Random rnd = new Random();                                          // zastosowanie klasy random do losowania liczb
            int pierwszywymiar = 10;
            int suma = 0;
            int[][] tablica = new int[pierwszywymiar][];                        // stworzenie tablicy

            for (int i = 0; i < tablica.Length; i++)                            // wykonuje pętlę tyle razy ile wynosi wielkość pierwszego wymiaru
            {
                tablica[i] = new int[rnd.Next(10)];                             // losowanie wielkości drugiego wymiaru

                for (int j = 0; j < tablica[i].Length; j++)                     // wykonuje pętlę tyle razy ile wynosi wartość drugiego wymiaru dla wybranego wymiaru pierwszego
                {
                    tablica[i][j] = 1;                                          // do każdego pola przypisuje wartość 1
                    Console.Write("|" + tablica[i][j] + "|");                   // wypisuje wartości
                    suma += tablica[i][j];                                      // suma pól
                }
                Console.WriteLine();
            }
            Console.WriteLine("=======================");
            Console.WriteLine($"Suma wszystkich pól: {suma}");                  // wynik
        }

        static void Zdanie(string tekst)
        {
            tekst = tekst.Trim();                                               // usuwa spacje z początku i końca tekstu (jeśli na końcu nie ma innego znaku)

            if (string.IsNullOrWhiteSpace(tekst))                               // sprawdza czy tekst jest pusty lub zawiera tylko spacje jeśli tak wykonuje instrukcje
            {
                System.Console.WriteLine("Nie wpisałeś tekstu.");
                System.Environment.Exit(1);                                     // wychodzi z programu
            }
            else if (!char.IsLetter(tekst, 0))                                  // sprawdza czy pierwszy znak w tekscie jest literą jeśli nie jest to wykonuje instrukcje
            {
                System.Console.WriteLine("Nie zacząłeś od litery.");
                System.Environment.Exit(1);                                     // wychodzi z programu
            }

            tekst = char.ToUpper(tekst[0]) + tekst.Substring(1);                // podnosi pierwszy znak do UPPERCASE i dodaje resztę tekstu ze zmiennej tekst od pozycji 1

            if (tekst.EndsWith("."))                                            // sprawdza czy kończy się z kropką
            {
                Console.WriteLine(tekst);
            }
            else
            {
                Console.WriteLine(tekst + ".");                                 // dodaje kropkę do tekstu
            }
        }
    }
}
