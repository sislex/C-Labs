// Запросить у пользователя длины трёх сторон треугольника. Длины могут быть представлены дробными значениями.
// После получения длин сторон - использовать формулу Герона для вычисления площади треугольника.
// После вычисления площади - вывести результат на консоль.

using System;

namespace Lesson_02.Exp_02
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длины сторон треугольника:");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Площадь треугольника: {s}");
        }
    }
}