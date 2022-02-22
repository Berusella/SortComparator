using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class Bubble
    {
       public void BubbleSort(QuanInizalition quan)  //zajęło nicałe 30 minut - całkiem prosty, ale wnerwiający. Straszliwie lubi wychodzić poza range
        {
            var step = 0;
            var num = quan.Quan.Length;
            var j = 1;
            while (j != num)
            {
                try
                {
                    if (quan.Quan[j] < quan.Quan[j - 1])
                    {
                        var clip = quan.Quan[j];
                        quan.Quan[j] = quan.Quan[j - 1];
                        quan.Quan[j - 1] = clip;
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
