using System;
using System.Collections.Generic;


namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    // Harjoitus 3
               Sorting s = new Sorting();
               int[] sortMe = Randomizer(100);
               int[] sortMeLarge = Randomizer(1000000);
               s.QuickSort(sortMe);
               s.MergeSort(sortMe);
               s.QuickSort(sortMeLarge);
               s.MergeSort(sortMeLarge); */

            // harjoitus 2

            SmallestDifference s = new SmallestDifference();
            Console.WriteLine(s.Calculate(new int[] { 4, 1, 8, 5 })); // 1
            Console.WriteLine(s.Calculate(new int[] { 1, 10, 100 })); // 9
            Console.WriteLine(s.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 0
            Console.WriteLine(s.Calculate(SmallestDifference.Randomizer(10))); // depends on random

            // Harjoitus 1
            /*   // tää on tehty class systeemillä
              Recu moi = new Recu();
              moi.Hello(5);

              Console.WriteLine();

              // Sama homma tehty mainissa
              Hello1(5);

              static void Hello1(int n)
              {

                  for (int i = 0; i <= n - 1; i++)
                  {
                      Console.WriteLine("Hello!");
                  }
   */

        }
    }
}
