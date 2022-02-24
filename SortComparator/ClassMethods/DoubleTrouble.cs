using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SortComparator
{
    class DoubleTrouble
    {
        public void Caller(QuanInizalition quan, List<SortMethod> sortMethodList)
        {
            foreach (var item in sortMethodList)
            {
                var test = new QuanInizalition(quan);
                //Array.Copy(quan.Quan, test, quan.Quan.Length);
                var clock1 = DateTime.Now.Ticks;
                item.Sort.Sort(test);
                var clock2 = DateTime.Now.Ticks - clock1;
                item.Times.Add(clock2);
            }
        }
    }
}