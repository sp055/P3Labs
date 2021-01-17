using System;
using System.Collections.Generic;

namespace Z8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Budynek> budynki = new List<Budynek>();
            budynki.Add(new Garaz(2));
            budynki.Add(new Dom(10,20));

            foreach (var budynek in budynki)
            {
                Console.WriteLine(budynek.ObliczPowierzchnie());
            }
        }
    }
}
