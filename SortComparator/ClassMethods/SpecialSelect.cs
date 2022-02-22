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
            var anwser = numberChoice.Ask();
            var quan = new QuanInizalition(anwser);
            Console.WriteLine("m - mergeSort\nq - quickSort\ns - shellSort\nc - combSort\nb - bucketSort\nn - bubbleSort");
            var line = Console.Read();
            var method = new List<SortMethod>();    
            switch (line)
            {
                case 'm':
                    method.Add(new SortMethod("merge", new Merge()));
                    break;
                case 'q':
                    method.Add(new SortMethod("quick", new Quick()));
                    break;
                case 's':
                    method.Add(new SortMethod("shell", new Shell()));
                    break;
                case 'c':
                    method.Add(new SortMethod("comb", new Comb()));
                    break;
                case 'b':
                    method.Add(new SortMethod("bucket", new Bucket()));
                    break;
                case 'n':
                    method.Add(new SortMethod("bubble", new Bubble()));
                    break;
                default:
                    return;
            }
            for (int i = 0; i < 3; i++)
            {
                method[0].Times.Add(0);
            }
            new DoubleTrouble().Caller(quan,method);
            table.Create(method);
        }
    }
}
