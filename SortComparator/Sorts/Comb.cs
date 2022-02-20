using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class Comb
    {
        public void CombSort(int[] quan)    //zajął 30 minut - jak zrozumiałem co ma na celu to całkiem łatwo poszło. Problemem tylko był ten głupi gap, który był double.
        {
            var gap = 3.0;
            var shrink = 1.3;
            var done = true;

            while (done)
            {
                gap = Math.Floor(gap / shrink);
                if (gap <= 1)
                {
                    gap = 1;
                    done = false;
                }

                for (int i = 0; i + gap < quan.Length; i++)
                {
                    var change = i + (int)gap;
                    if (quan[i] > quan[change])
                    {
                        var swap = quan[i];
                        quan[i] = quan[change];
                        quan[change] = swap;

                        done = true;
                    }
                }
            }
        }
    }
}
