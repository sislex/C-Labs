// Используя цикл, попросите пользователя ввести число от 1 до 10. Если число не входит в этот диапазон, запросите ввод снова.

using System;

namespace UserInput
{
    class Program
    {
        static void Main()
        {
            int number;
            do
            {
                Console.Write("Введите число от 1 до 10: ");
                number = int.Parse(Console.ReadLine());
            } while (number < 1 || number > 10);
            Console.WriteLine("Вы ввели число " + number);
        }
    }
}
