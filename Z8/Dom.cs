using System;
using System.Collections.Generic;
using System.Text;

namespace Z8
{
    public class Dom : Budynek
    {
        public double Dlugosc { get; set; }
        public double Szerokosc { get; set; }

        public Dom(double dlugosc, double szerokosc)
        {
            Dlugosc = dlugosc;
            Szerokosc = szerokosc;
        }

        public override int Standard()
        {
            throw new NotImplementedException();
        }

        public override double ObliczPowierzchnie()
        {
            return ObliczPowierzchnie() / 20;
        }
    }
}
