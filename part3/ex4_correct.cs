using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace part3
{
    public class BinarySearch
    {
        bool Find(int[] array, int x)
        {
            /*       a = 0
            b = n - 1
            while a <= b
            k = (a + b) / 2
            if array[k] == x
                     // we found the x
            break
            if array[k] < x
            a = k + 1
            if array[k] > x
            b = k - 1 */

            int n = array.Length;
            Array.Sort(array);
            int a = 0;
            int b = n - 1;

            while (a <= b)
            {
                int k = (a + b) / 2;
                if (array[k] == x)
                {
                    return true;
                }
                if (array[k] < x)
                {
                    a = k + 1;
                }
                if (array[k] > x)
                {
                    b = k - 1;
                }

            }
            return false;

        }
    }
}