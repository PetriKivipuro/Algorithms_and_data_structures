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




namespace part1
{
    public class Numbers2
    {
        public int Sum(int x)
        {
            int sum = 0;
            string str = x.ToString();
            foreach (char c in str)
            {
                sum += (int)Char.GetNumericValue(c);
            }
            return sum;
        }
    }
}




namespace part1
{
    public class Numbers3
    {
        public int Sum(int x)
        {
            int sum = 0;
            while (x != 0)
            {
                // 4075
                // 5
                //407
                // 7
                // 40
                // 0
                // 4
                // 4
                sum += x % 10;

                x /= 10; //integer Rounds down to 0
            }


            return sum;
        }
    }
}
