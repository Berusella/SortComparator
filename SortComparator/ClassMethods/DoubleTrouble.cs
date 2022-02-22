using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SortComparator
{
    class DoubleTrouble
    {
        public void caller(QuanInizalition quan, int i)
        {

            MergeAnalyze(new QuanInizalition(quan), i);
            ShellAnalyze(new QuanInizalition(quan), i);
            CombAnalyze(new QuanInizalition(quan), i);
            BucketAnalyze(new QuanInizalition(quan), i);
            QuickAnalyze(new QuanInizalition(quan), i);
            BubbleAnalyze(new QuanInizalition(quan), i);
        }
        public void ShellAnalyze(QuanInizalition quan, int i)
        {
            var shell = new Shell();
            var clock1 = DateTime.Now.Ticks;
            shell.ShellSort(quan);
            var clock2 = DateTime.Now.Ticks - clock1;
            Program.stoper.times["shell"][i] = clock2;
        }
        public void MergeAnalyze(QuanInizalition quan, int i)
        {
            var merge = new Merge();
            var clock1 = DateTime.Now.Ticks;
            merge.Sort(quan);
            var clock2 = DateTime.Now.Ticks - clock1;
            Program.stoper.times["merge"][i] = clock2;
        }
        public void CombAnalyze(QuanInizalition quan, int i)
        {
            var comb = new Comb();
            var clock1 = DateTime.Now.Ticks;
            comb.CombSort(quan); //gap is permamently set to 3;
            var clock2 = DateTime.Now.Ticks - clock1;
            Program.stoper.times["comb"][i] = clock2;
        }
        public void BucketAnalyze(QuanInizalition quan, int i)
        {
            var bucket = new Bucket();
            var clock1 = DateTime.Now.Ticks;
            bucket.BucketSort(quan);
            var clock2 = DateTime.Now.Ticks - clock1;
            Program.stoper.times["bucket"][i] = clock2;
        }
        public void BubbleAnalyze(QuanInizalition quan, int i)
        {
            var bubble = new Bubble();
            var clock1 = DateTime.Now.Ticks;
            bubble.BubbleSort(quan);
            var clock2 = DateTime.Now.Ticks - clock1;
            Program.stoper.times["bubble"][i] = clock2;
            //for (int j = 0; j < quan.Quan.Length; j++)
            //{
            //    Console.WriteLine(quan.Quan[j]);
            //}
        }
        public void QuickAnalyze(QuanInizalition quan, int i)
        {
            var clock1 = DateTime.Now.Ticks;
            new Quick().Sort(quan);
            var clock2 = DateTime.Now.Ticks - clock1;
            Program.stoper.times["quick"][i] = clock2;
        }
        
    }
}
