using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    // For more information visit https://en.wikipedia.org/wiki/Bubble_sort
    public static class BubbleSort 
    {
        public static List<int> BubbleSortAscending(this List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int n = 0; n < list.Count - 1; n++)
                {
                    if (list[n] > list[n + 1])
                    {
                        list.Swap(n, n + 1);
                    }
                }
            }
            return list;
        }

        public static List<int> BubbleSortDescending(this List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int n = 0; n < list.Count - 1; n++)
                {
                    if (list[n] < list[n + 1])
                    {
                        list.Swap(n, n + 1);
                    }
                }
            }
            return list;
        }
    }
}
