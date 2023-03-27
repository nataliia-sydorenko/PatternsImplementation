using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsImplementation
{
    internal class AlphabeticalOrderSorter : ISorter
    {
        public List<string> Sort(List<string> strings)
        {
            return strings.OrderBy(s => s).ToList();
        }

        public List<string> ReverseSort(List<string> strings)
        {
            return strings.OrderByDescending(s => s).ToList();
        }
    }
}
