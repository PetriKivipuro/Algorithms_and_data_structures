using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {

            Revolutions r = new Revolutions();
            Console.WriteLine(m.Calculate(new int[] { 4, 1, 3, 2, 5 })); // 3
            Console.WriteLine(m.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 1
            Console.WriteLine(m.Calculate(new int[] { 5, 4, 3, 2, 1 })); // 5


            /*           Sorting s = new Sorting();
                      int[] sortMeTen = Randomizer(10);
                      int[] sortMe = Randomizer(100);
                      int[] sortMeThousand = Randomizer(1000);
                      int[] sortMeLarger = Randomizer(10000);
                      int[] sortMeLargerer = Randomizer(100000);
                      int[] sortMeLargest = Randomizer(1000000);
                      int[] sortMeMassive = Randomizer(10000000);

                      s.MergeSort(sortMeTen);
                      s.MergeSort(sortMe);
                      s.MergeSort(sortMeThousand);
                      s.MergeSort(sortMeLarger);
                      s.MergeSort(sortMeLargerer);
                      s.MergeSort(sortMeLargest);
                      s.MergeSort(sortMeMassive); //

                      Console.WriteLine();

                      s.QuickSort(sortMeTen);
                      s.QuickSort(sortMe);
                      s.QuickSort(sortMeThousand);
                      s.QuickSort(sortMeLarger);
                      s.QuickSort(sortMeLargerer);
                      s.QuickSort(sortMeLargest);
                      s.QuickSort(sortMeMassive);
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
          } */


            // muuta shittii

            /*

            using System;
            using System.Collections.Generic;


            namespace part3
            {
                class Program
                {
                    static void Main(string[] args)
                    {
                        /*   // harjoitus 5
                          Inversions inv = new Inversions();
                          int[] t = inv.Create(80, 30);
                          foreach (int i in t)
                          {
                              Console.Write(i + " ");  // 2 1 3 5 4
                          }

               // harjoitus 4
              BinarySearch b = new BinarySearch();
              Console.WriteLine(b.Find(new int[] { 4, 1, 8, 5 }, 2)); // false
              Console.WriteLine(b.Find(new int[] { 0, 0 }, 0)); // true
              Console.WriteLine(b.Find(new int[] { 4, 1, 8, 5, 8, 7, 4, 2, 3 }, 2)); // true
              Console.WriteLine(b.Find(new int[] { 0 }, 0)); // true
              Console.WriteLine(b.Find(Randomizer(100000), 3)); // depends on Random


            // Harjoitus 3
            Sorting s = new Sorting();
            int[] sortMe = Randomizer(100);
            int[] sortMeLarge = Randomizer(1000000);
            //s.QuickSort(sortMe);
            s.MergeSort(sortMe);
                        // s.QuickSort(sortMeLarge);
                        s.MergeSort(sortMeLarge);










                        static int[] Randomizer(int n)
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

                        /*   // harjoitus 2

                          SmallestDifference s = new SmallestDifference();
                          Console.WriteLine(s.Calculate(new int[] { 4, 1, 8, 5 })); // 1
                          Console.WriteLine(s.Calculate(new int[] { 1, 10, 100 })); // 9
                          Console.WriteLine(s.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 0
                          Console.WriteLine(s.Calculate(SmallestDifference.Randomizer(10))); // depends on random
               */
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


            }
            }
            }


            */
        }
    }
}



/*
Sorting s = new Sorting();
      int[] sortMeTen = Randomizer(10);
      int[] sortMe = Randomizer(100);
      int[] sortMeThousand = Randomizer(1000);
      int[] sortMeLarger = Randomizer(10000);
      int[] sortMeLargerer = Randomizer(100000);
      int[] sortMeLargest = Randomizer(1000000);
      int[] sortMeMassive = Randomizer(10000000);
      s.MergeSort(sortMeTen);
      s.MergeSort(sortMe);
      s.MergeSort(sortMeThousand);
      s.MergeSort(sortMeLarger);
      s.MergeSort(sortMeLargerer);
      s.MergeSort(sortMeLargest);
      s.MergeSort(sortMeMassive); //
      Console.WriteLine();
      s.QuickSort(sortMeTen);
      s.QuickSort(sortMe);
      s.QuickSort(sortMeThousand);
      s.QuickSort(sortMeLarger);
      s.QuickSort(sortMeLargerer);
      s.QuickSort(sortMeLargest);
      s.QuickSort(sortMeMassive);
      Console.WriteLine();
      DateTime start01 = DateTime.Now;
      Array.Sort(sortMeTen);
      DateTime end01 = DateTime.Now;
      Console.WriteLine("Array.Sort, Array of " + sortMeTen.Length + ":\t Time: " + end01.Subtract(start01));
      DateTime start02 = DateTime.Now;
      Array.Sort(sortMe);
      DateTime end02 = DateTime.Now;
      Console.WriteLine("Array.Sort, Array of " + sortMe.Length + ":\t Time: " + end02.Subtract(start02));
      DateTime start03 = DateTime.Now;
      Array.Sort(sortMeThousand);
      DateTime end03 = DateTime.Now;
      Console.WriteLine("Array.Sort, Array of " + sortMeThousand.Length + ":\t Time: " + end03.Subtract(start03));
      DateTime start04 = DateTime.Now;
      Array.Sort(sortMeLarger);
      DateTime end04 = DateTime.Now;
      Console.WriteLine("Array.Sort, Array of " + sortMeLarger.Length + ":\t Time: " + end04.Subtract(start04));
      DateTime start05 = DateTime.Now;
      Array.Sort(sortMeLargerer);
      DateTime end05 = DateTime.Now;
      Console.WriteLine("Array.Sort, Array of " + sortMeLargerer.Length + ":\t Time: " + end05.Subtract(start05));
      DateTime start06 = DateTime.Now;
      Array.Sort(sortMeLargest);
      DateTime end06 = DateTime.Now;
      Console.WriteLine("Array.Sort, Array of " + sortMeLargest.Length + ":\t Time: " + end06.Subtract(start06));
      DateTime start07 = DateTime.Now;
      Array.Sort(sortMeMassive);
      DateTime end07 = DateTime.Now;
      Console.WriteLine("Array.Sort, Array of " + sortMeMassive.Length + ":\t Time: " + end07.Subtract(start07));
 */
