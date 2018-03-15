using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Masarnouski._01
{
    class MergeSort
    {
        public static void Sort(int[] items)
        {
            if (items.Length <= 1)
                return;
            int leftsize = items.Length / 2; ;
            int rightsize = items.Length - leftsize;
            int[] left = new int[leftsize];
            int[] right = new int[rightsize];
            Array.Copy(items, 0, left, 0, leftsize);
            Array.Copy(items, leftsize, right, 0, rightsize);

            Sort(left);
            Sort(right);

            Merge(items, left, right);

        }

        static void Merge(int[] items, int[] left, int[] right)
        {
            int leftindex = 0;
            int rightindex = 0;
            int targetindex = 0;

            int remaining = left.Length + right.Length;
            while (remaining > 0)
            {
                if (leftindex >= left.Length)
                {
                    items[targetindex] = right[rightindex++];
                }
                else if (rightindex >= right.Length)
                {
                    items[targetindex] = left[leftindex++];
                }
                else if (left[leftindex].CompareTo(right[rightindex]) < 0)
                {
                    items[targetindex] = left[leftindex++];
                }
                else
                    items[targetindex] = right[rightindex++];
                targetindex++;
                remaining--;
            }
        }
    }
}


