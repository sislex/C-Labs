// Запросить у пользователя два целочисленных значения и найти максимальное.

using System;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int maxNumber = firstNumber > secondNumber ? firstNumber : secondNumber;

            Console.WriteLine($"The maximum number is {maxNumber}");
        }
    }
}
