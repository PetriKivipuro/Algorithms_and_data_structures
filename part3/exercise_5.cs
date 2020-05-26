using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace part3
{
    public class Inversions
    {
        public int[] Create(int n, int k)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }

            int invCount = 0;
            int a = 0;
            int b = (n - 1);

            while (invCount < k)
            {
                int temp = arr[b];
                arr[b] = arr[b - 1];
                arr[b - 1] = temp;

                invCount++;
                b--;
                if (b == a)
                {
                    b = (n - 1);
                    a++;
                }
            }
            return arr;

        }
    }
}