using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace part3
{
    public class Sorting
    {

        public void MergeSort(int[] t)
        {
            DateTime star3 = DateTime.Now;

            t = MSorter(t);

            DateTime end3 = DateTime.Now;
            Console.WriteLine(t.Length + end3.Subtract(star3));

        }

        public void QuickSort(int[] t)
        {

            DateTime star03 = DateTime.Now;

            t = QSorter(t);

            DateTime end03 = DateTime.Now;
            Console.WriteLine(t.Length + end03.Subtract(star03));

        }
        public int[] QSorter(int[] t, int a, int b) // sort(a,b)
        {
            if (a <= b) return t;

            int k = Pivot(t, a, b);
            QSorter(t, a, k - 1);
            QSorter(t, k + 1, b);

            /* sort(a, b)
  if a >= b
    return
  k = pivot(a,b)
  sort(a, k-1)
  sort(k+1, b) */


        }

        private int Pivot(int[] array, int a, int b)
        {
            /* pivot(a, b)
              k = a
              for i = a + 1 to b
                if array[i] < array[a]
                  k += 1
                  swap(array[i], array[k])
              swap(array[a], array[k])
              return k */
            int k = a;
            for (int i = a + 1; i <= b; i++)
            {
                if (array[i] < array[a])
                {
                    k += 1;
                    int swap = array[k];
                    array[k] = array[i];
                    array[i] = swap;
                }
            }
            int finalPicot = array[k];
            array[k] = array[a];
            array[a] = finalPicot;
            return k;
        }

        public int MSorter(int[] t)
        {
            int a = 0;
            int b = t.Length;
            int k = (a + b) / 2;
            int[] left = new int[k];
            int[] right = new int[b - k];

            if (t.Length == 1) return t;

            for (int i = 0; i <= t.Length - 1; i++)
            {
                if (i < k)
                {
                    left[i] = t[i];

                }
                else
                {
                    right[i - k] = t[i];
                }
            }

            left = MSorter(left);
            right = MSorter(right);

            return Merge(left, right);



            /* sort(a,b)
              if a == b
                return
              k = (a+b)/2
              sort(a,k)
              sort(k+1,b)
              merge(a,k,k+1,b) */
        }

        public int[] Merge(int[] left, int[] right)
        {
            int totalLength = left.Length + right.Length;
            // int[] result = new int[totalLength];
            int[] help = new int[totalLength];

            int a1 = 0;
            int b1 = left.Length - 1;

            int a2 = 0;
            int b2 = right.Length - 1;

            for (int i = 0; i < totalLength - 1; i++)
            {
                // if a2 > b2 or (a1 <= b1 and array[a1] <= array[a2])
                if (a2 > b2 || (a1 <= b1 && left[a1] <= right[a2]))
                {
                    //  help[i] = array[a1]
                    // a1 += 1
                    help[i] = left[a1];
                    a1++;
                }
                else
                {
                    /*  else
                        help[i] = array[a2]
                        a2 += 1 */
                    help[i] = right[a2];
                    a2++;
                }

            }
            return help;
        }





    }
}

// ite tehty
/*



 /*   public void MergeSort(int[] a, int[] b)
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
   */

 */