using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class IndexSwapper
    {
        public static List<int> Swap(this List<int> list, int index1, int index2)
        {
            var temporaryIndex  = list[index1];
            list[index1]        = list[index2];
            list[index2]        = temporaryIndex;

            return list;
        }
    }
}
