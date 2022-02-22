using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class TableCreation
    {
        public void Create(List<SortMethod> sortMethodList)
        {
            var separetor = 58;
            Console.WriteLine($"Name   | First(200)||Second(500)||Third(1000)||Your Choice|");
            foreach (var item in sortMethodList)
            {
                for (int i = 0; i < separetor; i++)
                {
                    Console.Write("-");
                }
                Console.Write($"|\n{item.Name}");
                for (int i = 0; i < 7 - item.Name.Length; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < item.Times.Count; i++)
                {
                    Console.Write($"|{item.Times[i]}");
                    var timeLine = item.Times[i].ToString();
                    for (int j = 0; j < 11 - timeLine.Length; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                }
                Console.WriteLine();
            }
        }
    }
}
