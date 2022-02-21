using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SortComparator
{
    class DoubleTrouble
    {
        public DoubleTrouble()
        {

        }
        public void caller(int[] quan, int i)
        {
            var copy = quan;
            //Task Merge = new Task(() =>
            //{
                MergeAnalyze(copy, i);
            //});


            copy = quan;
            ShellAnalyze(copy, i);
            copy = quan;
            CombAnalyze(copy, i);
            copy = quan;
            BucketAnalyze(copy, i);
            copy = quan;
            QuickAnalyze(copy, i);
            //Task Bubble = new Task(() =>
            //{
                copy = quan;
                BubbleAnalyze(copy, i);
            //});
            //Merge.Start();
            //Bubble.ConfigureAwait(Merge.IsCompleted);
            //Bubble.Start();
            /*
            var merge = new Merge();
            var shell = new Shell();
            var comb = new Comb();
            var bucket = new Bucket();
            var quick = new Quick();
            var bubble = new Bubble();


            var copy = quan;
            double clockMerge1 = DateTime.Now.Ticks;
            merge.SortMerge(copy, 0, quan.Length - 1);
            double clockMerge2 = DateTime.Now.Ticks;
            Program.stoper.times["merge"][i] = clockMerge2 - clockMerge1;

            copy = quan;
            var clockShell1 = DateTime.Now.Ticks;
            shell.ShellSort(copy);
            var clockShell2 = DateTime.Now.Ticks;
            Program.stoper.times["shell"][i] = clockShell2 - clockShell1;

            copy = quan;
            var clockComb1 = DateTime.Now.Ticks;
            comb.CombSort(copy); //gap is permamently set to 3;
            var clockComb2 = DateTime.Now.Ticks;
            Program.stoper.times["comb"][i] = clockComb2 - clockComb1;

            copy = quan;
            var clockBucket1 = DateTime.Now.Ticks;
            bucket.BucketSort(copy, Runner.max_B);
            var clockBucket2 = DateTime.Now.Ticks;
            Program.stoper.times["bucket"][i] = clockBucket2 - clockBucket1;

            copy = quan;
            var clockQuick1 = DateTime.Now.Ticks;
            quick.QuickSort(copy, 0, quan.Length - 1);
            var clockQuick2 = DateTime.Now.Ticks;
            Program.stoper.times["quick"][i] = clockQuick2 - clockQuick1;
            //for (int i = 0; i < copy.Length; i++)
            //{
            //    Console.WriteLine(copy[i]);
            //}

            copy = quan;
            var clockBubble1 = DateTime.Now.Ticks;
            bubble.BubbleSort(copy);
            var clockBubble2 = DateTime.Now.Ticks;
            Program.stoper.times["bubble"][i] = clockBubble2 - clockBubble1; */
        }
        public void ShellAnalyze(int[] quan, int i)
        {
            var stopwatch = new Stopwatch();
            var shell = new Shell();
            //var clockShell1 = DateTime.Now.Ticks;
            stopwatch.Start();
            shell.ShellSort(quan);
            //var clockShell2 = DateTime.Now.Ticks - clockShell1;
            stopwatch.Stop();
            Program.stoper.times["shell"][i] = stopwatch.ElapsedTicks;
        }
        public void CombAnalyze(int[] quan, int i)
        {
            var stopwatch = new Stopwatch();
            var comb = new Comb();
            stopwatch.Start();
            comb.CombSort(quan); //gap is permamently set to 3;
            stopwatch.Stop();
            Program.stoper.times["comb"][i] = stopwatch.ElapsedTicks;
        }
        public void BucketAnalyze(int[] quan, int i)
        {
            var stopwatch = new Stopwatch();
            var bucket = new Bucket();
            stopwatch.Start();
            bucket.BucketSort(quan, Runner.max_B);
            stopwatch.Stop();
            Program.stoper.times["comb"][i] = stopwatch.ElapsedTicks;
        }
        public void BubbleAnalyze(int[] quan, int i)
        {
            var stopwatch = new Stopwatch();
            var bubble = new Bubble();
            stopwatch.Start();
            bubble.BubbleSort(quan);
            stopwatch.Stop();
            Program.stoper.times["comb"][i] = stopwatch.ElapsedTicks;
            for (int j = 0; j < quan.Length; j++)
            {
                Console.WriteLine(quan[j]);
            }
        }
        public void QuickAnalyze(int[] quan, int i)
        {
            var stopwatch = new Stopwatch();
            var quick = new Quick();
            stopwatch.Start();
            quick.QuickSort(quan, 0, quan.Length - 1);
            stopwatch.Stop();
            Program.stoper.times["comb"][i] = stopwatch.ElapsedTicks;
            //for (int i = 0; i < copy.Length; i++)
        }
        public void MergeAnalyze(int[] quan, int i)
        {
            var stopwatch = new Stopwatch();
            var merge = new Merge();
            stopwatch.Start();
            merge.SortMerge(quan, 0, quan.Length - 1);
            stopwatch.Stop();
            Program.stoper.times["comb"][i] = stopwatch.ElapsedTicks;
        }
    }
}
