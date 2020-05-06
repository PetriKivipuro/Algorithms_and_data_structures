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
/*
Pseudocode

sum = 0
while x is not zero
    rem
    x is devided by 10 and remainder is added
    sum += rem
return sum
*/
