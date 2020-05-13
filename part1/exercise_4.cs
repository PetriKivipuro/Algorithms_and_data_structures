using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace part1
{
    public class LuckyNumbers
    {
        public int Calculate(int a, int b)
        {

            int sum = 0;
            DateTime start = DateTime.Now;

            Regex regex = new Regex("^(3|7)+$");
            for (int i = a; i <= b; i++)
            {
                if (regex.IsMatch(i.ToString()))
                {
                    sum++;
                }
            }


            DateTime end = DateTime.Now;
            Console.WriteLine("this took " + end.Subtract(start));
            return sum;
        }
    }
}


namespace part1
{
    public class LuckyNumbers1
    {
        public int Calculate(int a, int b)
        {

            return CountNumbers(b) - CountNumbers(a - 1);
        }

        private int CountNumbers(int input)
        {
            List<int> list = new List<int>();
            if (input >= 3)
            {
                list.Add(3);
            }
            else
            {
                return list.Count;
            }

            if (input >= 7)
            {
                list.Add(7);
            }
            //magic numbers
            else return 1;
            /*
            10i+3
            33
            10i+7 */


            int i = 0;

            while (true)
            {
                int next = list[i] * 10 + 3;
                int nextAfterthat = list[i] * 10 + 7;
                if (next < input)
                {
                    break;
                }
                list.Add(next);
                if (nextAfterthat > input)
                {
                    break;
                }
                list.Add(nextAfterthat);
                i++;
            }


            return list.Count;
        }
    }
}