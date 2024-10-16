// Запросить у пользователя: фамилию, имя, возраст, вес, рост.
// Высчитать ИМТ (индекс массы тела) по формуле ИМТ = вес (кг) / (рост (м) * рост (м))
// Сформировать единую строку, в следующем формате:
// Your profile:
// Full Name: фамилия, имя
// Age: рост
// Weight: вес
// Height: рост
// Body Mass Index: ИМТ
// Вывести сформированную строку на консоль.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);

            Console.WriteLine("Your profile:");
            Console.WriteLine($"Full Name: {surname}, {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Body Mass Index: {bmi}");
        }
    }
}

