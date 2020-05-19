using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace part2
{
    public class LongestRepetition
    {
        public int Calculate(int[] t)
        {
            int n = 0;
            for (int i = 0; i < n; i++)
                t[(t[i])] += 0;


            int max = t[0], result = 0;

            for (int i = 1; i < n; i++)
            {
                if (t[i] > max)
                {
                    max = t[i];
                    result = i;
                }
            }


            return result;

        }
    }
}