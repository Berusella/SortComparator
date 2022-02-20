using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class Runner
    {
        public static double max_B = 0;
        public void Run()
        {
            var randomNumbers = new QuanInizalition();
            var quan = randomNumbers.Quan(200);
            var merge = new Merge();
            var shell = new Shell();
            var comb = new Comb();
            var bucket = new Bucket();
            var quick = new Quick();
            var bubble = new Bubble();


            var copy = quan;
            var clock1 = DateTime.Now.Millisecond;
            merge.SortMerge(copy, 0, quan.Length - 1);
            var clock2 = DateTime.Now.Millisecond;
            Program.stoper.times["merge"][1] = clock2 - clock1;

            copy = quan;
            clock1 = DateTime.Now.Millisecond;
            shell.ShellSort(copy);     
            clock2 = DateTime.Now.Millisecond;
            Program.stoper.times["shell"][1] = clock2 - clock1;

            copy = quan;
            clock1 = DateTime.Now.Millisecond;
            comb.CombSort(copy);
            clock2 = DateTime.Now.Millisecond;
            Program.stoper.times["comb"][1] = clock2 - clock1;

            copy = quan;
            clock1 = DateTime.Now.Millisecond;
            bucket.BucketSort(copy,max_B);
            clock2 = DateTime.Now.Millisecond;
            Program.stoper.times["bucket"][1] = clock2 - clock1;

            copy = quan;
            clock1 = DateTime.Now.Millisecond;
            quick.QuickSort(copy,0,quan.Length);
            clock2 = DateTime.Now.Millisecond;
            Program.stoper.times["quick"][1] = clock2 - clock1;

            copy = quan;
            clock1 = DateTime.Now.Millisecond;
            bubble.BubbleSort(copy);
            clock2 = DateTime.Now.Millisecond;
            Program.stoper.times["bubble"][1] = clock2 - clock1;


        }
    }
}
