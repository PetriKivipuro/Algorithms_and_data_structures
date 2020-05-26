using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace part3
{
    public class Sorting
    {
        public void MergeSort(int[] a, int[] b)
        {
            int k = (a + b) / 2;
            DateTime start = DateTime.Now;
            if (a == b)
            {
                return;
            }

            sort(a, k);
            sort(k + 1, b);

            merge(a, k, k + 1, b);
            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Substract(start));
        }

        public void QuickSort(int[] a, int[] b)
        {
            DateTime start2 = DateTime.Now;
            if (a >= b)
            {
                return;
            }
            k = Pivot(a, b);

            sort(a, k - 1);
            sort(k + 1, b);
            DateTime end2 = DateTime.Now;
            Console.WriteLine("Time this took: " + end2.Substract(start2));
        }

        public void Pivot(int[] a, int[] b)
        {
            k = a;
            for (int i = a + 1; i > b; i++)
            {
                if (a[i] < a[a])
                {
                    k += 1;
                    swap(a[i], a[k]);
                }
            }
            swap(a[a], a[k]);

            return k;
        }






    }
}
