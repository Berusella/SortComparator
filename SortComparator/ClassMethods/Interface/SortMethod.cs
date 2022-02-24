using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class SortMethod
    {
        public SortMethod(string name,ISort sort)
        {
            Name = name;
            Sort = sort;
            Times = new List<double>();
        }

        public readonly string Name;

        public readonly ISort Sort;

        public readonly List<double> Times;
        
    }
}
