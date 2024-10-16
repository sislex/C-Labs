// Написать программу, которая находит максимальное из трех чисел введённых с клавиатуры и выводит 
// на экран соответствующее сообщение.


using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

            Console.WriteLine("Введите первое число:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x = {x}, y = {y}");

            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}

