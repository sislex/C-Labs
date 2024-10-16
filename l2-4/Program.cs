// Написать программу, которая выводит на экран сумму всех чисел от 1 до 100.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
