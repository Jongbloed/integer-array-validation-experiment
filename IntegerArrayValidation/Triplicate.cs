using System.Collections.Generic;
using System.Linq;

namespace IntegerArrayValidation
{
    public static class Triplicate
    {
        public static int[] DetermineLinq(int[] input)
        {
            var output = input
                .GroupBy(x => x)
                .Where(x => x.Take(3).Count() >= 3)
                .Select(x => x.Key)
                .OrderByDescending(x => x)
                .ToArray();
            return output;
        }

        public static int[] DetermineFor(int[] input)
        {
            var map = new Dictionary<int, int>(input.Length);
            var triplicates = new SortedSet<int>(new ReverseComparer());
            foreach (var x in input)
            {
                if (!map.TryAdd(x, 1))
                {
                    if (++map[x] == 3)
                    {
                        triplicates.Add(x);
                    }
                }
            }
            return triplicates.ToArray();
        }

        class ReverseComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
