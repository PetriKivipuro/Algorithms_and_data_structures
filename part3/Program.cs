using System;
using System.Collections.Generic;


namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            // tää on tehty class systeemillä
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


            }
        }
    }
}