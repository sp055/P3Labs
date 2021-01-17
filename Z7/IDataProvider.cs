using System;
using System.Collections.Generic;
using System.Text;

namespace Z7
{
    public interface IDataProvider
    {
        IEnumerable<Person> GetPeople();
    }
}
