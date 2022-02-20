using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    public class TableCreation
    {
        public void Create(Dictionary<string, List<double>> times)
        {
            var separetor = 82;
            Console.WriteLine($"Name   | First(200)| Second(500)| Third(1000)| Your Choice(pls dont kill computer)|");
            foreach (KeyValuePair<string, List<double>> item in times)
            {
                for (int i = 0; i < separetor; i++)
                {
                    Console.Write("-");
                }                
                Console.Write($"|\n{item.Key} |");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"{item.Value[i]}|");
                }
                Console.WriteLine();
            }
            

                            //$"merge  |{Time.times["merge"][1]}|{Time.times["merge"][1]}|{Time.times["merge"][1]}|{Time.times["merge"][1]}|\n" +
                            //$"---------------------------------------------------------------------------------\n" +
                            //$"quick  |{}|            |            |                                    |\n" +
                            //$"----------------------------------------------------------------------------------\n" +
                            //$"shell  |{}|            |            |                                    |\n" +
                            //$"---------------------------------------------------------------------------------\n" +
                            //$"comb   |{}|            |            |                                    |\n" +
                            //$"----------------------------------------------------------------------------------\n" +
                            //$"bucket |{}|            |            |                                    |\n" +
                            //$"----------------------------------------------------------------------------------\n" +
                            //$"bubble |{}|            |            |                                    |\n" +
                            //$"----------------------------------------------------------------------------------\n");
        }
    }
}
