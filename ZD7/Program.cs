using System;
using System.Collections.Generic;
using System.Linq;

namespace ZD7
{
    interface IPrintable
    {
        void Print();
    }

    public class RClass : ICloneable, IComparable<RClass>, IPrintable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Tablica = new int[10];
        Random rand = new Random();
        public RClass()
        {
        }

        public RClass(int id, string name)
        {
            Id = id;
            Name = name;

            for (int i = 0; i < 10; i++)
            {
                Tablica[i] = rand.Next(0, 9);
            }
        }

        public object Clone() // funkcja do klonowania obiektów RClass
        {
            var item = new RClass()
            {
                Id = this.Id,
                Name = this.Name,
                Tablica = (int[])this.Tablica.Clone()
            };
            return item;
        }

        public int CompareTo(RClass next) // a - z
        {
            if (next == null) return 1;
            return Name.CompareTo(next.Name);
        }

        public void Print()
        {

            Console.Write(Name);
            Console.WriteLine($" ID: {Id}");

            foreach (var item in Tablica)
            {
                Console.Write($"|{item}");

            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class Program
    {
        // funkcja do która losuje nazwę tylko z podanych znaków
        static string RString(int length, Random rand)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rand.Next(s.Length)]).ToArray());
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            RClass a = new RClass(200, RString((rand.Next() % 10) + 5, rand));  //+5 sprawia że wylosowana nazwa nie będzie mniejsza niż 5
            a.Print();

            RClass b = a.Clone() as RClass; // klonowanie
            b.Print();

            Console.WriteLine("Obiekt i jego klon ^^^^");
            Console.WriteLine();

            RClass[] rclass = new RClass[100];
            List<RClass> list = new List<RClass>();

            for (int i = 0; i < 100; i++)
            {
                rclass[i] = new RClass(i, RString((rand.Next() % 5) + 5, rand));
                list.Add(rclass[i].Clone() as RClass);

            }

            list.Sort(); // sortowanie względem pola tekstowego (od A do Z)

            for (int j = 1; j < 100; j++)
            {
                Array.Clear(rclass[j].Tablica, 0, rclass[j].Tablica.Length); // czyszczenie każdego miejsca w tablicy cyfr
                list[j].Print();
            }
        }
    }
}
