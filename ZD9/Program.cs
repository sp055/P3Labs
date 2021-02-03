using System;
using System.Collections.Generic;

namespace ZD9
{
    public class Uzytkownik
    {
        public string Nazwa { get; set; }
        public int ID { get; set; }

        public void SubskrybujKanal(Kanal kanal)
        {
            kanal.OpublikowanoFilm += Uzytkownik_OpublikowanoFilm; ; // dzięki temu event i eventhandler wiedzą o sobie
            kanal.LicznikSubskrypcji();
        }

        private void Uzytkownik_OpublikowanoFilm(object sender, EventArgs e) // to wykonuje się kiedy "wydarzy się" event
        {
            Console.WriteLine($"Użytkownik {Nazwa} ID: {ID} otrzymał powiadomienie o nowym filmie."); // instukcje dla tego wydarzenia
        }
    }

    public class Kanal
    {
        public Kanal(string nazwa, int id)
        {
            Nazwa = nazwa;
            Id = id;
        }

        public string Nazwa { get; set; }
        public int Id { get; set; }
        public int licznikWyswietlen { get; set; }
        public int suby { get; set; }

        public event EventHandler OpublikowanoFilm;

        public void WyswietlFilm(int id)
        {
            Console.WriteLine($"Użytkownik od ID: {id} obejrzał film.");
            licznikWyswietlen++;
        }

        public void OpublikujFilm()
        {
            OpublikowanoFilm?.Invoke(this, EventArgs.Empty);
        }
        public void LicznikSubskrypcji()
        {
            suby++;
        }
    }

    public static class Rozszerzenia
    {
        public static void Wypisz(this Kanal kanal)
        {
            Console.WriteLine($"Nazwa kanału: {kanal.Nazwa} " +
                $"Liczba wyświetleń filmów: {kanal.licznikWyswietlen} " +
                $"Liczba subskrypcji: {kanal.suby} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var kanal = new Kanal(nazwa: "Przygody z C#", id: 320);

            List<Uzytkownik> uzytkownicy = new List<Uzytkownik>();
            uzytkownicy.Add(new Uzytkownik() { Nazwa = "Adam", ID = 5 });
            uzytkownicy.Add(new Uzytkownik() { Nazwa = "Marek", ID = 7 });
            uzytkownicy.Add(new Uzytkownik() { Nazwa = "Marcin", ID = 23 });
            uzytkownicy.Add(new Uzytkownik() { Nazwa = "Bartek", ID = 19 });
            uzytkownicy.Add(new Uzytkownik() { Nazwa = "Andrzej", ID = 3 });

            for (int i = 0; i < uzytkownicy.Count; i++)
            {
                uzytkownicy[i].SubskrybujKanal(kanal);
            }

            kanal.OpublikujFilm();

            kanal.WyswietlFilm(uzytkownicy[0].ID);
            kanal.WyswietlFilm(uzytkownicy[4].ID);
            kanal.WyswietlFilm(uzytkownicy[2].ID);

            kanal.Wypisz();
        }
    }
}
