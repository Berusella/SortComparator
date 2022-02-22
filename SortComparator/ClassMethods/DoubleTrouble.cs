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
                var clock1 = DateTime.Now.Ticks;
                item.Sort.Sort(quan);
                var clock2 = DateTime.Now.Ticks - clock1;
                item.Times.Add(clock2);
            }
        }
    }
}