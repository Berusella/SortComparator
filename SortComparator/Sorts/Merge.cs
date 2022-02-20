using System;
using System.Collections.Generic;
using System.Text;

namespace SortComparator
{
    class Merge
    {        
        public void SortMerge(int[] numbers, int left, int right)          //zajęło 1h i 21 minut - musiałem posłużyć się pomocą do zrobienia go. Nie dokońca rozumiałem jego zamysł.
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                this.MainMerge(numbers, left, (mid + 1), right);
            }
        }
        private void MainMerge(int[] quan, int left, int mid, int right)
        {
            int[] temp = new int[quan.Length];
            int i, middle, numberE, start;
            middle = (mid - 1);
            start = left;
            numberE = (right - left + 1);

            while ((left <= middle) && (mid <= right))
            {
                if (quan[left] <= quan[mid])
                    temp[start++] = quan[left++];
                else
                    temp[start++] = quan[mid++];
            }
            while (left <= middle)
                temp[start++] = quan[left++];
            while (mid <= right)
                temp[start++] = quan[mid++];
            for (i = 0; i < numberE; i++)
            {
                quan[right] = temp[right];
                right--;
            }
        }
    }
}
