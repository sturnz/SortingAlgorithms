using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    // For more information visit https://de.wikipedia.org/wiki/Swap-Sort
    public static class SwapSort
    {
        public static List<int> SwapSortAscending(this List<int> list)
        {
            int index = 0;

            while(index < list.Count)
            {
                int smallerNums = 0;

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] < list[index])
                    {
                        smallerNums++;
                    }
                }
                list.Swap(index, smallerNums);
                if (index == smallerNums) index++;
            }
            return list;

        }
    }
}
