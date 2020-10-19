using System;

namespace ZD1
{
    class Program
    {
        static double a, b, c, delta;

        public enum MiejscaZerowe
        {
            mz0,
            mz1,
            mz2
        }

        static MiejscaZerowe mz;

        static void Main(string[] args)
        {
            Console.WriteLine("Podawaj wszystkie wartości w systemie dziesiętnym!");    //przypomnienie
            try                                                                        //szukanie błędu
            {
                Console.WriteLine("Podaj wartość a: ");
                a = double.Parse(Console.ReadLine());                                //wartość a
                Console.WriteLine("Podaj wartość b: ");
                b = double.Parse(Console.ReadLine());                                //wartość c
                Console.WriteLine("Podaj wartość c: ");
                c = double.Parse(Console.ReadLine());                                //wartość c

                delta = (b * b) - (4 * a * c);                                       //obliczenie delty
                Console.WriteLine($"Delta wynosi: {delta}");

                double pierwiastekDelta;                                                    //sprawdzenie czy delta ujemna dla obliczenia pierwiastka
                if (delta >= 0)
                {
                    pierwiastekDelta = Math.Sqrt(delta);
                    Console.WriteLine($"Pierwiastek z delty wynosi: {pierwiastekDelta}");
                }

                sprawdz(ref mz);

                switch (mz)
                {
                    case MiejscaZerowe.mz0:                                                 //brak miejsc
                        Console.WriteLine("Delta ujemna, brak miejsc zerowych!");
                        break;
                    case MiejscaZerowe.mz1:                                                 //jedno miejsce
                        double wynik1 = (-b) / (2 * a);
                        Console.WriteLine($"Jedno miejsce zerowe: {wynik1}");
                        break;
                    case MiejscaZerowe.mz2:                                                 //dwa miejsca
                        double wynik2 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double wynik3 = (-b - Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine($"Dwa miejsca zerowe: {wynik2} i {wynik3}");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nie udało się sparsować liczby");
            }

            static void sprawdz(ref MiejscaZerowe a)                                    //przekazanie wartości potrzebnych do wyboru switch case
            {
                if (delta < 0)
                {
                    a = MiejscaZerowe.mz0;
                }
                else if (delta == 0)
                {
                    a = MiejscaZerowe.mz1;
                }
                else if (delta > 0)
                {
                    a = MiejscaZerowe.mz2;
                }
            }
        }
    }
}
