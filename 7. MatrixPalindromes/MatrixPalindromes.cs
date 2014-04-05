﻿//7. Write a program to generate the following matrix 
// of palindromes of 3 letters with r rows and c 
using System;
using System.Collections.Generic;
using System.Linq;
 class MatrixPalindromes
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of rows");
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string[,] matrix = new string[width, height];
            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    matrix[row, col] =
                        "" + (char)('a' + row) + (char)('a' + col +row) + (char)('a' + row);
                }
            }

            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }

