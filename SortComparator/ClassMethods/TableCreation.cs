using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    public class TableCreation
    {
        public void Create(Dictionary<string, List<double>> times)
        {
            var separetor = 58;
            Console.WriteLine($"Name   | First(200)||Second(500)||Third(1000)||Your Choice|");
            foreach (KeyValuePair<string, List<double>> item in times)
            {
                for (int i = 0; i < separetor; i++)
                {
                    Console.Write("-");
                }
                var keyLine = item.Key;
                Console.Write($"|\n{keyLine}");
                for (int i = 0; i < 7-keyLine.Length; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"|{item.Value[i]}");
                    var timeLine = item.Value[i].ToString();
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
