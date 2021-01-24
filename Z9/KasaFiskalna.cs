using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Z9
{
    class KasaFiskalna
    {

        public void Kelner_PrzyjetoZamowienie(object sender, PrzyjetoZamowienieEventArgs e)
        {
            var path = Path.Combine(System.Environment.CurrentDirectory, "Paragony", DateTime.Now.ToString().Replace(':','-') + DateTime.Now.Ticks + ".txt");
            File.WriteAllText(path, $"Firma sp. z o.o. \n {e.NazwaDania} \\t {e.CenaDania} \n Dziękujemy i zapraszamy ponownie!");
        }
    }
}
