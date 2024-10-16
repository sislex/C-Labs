// Создать двумерный массив размером 3x3 и заполнить его случайными числами от 1 до 9. Вывести его на экран. Найти максимальный элемент в двумерном массиве и вывести его на экран.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            Random random = new Random();
            int max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 10);
                    Console.Write(array[i, j] + " ");
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Максимальный элемент в двумерном массиве: {max}");

            Console.ReadKey();
        }
    }
}
