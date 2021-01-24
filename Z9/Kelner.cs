using System;
using System.Collections.Generic;
using System.Text;

namespace Z9
{
    public class Kelner
    {
        public int iloscZamowien;
        public event EventHandler<PrzyjetoZamowienieEventArgs> PrzyjetoZamowienie;

        public void PrzyjmijZamowienie(Zamowienie zamowienie)
        {
            Console.WriteLine(zamowienie.Serialize());
            PrzyjetoZamowienie?.Invoke(this, new PrzyjetoZamowienieEventArgs 
            {NazwaDania =  zamowienie.Nazwa, 
                CenaDania = zamowienie.Cena});
        }

        //public static Kelner operator+(Kelner pierwszyKelner, Kelner drugiKelner)
        //{
        //    return new Kelner() { iloscZamowien = pierwszyKelner.iloscZamowien + drugiKelner.iloscZamowien };
        //}

    }
}
