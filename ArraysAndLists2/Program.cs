using System;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * 
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> odds = new List<int>(); 
            List<int> evens = new List<int>();
            foreach (int i in ints)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            Console.WriteLine("These numbers are odd:");
            foreach (var i in odds)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("These numbers are even:");
            foreach (var i in evens)
            {
                Console.WriteLine(i);
            }




            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}

