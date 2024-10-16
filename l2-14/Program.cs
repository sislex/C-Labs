// запросить у пользователя число, факториал которого необходимо вычислить и произвести вычисление. Затем вывести результат вычисления. 

using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, факториал которого необходимо вычислить: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Факториал числа {number} равен {factorial}");
        }
    }
}
