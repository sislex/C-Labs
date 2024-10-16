// Напишите программу с использованием вложенных циклов for, чтобы вывести пирамиду из звездочек высотой, которую вводит пользователь.

using System;

namespace PyramidOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the pyramid:");
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
