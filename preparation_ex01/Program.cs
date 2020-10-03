using System;
using System.Linq;
using System.Collections.Generic;

namespace preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercise 1
            Numbers num = new Numbers();
            Console.WriteLine(num.Steps(11)); // 5
            Console.WriteLine(num.Steps(15)); // 5
            Console.WriteLine(num.Steps(2)); // 2
            Console.WriteLine(num.Steps(20));


        }
    }
}
