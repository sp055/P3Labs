using System;

namespace Kolokwium1
{

    class Przejazd
    {

        int Cena;
        string Poczatek;
        string Cel;
        string DataZakupu;
        string DataWyjazdu;

        public Przejazd(int cena, string poczatek, string cel, string dataZakupu, string dataWyjazdu)
        {
            Cena = cena;
            Poczatek = poczatek;
            Cel = cel;
            DataZakupu = dataZakupu;
            DataWyjazdu = dataWyjazdu;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
            //Zadanie2();
            //Zadanie3(); // brak 
        }

        static void Zadanie1()
        {
            double tluszcze;
            double weglowodany;
            double bialka;

            Console.WriteLine("Ile gramów tłuszczy?");
            tluszcze = double.Parse(Console.ReadLine())* 9.45;
            Console.WriteLine("Ile gramów węglowodanów?");
            weglowodany = double.Parse(Console.ReadLine()) * 4.15;
            Console.WriteLine("Ile gramów białka?");
            bialka = double.Parse(Console.ReadLine()) * 5.65;

            double calosc = tluszcze + weglowodany + bialka;
            double ile = 1800 / calosc;
            
            double ileProcent = calosc / 1800 * 100;
            
            Console.WriteLine($"Powinieneś zjeść 1800kcal a zjadłeś: {calosc}");
            Console.WriteLine("Możesz zjeść jeszcze " + Math.Round(ile, 2) + " takich posilkow");
            Console.WriteLine($"Ten jeden posiłek to było tyle procent {Math.Round(ileProcent, 2)}");
        }

        static void Zadanie2()
        {
            int[,] tab = new int[6,8];


            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tab[i, j] = i * i + 14 * j + 8;
                    Console.WriteLine(tab[i,j]);
                }
            }
            int wynik = (tab[5, 2] + tab[1, 7] + tab[2, 2]) / 3;
            Console.WriteLine($"Średnia {tab[5, 2]} i {tab[1, 7]} i {tab[2, 2]}: {wynik}");

        }

        static void Zadanie3()
        {
            

        }
    }
}
