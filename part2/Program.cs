using System;
using System.Collections.Generic;

namespace part2

{
    class Program
    {
        static void Main(string[] args)
        {

            Effi pl = new Effi();
            Console.WriteLine(pl.Something("10"));
            Console.WriteLine(pl.Something("100"));
            Console.WriteLine(pl.Something("1000"));
            Console.WriteLine(pl.Something("10000"));


            Console.WriteLine();

            Console.WriteLine(pl.Somethingmore("10"));
            Console.WriteLine(pl.Somethingmore("100"));
            Console.WriteLine(pl.Somethingmore("1000"));
            Console.WriteLine(pl.CreateInput(1));




        }
    }
}