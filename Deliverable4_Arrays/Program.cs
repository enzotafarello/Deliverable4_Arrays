/* Author: Enzo Tafarello negrao
 Date: 02/09/2023
Description: C# console application that computes the first 25 numbers of the Fibonacci sequence */

using System;

namespace Deliverable4_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacci_n1 = 0;
            int fibonacci_n2 = 1;
            int fibonacci_n3;         

            int[] series = new int[25];

            series[0] = fibonacci_n1;
            series[1] = fibonacci_n2;

            for (int i = 2; i < 25; i++)
             {

                fibonacci_n3 = series[i - 1] + series[i - 2];
                series[i] = fibonacci_n3;

            }

            for (int i = 0; i < 25; i++)
            {

                Console.WriteLine("Fibonacci number (" + i + ") = " + series[i]);
            }
        }
    }
}
