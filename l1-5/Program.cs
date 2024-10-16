// Написать программу, которая находит среднее арифметическое двух чисел и выводит на экран соответствующее сообщение.


using System;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            double average = (firstNumber + secondNumber) / 2;
            Console.WriteLine($"Среднее арифметическое чисел {firstNumber} и {secondNumber} равно {average}");
        }
    }
}
