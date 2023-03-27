using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsImplementation
{
    internal class SorterDecorator : ISorter
    {
        private ISorter Sorter { get; }
        public SorterDecorator(ISorter sorter) => Sorter = sorter;

        public List<string> Sort(List<string> strings)
        {
            var sortedList = Sorter.Sort(strings);
            return SortWordsStartsWithLetterB(sortedList);
        }

        public List<string> ReverseSort(List<string> strings)
        {
            var sortedList = Sorter.ReverseSort(strings);
            return SortWordsStartsWithLetterB(sortedList);
        }

        private List<string> SortWordsStartsWithLetterB(List<string> strings)
        {
            List<string> result = new();
            var index = 0;
            foreach (var word in strings)
            {
                if (word.StartsWith("b"))
                {
                    result.Insert(index, word);
                    index++;
                    continue;
                }
                result.Add(word);
            }

            return result;
        }
    }
}
