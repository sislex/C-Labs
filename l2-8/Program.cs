// Написать программу, которая выводит на экран все числа, которые делятся на 3 или на 5, от 1 до 50.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

