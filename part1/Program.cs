using System;

namespace part1

{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers num = new Numbers();
            Console.WriteLine(num.Sum(4075)); // 16
            Console.WriteLine(num.Sum(3)); // 3
            Console.WriteLine(num.Sum(999999999)); // 81
            Console.WriteLine(num.Sum(1111111111)); // Integerejä ei voi olla enempää kuin 10
        }
    }
}