﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class DoubleTrouble
    {
        public DoubleTrouble()
        {
            
        }
        public void caller(int[]quan, int i)
        {
            var copy = quan;
            MergeAnalyze(copy, i);
            copy = quan;
            ShellAnalyze(copy, i);
            copy = quan;
            CombAnalyze(copy, i);
            copy = quan;
            BucketAnalyze(copy, i);
            copy = quan;
            QuickAnalyze(copy, i);
            copy = quan;
            BubbleAnalyze(copy, i);
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
            var shell = new Shell();
            var clockShell1 = DateTime.Now.Ticks;
            shell.ShellSort(quan);
            var clockShell2 = DateTime.Now.Ticks;
            Program.stoper.times["shell"][i] = clockShell2 - clockShell1;
        }
        public void CombAnalyze(int[] quan, int i)
        {
            var comb = new Comb();
            var clockComb1 = DateTime.Now.Ticks;
            comb.CombSort(quan); //gap is permamently set to 3;
            var clockComb2 = DateTime.Now.Ticks;
            Program.stoper.times["comb"][i] = clockComb2 - clockComb1;
        }
        public void BucketAnalyze(int[]quan,int i)
        {
            var bucket = new Bucket();
            var clockBucket1 = DateTime.Now.Ticks;
            bucket.BucketSort(quan, Runner.max_B);
            var clockBucket2 = DateTime.Now.Ticks;
            Program.stoper.times["bucket"][i] = clockBucket2 - clockBucket1;
        }
        public void BubbleAnalyze(int[]quan, int i)
        {
            var bubble = new Bubble();
            var clockBubble1 = DateTime.Now.Ticks;
            bubble.BubbleSort(quan);
            var clockBubble2 = DateTime.Now.Ticks;
            Program.stoper.times["bubble"][i] = clockBubble2 - clockBubble1;
        }
        public void QuickAnalyze(int[]quan,int i)
        {
            var quick = new Quick();
            var clockQuick1 = DateTime.Now.Ticks;
            quick.QuickSort(quan, 0, quan.Length - 1);
            var clockQuick2 = DateTime.Now.Ticks;
            Program.stoper.times["quick"][i] = clockQuick2 - clockQuick1;
            //for (int i = 0; i < copy.Length; i++)
        }
        public void MergeAnalyze(int[]quan,int i)
        {
            var merge = new Merge();
            double clockMerge1 = DateTime.Now.Ticks;
            merge.SortMerge(quan, 0, quan.Length - 1);
            double clockMerge2 = DateTime.Now.Ticks;
            Program.stoper.times["merge"][i] = clockMerge2 - clockMerge1;
        }
    }
}
