using System;
using System.Collections.Generic;
using System.Text;

namespace Z7
{
    public class HardcodedDataProvider : IDataProvider
    {
        public IEnumerable<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person{"Aaa", "Bbb", "CEO" },
                new Person{"Ccc", "Ddd", "CEO" },
                new Person{"Eee", "Fff", "CEO" },
                new Person{"Ggg", "Hhh", "CEO" },
                new Person{"Iii", "Jjj", "CEO" },
                new Person{"Kkk", "Lll", "CEO" },
                new Person{"Mmm", "Nnn", "CEO" },
            };
        }
    }
}
