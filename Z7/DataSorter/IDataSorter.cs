using System;
using System.Collections.Generic;
using System.Text;

namespace Z7.DataSorter
{
    public interface IDataSorter
    {
       public IEnumerable<Person> Sort(IEnumerable<Person> data);
    }
}
