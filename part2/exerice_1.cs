using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace part2
{
    public class Effi
    {
        public int Something(string n)
        {
            DateTime start = DateTime.Now;
            int sum = 0;

            for (int i = 0; i <= n.Length - 1; i++)
            {

                for (int j = 0; j <= n.Length - 1; j++)
                {
                    if (n[i].ToString() == "0" && n[j].ToString() == "1")
                    {
                        sum += 1;
                    }
                }
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("time: " + end.Subtract(start));
            return (sum);
        }

        public int Somethingmore(string z)
        {

            DateTime start1 = DateTime.Now;
            int sum = 0;
            int zeros = 0;

            for (int i = 0; i <= z.Length - 1; i++)
            {
                if (z[i].ToString() == "0")
                {
                    zeros += 1;
                }
                else
                {
                    sum += zeros;
                }

            }

            DateTime end1 = DateTime.Now;
            Console.WriteLine("time: " + end1.Subtract(start1));
            return sum;

        }
        public string CreateInput(int n)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                sb.Append(random.Next(0, 2).ToString());
            }
            return sb.ToString();
        }
    }
}
