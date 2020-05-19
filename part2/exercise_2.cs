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
            int n = 1;
            int h = 1;
            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] == t[i - 1])
                {
                    n++;
                }
                else if (t[i] != t[i - 1])
                {
                    n = 1;
                }
                if (h < n)
                {
                    h = n;
                }
            }
            return h;
        }

    }
}
