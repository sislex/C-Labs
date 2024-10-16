// Написать программу, которая выводит на экран все четные числа от 1 до 20.

using System;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
