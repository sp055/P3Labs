using System;

namespace Z9
{
    class Program
    {
        static void Main(string[] args)
        {
            var kelner = new Kelner();
            var kucharz = new Kucharz();
            var kasa = new KasaFiskalna();

            kelner.PrzyjetoZamowienie += kucharz.Kelner_PrzyjetoZamowienie;
            kelner.PrzyjetoZamowienie += kasa.Kelner_PrzyjetoZamowienie;
            //var test = kelner + kelner;
            kelner.PrzyjmijZamowienie(new Zamowienie() {Nazwa = "Spaghetti" , Cena = 30});
            kelner.PrzyjmijZamowienie(new Zamowienie() { Nazwa = "Pizza" , Cena = 45});
            kelner.PrzyjmijZamowienie(new Zamowienie() { Nazwa = "Schabowy", Cena= 20});

            kucharz.Gotuj();
            kucharz.Gotuj();
        }
    }
}