using System;
using System.Collections.Generic;


namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Alla harjoitus 2

            //Punainen viiva LongestRepetition alla ei mene pois
            LongestRepetition p = new LongestRepetition();
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 1, 1, 2 })); // 2
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 1
            Console.WriteLine(p.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 5















            // Alla harjoitus 1
            /*      Effi pl = new Effi();
                 Console.WriteLine(pl.Something("10"));
                 Console.WriteLine(pl.Something("100"));
                 Console.WriteLine(pl.Something("1000"));
                 Console.WriteLine(pl.Something("10000"));


                 Console.WriteLine();

                 Console.WriteLine(pl.Somethingmore("10"));
                 Console.WriteLine(pl.Somethingmore("100"));
                 Console.WriteLine(pl.Somethingmore("1000"));
                 Console.WriteLine(pl.CreateInput(10000)); */


            /* Effi counters = new Effi();
            string input10 = counters.CreateInput(10);
            string input100 = counters.CreateInput(100);
            string input1000 = counters.CreateInput(1000);
            string input10000 = counters.CreateInput(10000);
            string input1000000 = counters.CreateInput(1000000);

            DateTime start = DateTime.Now;
            counters.Something(input10); //O(n^2)
            counters.Something(input100); //O(n^2)
            counters.Something(input1000); //O(n^2)
            counters.Something(input10000); //O(n^2)


            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));

            DateTime start1 = DateTime.Now;
            counters.Somethingmore(input10); //O(n^2)
            counters.Somethingmore(input100); //O(n^2)
            counters.Somethingmore(input1000); //O(n^2)
            counters.Somethingmore(input10000); //O(n^2)


            DateTime end1 = DateTime.Now;
            Console.WriteLine("Time this took: " + end1.Subtract(start1));

 */
        }
    }
}