using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывод приветственного сообщения
            Console.WriteLine("Привет! Добро пожаловать в консольное приложение на C#.");

            // Запрашиваем у пользователя имя
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            // Приветствуем пользователя
            Console.WriteLine($"Приятно познакомиться, {name}!");

            // Выполним базовые арифметические операции
            Console.Write("Введите первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Сложение
            int sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {sum}");

            // Вычитание
            int difference = number1 - number2;
            Console.WriteLine($"{number1} - {number2} = {difference}");

            // Умножение
            int product = number1 * number2;
            Console.WriteLine($"{number1} * {number2} = {product}");

            // Деление (с проверкой на деление на ноль)
            if (number2 != 0)
            {
                double quotient = (double)number1 / number2;
                Console.WriteLine($"{number1} / {number2} = {quotient}");
            }
            else
            {
                Console.WriteLine("Деление на ноль невозможно.");
            }

            // Завершаем программу
            Console.WriteLine("Спасибо за использование программы. До свидания!");
        }
    }
}