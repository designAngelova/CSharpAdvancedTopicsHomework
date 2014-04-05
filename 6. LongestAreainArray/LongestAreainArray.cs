////6. Write a program to find the longest area 
// of equal elements in array of strings. You 
// first should read an integer n and n strings 
// (each at a separate line), then find and print the
// longest sequence of equal elements
// (first its length, then its elements).
// If multiple sequences have the same maximal
// length, print the leftmost of them
using System;
using System.Collections.Generic;
using System.Linq;

class LongestAreainArray
{
    static void Main()
    {
        Console.WriteLine("please enter a lenght of sequence n = ");
        int n = int.Parse(Console.ReadLine());
        string[] strings = new string[n];
        int maxCount = 0;
        string result = null;

        for (int i = 0; i < n; i++)
        {
            Console.Write("strings[{0}] = ", i);
            strings[i] = Console.ReadLine();
        }
        for (int i = 0; i < strings.Length; i++)
        {
            int counter = 0;
            for (int j = 0; j < strings.Length; j++)
            {
                if (strings[i] == strings[j])
                {
                    counter++;

                    if (maxCount < counter)
                    {
                        maxCount = counter;
                        result = strings[i];
                    }
                }
                else
                {
                    break;
                }
            }
        }
        Console.WriteLine("\nThe element of maximal sequence is \"{0}\", repeated {1} times", result, maxCount);
    }
}
           
           
        
        
    

