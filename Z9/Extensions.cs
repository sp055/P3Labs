using System;
using System.Collections.Generic;
using System.Text;

namespace Z9
{
    public static class Extensions
    {
        public static string Serialize(this Zamowienie zamowienie)
        {
            return $"{zamowienie.Nazwa} {zamowienie.Cena}";
        }
    }
}
