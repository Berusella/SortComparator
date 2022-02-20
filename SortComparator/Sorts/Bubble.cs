using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class Bubble
    {
       public void BubbleSort(int[] quan)  //zajęło nicałe 30 minut - całkiem prosty, ale wnerwiający. Straszliwie lubi wychodzić poza range
        {
            var step = 0;
            var num = quan.Length;
            var j = 1;
            while (j != num)
            {
                try
                {
                    if (quan[j] < quan[j - 1])
                    {
                        var clip = quan[j];
                        quan[j] = quan[j - 1];
                        quan[j - 1] = clip;
                        j--;
                        step++;
                    }
                    else
                    {
                        step++;
                        j++;
                    }
                }
                catch (Exception)
                {
                    step++;
                    j++;
                }

            }
        }
    }
}
