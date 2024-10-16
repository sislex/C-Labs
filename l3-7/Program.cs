// Запросить у пользователя не более 10 целых чисел. Пользователь может прекратить приём чисел, введя 0.
// После прекращения приёма целых чисел (это происходит в случае, если было введено 10 чисел, 
// либо пользователь ввёл 0, чтобы не вводить все 10) подсчитать среднее значение введённых целых чисел и вывести на консоль.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int number;
            do
            {
                Console.Write("Введите целое число: ");
                number = int.Parse(Console.ReadLine());
                if (number != 0)
                {
                    sum += number;
                    count++;
                }
            } while (number != 0 && count < 10);
            Console.WriteLine($"Среднее значение введённых целых чисел: {(double)sum / count}");
        }
    }
}
