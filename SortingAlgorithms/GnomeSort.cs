using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class GnomeSort
    {
        public static List<int> GnomeSortAscending(this List<int> list)
        {
            int index = 0;

            while(index < list.Count)
            {
                if (index == 0)                     index++;
                if (list[index] >= list[index - 1]) index++;
                else
                {
                    list.Swap(index, index-1);
                    index--;
                }
            }
            return list;
        }

        public static List<int> GnomeSortDescending(this List<int> list)
        {
            int index = 0;

            while (index < list.Count)
            {
                if (index == 0) index++;
                if (list[index] < list[index - 1]) index++;
                else
                {
                    list.Swap(index, index - 1);
                    index--;
                }
            }
            return list;
        }
    }
}
