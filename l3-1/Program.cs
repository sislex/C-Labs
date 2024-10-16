// Создать массив из 10 целых чисел и вывести его на экран. Найти сумму элементов массива и вывести ее на экран.

using System;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                sum += array[i];
                Console.Write(array[i] + " ");
            }

            Console.WriteLine($"\nSum of array elements: {sum}");
        }
    }
}
