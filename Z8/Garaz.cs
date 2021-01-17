using System;
using System.Collections.Generic;
using System.Text;

namespace Z8
{
    class Garaz : Budynek
    {
        public int IloscMiejsc { get; set; }

        public Garaz(int iloscMiejsc)
        {
            IloscMiejsc = iloscMiejsc;
        }
        public override double ObliczPowierzchnie()
        {
            return IloscMiejsc * 8;
        }
        public override int Standard()
        {
            return Math.Min(Math.Max(IloscMiejsc, 5),1);
        }
    }
}
