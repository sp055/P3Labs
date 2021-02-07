using System;
using System.Linq;
/*
 Utwórz klasę Paczkomat. Dodaj do niej metodę WyslijPaczke, która przyjmuje jako parametr id paczki. 
Metoda powinna publikować event WyslanoPaczke wraz z jej id. Dodaj klasę PunktDystrybucji z metodą SzukajPaczki przyjmująca w parametrze id,
 która wysyła event SzukanoPaczki. Do PunktuDystrybucji dodaj także handler eventu BrakPaczki i wypisz w nim informację że paczka
nie została znaleziona. Stwórz klasę MagazynLogistyczny, która reaguje na oba eventy. Do klasy dodaj kolekcję, która przechowa
 id wszystkich posiadanych paczek. Handler SzukanoPaczki powinien publikować event BrakPaczki jeśli nie ma jej w kolekcji. 
Utwórz obiekty typu Paczkomat, PunktDystrybucji i MagazynLogistyczny. Podłącz eventy do handlerów i przetestuj metody.
 */
namespace Kolokwium2
{
    public class MagazynLogistyczny
    {
        public void Paczkomat_WyslanoPaczke(object sender, WyslanoPaczkeEventArgs e)
        {
            Console.WriteLine($"Wysłano paczke o id: {e.IDpaczki}");
        }

        public void Paczkomat_BrakPaczki(object sender, WyslanoPaczkeEventArgs e)
        {
            Console.WriteLine($"Nie znaleziono paczki o id: {e.IDpaczki}");
        }

        public void PunktDystrybucji_SzukanoPaczki(object sender, WyslanoPaczkeEventArgs e)
        {
            Console.WriteLine($"Szukano paczki.");
        }
    }
    public class PunktDystrybucji
    {
        public event EventHandler SzukanoPaczki;

        public void SzukajPaczki(int id)
        {
            SzukanoPaczki?.Invoke(this, new WyslanoPaczkeEventArgs { IDpaczki = id });
        }

        

    }
    public class Paczkomat
    {
        public event EventHandler<WyslanoPaczkeEventArgs> WyslanoPaczke;
        public event EventHandler<WyslanoPaczkeEventArgs> BrakPaczki;
        public void WyslijPaczkeM(int id)
        {
            WyslanoPaczke?.Invoke(this, new WyslanoPaczkeEventArgs { IDpaczki = id });

        }
        public void BrakPaczkiM(int id)
        {
            BrakPaczki?.Invoke(this, new WyslanoPaczkeEventArgs { IDpaczki = id });
        }


    }
    public class WyslanoPaczkeEventArgs : EventArgs
    {
        public int IDpaczki { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1();
            Zadanie2();
            Zadanie3();
        }

        static void Zadanie1()
        {
            string str;
            str = Console.ReadLine();
            char[] characters = str.ToCharArray();

            var collection = characters.OrderBy(x => x).Distinct();
            foreach (var item in collection)
            {
                Console.Write(item);
            }
        }

        static void Zadanie2()
        {


        }

        static void Zadanie3()
        {
            Paczkomat paczkomat = new Paczkomat();
            PunktDystrybucji punktDystrybucji = new PunktDystrybucji();
            MagazynLogistyczny magazynLogistyczny = new MagazynLogistyczny();

            paczkomat.WyslanoPaczke += magazynLogistyczny.Paczkomat_WyslanoPaczke;
            paczkomat.BrakPaczki += magazynLogistyczny.Paczkomat_BrakPaczki;
        }


    }
}
