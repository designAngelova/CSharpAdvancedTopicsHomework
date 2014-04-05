//5. Write a program that reads a number n and a sequence of n integers, sorts them and prints them. 
using System;
using System.Collections.Generic;
using System.Linq;

    class SortingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter a range of sequence n = ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("numbers[{0}] =  ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
               
                Console.WriteLine(" numbers[{0}] = {1}", i, numbers[i]);
            }
        }
    }

