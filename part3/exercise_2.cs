using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace part3
{
    public class SmallestDifference
    {
        public int Calculate(int[] t)
        {
            // Calculate method calls for Randomizer method!! CAN YOU HEAR???
            int diff = int.MaxValue;


            for (int i = 0; i < t.Length - 1; i++)

                for (int j = i + 1; j < t.Length; j++)
                    if (Math.Abs((t[i] - t[j])) < diff)
                        diff = Math.Abs((t[i] - t[j]));


            return diff;

        }
        public static int[] Randomizer(int n)
        {
            Random random = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                // integers between 1 and 1000 are enough for us
                arr[i] = random.Next(1, 1001);
            }
            return arr;
        }
    }
}