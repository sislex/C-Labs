// Написать программу, которая выводит на экран все числа от 100 до 1 в обратном порядке.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}