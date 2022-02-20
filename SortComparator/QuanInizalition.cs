using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class QuanInizalition
    {
        public int[] Quan(int num)
        {
            var quan = new int[num];
            var rand = new Random();
            for (int i = 0; i < quan.Length; i++)
            {
                quan[i] = rand.Next(1, 1000);
                if (quan[i] > Runner.max_B)
                {
                    Runner.max_B = quan[i];
                }
            }
            return quan;
        }
    }
}
