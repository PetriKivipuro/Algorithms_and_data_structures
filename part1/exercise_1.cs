using System;

namespace part1
{
    public class Numbers
    {
        public int Sum(int x)
        {
            int sum = 0;
            while (x != 0)
            {
                int rem;
                x = Math.DivRem(x, 10, out rem);
                sum += rem;
            }
            return sum;
        }
    }
}