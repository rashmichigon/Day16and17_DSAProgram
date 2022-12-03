﻿using System.Collections;

namespace Day16and17_DSAProgram
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int a, b, i, j, flag;

            // Ask user to enter lower value of interval
            Console.WriteLine("Enter lower bound of " +
                              "the interval: ");

            // Take input
            a = int.Parse(Console.ReadLine());

            // Ask user to enter upper value of interval
            Console.WriteLine("\nEnter upper bound " +
                              "of the interval: ");

            // Take input
            b = int.Parse(Console.ReadLine());

            // Print display message
            Console.WriteLine("\nPrime numbers between " +
                              "{0} and {1} are: ", a, b);

            // Traverse each number in the interval
            // with the help of for loop
            for (i = a; i <= b; i++)
            {

                // Skip 0 and 1 as they are
                // neither prime nor composite
                if (i == 1 || i == 0)
                    continue;

                // flag variable to tell
                // if i is prime or not
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                // flag = 1 means i is prime
                // and flag = 0 means i is not prime
                if (flag == 1)
                    Console.WriteLine(i);
            }
        }
    }
}

