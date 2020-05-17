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
                    if (n[i].ToString() == "0" && n[i].ToString() == "1")
                    {
                        sum += 1;
                    }
                }
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("time: " + end.Subtract(start));
            return (sum);
        }
    }
}
