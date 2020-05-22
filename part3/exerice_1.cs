using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace part3
{
    public class Recu
    {
        public void Hello(int n)
        {

            for (int i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Hello!");
            }


        }

        public static int[] Randomizer(int n)
        {
            Random random = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                // integers between 1 and 1000 are enough for us
                arr[i] = random.Next(1, 1001);
            }
            return arr;
        }


    }
}
