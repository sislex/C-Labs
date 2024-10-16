// Написать программу, которая выводит на экран первые 10 чисел Фибоначчи.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
