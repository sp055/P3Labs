using System;
using System.Collections.Generic;
using System.Text;

namespace Z4
{
    public class Transakcja
    {
        public int Id;
        public DateTime Czas;
        public decimal Kwota;


        public (int identyfikator, DateTime czasTransakcji, decimal kwota) ZwrocInfo()
        {
            return (Id, Czas, Kwota);
        }
    }
}
