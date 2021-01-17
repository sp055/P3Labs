using System;

namespace Z7
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataProvider dataProvider = new HardcodedDataProvider();
            IDataSorter dataSorter = new NameSorter();

            var data = dataProvider.GetPeople();
            var sortedData = dataSorter.Sort(data);

            foreach (var item in sortedData)
            {
                Console.WriteLine($"{item.name} {item.LastName} {item.Position});
            }
        }
    }
}
