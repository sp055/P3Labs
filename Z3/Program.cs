using System;
using System.Text;

namespace Z3
{
    class Program
    {
        static void Wypisz(int[] mojaTablica)
        {
            for (int i = 0; i < mojaTablica.Length; i++)
            {
                Console.WriteLine(mojaTablica[i]);
            }
            mojaTablica[0] = 100;
        }

        static int[,] StworzTablice(int x, int y)
        {
            return new int[x, y];
        }

        static void ZmienTekst(ref string tekst)
        {
            tekst = "nowy tekst";
        }

        static void FunkcjaParams(string drugiParametr, params string[] parametr)
        {
            for (int i = 0; i < parametr.Length; i++)
            {
                Console.WriteLine(parametr[i]);
            }
        }

        static void Main(string[] args)
        {
            #region
            /*(var rozmiar = int.Parse(Console.ReadLine());
            int[] tablica = new int[rozmiar];
            int[] tablicaWynikow = { 1, 1, 0, 3 };
            string[] tablicaTekstow;

            Wypisz(tablica);
            Wypisz(tablica);*/

            /*int[,] tablicaDwuwymiarowa = new int[2, 4];

            for (int i = 0; i < tablicaDwuwymiarowa.GetLength(0); i++)
            {
                for (int j = 0; j < tablicaDwuwymiarowa.GetLength(1); j++)
                {
                    tablicaDwuwymiarowa[i, j] = i * j;
                }
            }


            for (int i = 0; i < tablicaDwuwymiarowa.GetLength(0); i++)
            {
                for (int j = 0; j < tablicaDwuwymiarowa.GetLength(1); j++)
                {
                    Console.Write(tablicaDwuwymiarowa[i, j] + " ");
                }
                Console.WriteLine();
            }*/
            /*
            int[][] tablicaPoszarpana = new int[4][];

            for (int i = 0; i < tablicaPoszarpana.Length; i++)
            {
                tablicaPoszarpana[i] = new int[i + 1];
            }

            for (int i = 0; i < tablicaPoszarpana.Length; i++)
            {
                for (int j = 0; j < tablicaPoszarpana[i].Length; j++)
                {
                    tablicaPoszarpana[i][j] = i * j;
                }
            }

            for (int i = 0; i < tablicaPoszarpana.Length; i++)
            {
                for (int j = 0; j < tablicaPoszarpana[i].Length; j++)
                {
                    Console.Write(tablicaPoszarpana[i][j] + " ");
                }
                Console.WriteLine();
            }*/
            #endregion
            #region
            /*var tekst = "stary tekst";
            tekst += "1";
            ZmienTekst(ref tekst);
            Console.WriteLine(tekst);*/

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("a");

            //for (int i = 0; i < 1_000_000; i++)
            //{
            //    stringBuilder.Append("a");
            //}

            //Console.WriteLine(stringBuilder);
            #endregion
            #region
            //Console.WriteLine("Tekst".CompareTo("tekst"));

            //Console.WriteLine(string.Concat("1", "2", "4", "5"));

            //FunkcjaParams("1", "2", "3", "4", "5", "6", "7", "8");
            #endregion

            //var tekst = "mój testowy tekst";
            //if (tekst.Contains("test"))
            //{
            //    Console.WriteLine("zawiera");
            //}

            //Console.WriteLine(tekst.IndexOf("tessdwqdt",StringComparison.CurrentCulture));

            //Console.WriteLine(tekst.Insert(8,"@$^##$@"));

            var odpowiedz = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(odpowiedz))
            {
                Console.WriteLine("Podales pusty tekst");
            }
        }
    }
}
