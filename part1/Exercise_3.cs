using System;

namespace part1
{
    public class Tables
    {
        public int Calculate(int[] t)
        {// examp 1,2,3,2
         // 2 keirros //3,5,5
         // t.Lenggt ==4
         // tLenght ==3
            if (t.Length == 1)
            {
                return t[0];
            }
            else
            {
                //2t.Lenght == 3
                //2 kierros t2.Lenght == 2
                // t2.lenht == 1

                int[] t2 = new int[t.Length - 1];
                // loop läpi t
                for (int i = 0; i < t.Length - 1; i++)
                {
                    //t2[0] = 1+2
                    // toinen kierrot t[1] = 5+5
                    //
                    t2[i] = t[i] + t[i + 1];
                }
                return Calculate(t2);
            }


        }
    }
}
