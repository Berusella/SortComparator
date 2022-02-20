using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    public class Stoper
    {
        public Dictionary<string, List<double>> times = new Dictionary<string, List<double>>();
        public Stoper()
        {
            times.Add("merge", new List<double>());
            for (int i = 0; i < 4; i++)
            {
                times["merge"].Add(0);
            }
            this.times.Add("quick", new List<double>());
            for (int i = 0; i < 4; i++)
            {
                times["quick"].Add(0);
            }
            this.times.Add("shell", new List<double>());
            for (int i = 0; i < 4; i++)
            {
                times["shell"].Add(0);
            }
            this.times.Add("comb", new List<double>());
            for (int i = 0; i < 4; i++)
            {
                times["comb"].Add(0);
            }
            this.times.Add("bucket", new List<double>());
            for (int i = 0; i < 4; i++)
            {
                times["bucket"].Add(0);
            }
            this.times.Add("bubble", new List<double>());
            for (int i = 0; i < 4; i++)
            {
                times["bubble"].Add(0);
            }
        }
        //public Stoper()
        //{


            //for (int i = 0; i < times.Keys.Count; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        times["merge"].Add(0);
            //    }
            //}
            //foreach (var item in times)
            //{
            //    times[item].Add(0);
            //}
        //}

    }
}
