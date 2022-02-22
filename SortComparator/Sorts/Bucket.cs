using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class Bucket : ISort
    {
        public void Sort(QuanInizalition quan) //zajęło 1h i 48 minut - straszliwie cieżki do zrobienia według mnie. Dużo zmagania, by program robił poprawnie pudełka w zależności od wielkości tablicy
        {
            var max = quan.MaxNum / 10;
            var buckets = new Dictionary<int, List<int>>();
            BucketsCreation(max, quan.Quan, buckets);
            for (var i = 1; i < buckets.Keys.Count; i++)
            {
                QuickSort(buckets[i], 0, buckets[i].Count - 1);
            }
        }
        private void BucketsCreation(double max, int[] table, Dictionary<int, List<int>> buckets)
        {
            foreach (var item in table)
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (item < max * (double)i)
                    {
                        if (!buckets.ContainsKey(i))
                        {
                            buckets.Add(i, new List<int>());
                        }
                        buckets[i].Add(item);
                        break;
                    }
                }
            }
        }
        private void QuickSort(List<int> bucket, int left, int right)
        {

            var i = left;
            var j = right;
            var temp = bucket[(i + j) / 2];
            while (i < j)
            {
                while (bucket[i] < temp) i++;
                while (bucket[j] > temp) j--;
                if (i <= j)
                {
                    var swap = bucket[i];
                    bucket[i++] = bucket[j];
                    bucket[j--] = swap;
                }
            }
            if (left < j) QuickSort(bucket, left, j);
            if (i < right) QuickSort(bucket, i, right);
        }

    }
}
