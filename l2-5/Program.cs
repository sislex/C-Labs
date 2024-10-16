// Написать программу, которая выводит на экран все простые числа от 1 до 50.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 50; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
