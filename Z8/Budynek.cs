using System;
using System.Collections.Generic;
using System.Text;

namespace Z8
{
    public abstract class Budynek
    {
        public virtual double ObliczPowierzchnie()
        {
            throw new NotImplementedException();
        }

        public abstract int Standard();
    }
}
