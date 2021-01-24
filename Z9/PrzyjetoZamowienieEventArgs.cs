using System;
using System.Collections.Generic;
using System.Text;

namespace Z9
{
    public class PrzyjetoZamowienieEventArgs : EventArgs
    {
        public string NazwaDania { get; set; }
        public decimal CenaDania { get; set; }
    }
}
