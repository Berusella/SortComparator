using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class SpecialSelect
    {
        public void Start()
        {
            var table = new TableCreation();
            var choice = new DoubleTrouble();
            var numberChoice = new Asker();
            var randomNumbers = new QuanInizalition();
            var anwser = numberChoice.Ask();
            var quan = randomNumbers.Quan(anwser);
            Console.WriteLine("m - mergeSort\nq - quickSort\ns - shellSort\nc - combSort\nb - bucketSort\nn - bubbleSort");
            var line = Console.Read();
            switch (line)
            {
                case 'm':
                    choice.MergeAnalyze(quan, 3);
                    break;
                case 'q':
                    choice.QuickAnalyze(quan, 3);
                    break;
                case 's':
                    choice.ShellAnalyze(quan, 3);
                    break;
                case 'c':
                    choice.CombAnalyze(quan, 3);
                    break;
                case 'b':
                    choice.BucketAnalyze(quan, 3);
                    break;
                case 'n':
                    choice.BubbleAnalyze(quan, 3);
                    break;
                default:
                    break;
            }
            table.Create(Program.stoper.times);
        }
    }
}
