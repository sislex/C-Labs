// Написать программу, которая выводит на экран факториалы всех чисел от 1 до 10.

using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}! = {Factorial(i)}");
            }
        }

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
