using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class QuanInizalition
    {
        public readonly int[] Quan;
        public int MaxNum { get; }

        public QuanInizalition(int num)
        {
            var quan = new int[num];
            var rand = new Random();
            var maxNum = 0;
            for (int i = 0; i < quan.Length; i++)
            {
                quan[i] = rand.Next(1, 1000);
                if (quan[i] > maxNum)
                {
                    maxNum = quan[i];
                }
            }
            Quan = quan;
            MaxNum = maxNum;
        }

        public QuanInizalition(QuanInizalition source)
        {
            var quan = new int[source.Quan.Length];
            Quan = quan;
            Array.Copy(source.Quan, quan, source.Quan.Length);
            //for (int i = 0; i < quan.Length - 1; i++)
            //{
            //    quan[i] = Quan[i];
            //}

            //Quan = new int[source.Quan.Length];
            //Array.Copy(source.Quan, Quan, source.Quan.Length);

            MaxNum = source.MaxNum;
        }
    }
}
