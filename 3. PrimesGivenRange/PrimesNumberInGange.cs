//3. Write a method that calculates all prime numbers
//in given range and returns them as list of integers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesNumberInGange
{
    class NumberInRange
    {
        static void Main()
        {
            Console.WriteLine("Enter number for start and end of the range");
            Console.Write("start = ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("end = ");
            int end = int.Parse(Console.ReadLine());
            int counter = 0;

            FindPrimesInRange(start, end, counter);
        }

        static void FindPrimesInRange(int n, int m, int counter)
        {
            List<int> numbers = new List<int>();
            if (n < 0 || m < 0)
            {
                n = 2;
            }
            if (n == 0 || n == 1)
            {
                n = 2;
            }
            if (n > m)
            {
                Console.WriteLine("Empty list");
            }
            for (int i = n; i <= m; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                    if (counter > 2)
                    {
                        break;
                    }
                }
                if (counter <= 2)
                {
                    numbers.Add(i);
                }
                counter = 0;
            }
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}