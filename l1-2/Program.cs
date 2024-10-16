// Написать программу, которая находит максимальное из трех чисел введённых с клавиатуры и выводит 
// на экран соответствующее сообщение.


using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа:");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Максимальное число: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Максимальное число: " + b);
            }
            else
            {
                Console.WriteLine("Максимальное число: " + c);
            }
        }
    }
}