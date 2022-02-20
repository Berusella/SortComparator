using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class Quick
    {
        public void QuickSort(int[]quan, int left, int right)
        {
            var i = left;
            var j = right;
            var temp = quan[(i + j) / 2];
            while (i < j)
            {
                while (quan[i] < temp) i++;
                while (quan[j] > temp) j--;
                if (i <= j)
                {
                    var swap = quan[i];
                    quan[i++] = quan[j];
                    quan[j--] = swap;
                }
            }
            if (left < j) QuickSort(quan, left, j);
            if (i < right) QuickSort(quan, i, right);
        }
    }
}
