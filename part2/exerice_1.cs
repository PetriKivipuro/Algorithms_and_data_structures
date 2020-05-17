using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace part2
{
    public class Effi
    {
        public int Something(string n);
        {
            DateTime start = DateTime.Now;
        int sum = 0;

            for (int i = 0; i<= n.Lenght - 1; i++)
            {

                for (int j = 0; j<= n.Lenght - 1; j++)
                {
                    if (n[i] == 0 && n[i] == 1)
                    {
                        sum += 1;
                    }
}
            }
    DateTime end = DateTime.Now;
Console.WriteLine("time: " end.Substract(start));
                   return Console.WriteLine(sum);
                }
}


/*         public string SomethingMore();
        {
            DateTime start = DateTime.Now;
        int sum = 0;
        int zeros = 0;

for(int i = 0; i< 0; i++;)
{
if(chars[i] == 0)
{
    zeros +=1;
}
else
{
    sum += zeros;
}
return sum;
}
DateTime end = DateTime.Now;
Console.WriteLine("time: " end.Substract(start));
        }
    }

}
 */
