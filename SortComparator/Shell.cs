using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class Shell
    {
        public void ShellSort(int[] quan)     //zajęło 47 minut. Bardzo prosty do zrobienia i całkiem przyjemny;
        {
            var h = 1;
            var num = quan.Length;
            for (; h < num; h = 3 * h + 1) ;
            h /= 9;
            while (h > 0)
            {
                for (int j = num - h - 1; j >= 0; j--)
                {
                    var k = quan[j];
                    var m = j + h;
                    while (m < num && k > quan[m])
                    {
                        quan[m - h] = quan[m];
                        m += h;
                    }
                    quan[m - h] = k;
                }
                h /= 3;
            }
        }
    }
}
