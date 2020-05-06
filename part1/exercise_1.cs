using System;

namespace part1
{
    public class Numbers
    {
        public int Sum(int x)
        {

            int[] nummrt = x.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
            int sum = 0;
            for (int i = 0; i < nummrt.Lenght; i++)
            {
                sum += nummrt[i];
            }
            return sum;
        }
    }
}