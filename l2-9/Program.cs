// Создайте цикл, который запрашивает у пользователя числа до тех пор, пока он не введет отрицательное число. После этого выведите сумму введенных положительных чисел.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number;
            do
            {
                Console.Write("Введите число: ");
                number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    sum += number;
                }
            } while (number >= 0);
            Console.WriteLine($"Сумма введенных положительных чисел: {sum}");
        }
    }
}
