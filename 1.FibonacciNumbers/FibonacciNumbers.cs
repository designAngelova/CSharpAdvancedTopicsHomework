//1. Define a method Fib(n) that calculates the nth Fibonacci number
using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter n = ");
        int n = int.Parse(Console.ReadLine());
        int result = Fib(n);
        Console.WriteLine(result);
    }
    static int Fib(int n)
        {
        int firstNumber = 0;
        int secondNumber = 1;
        int nextNumber = 1;
        if (n == 1)
        {
            return (nextNumber);
        }
        if (n == 2)
        {
            return (secondNumber);
        }
        else{
            for (int i = 1; i <= n; i++)
            {
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            return(nextNumber);
        }
        }
}
      

    

