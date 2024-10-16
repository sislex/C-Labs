// запросить у пользователя кол-во чисел Фибоначчи, которое он хотел бы сгенерировать (вычислить), и, собственно, произвести генерацию (вычисление). В процессе генерации записывать числа в массив. После генерации вывести вычисленные числа.

using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел Фибоначчи, которое вы хотите сгенерировать:");
            int n = int.Parse(Console.ReadLine());
            int[] fib = new int[n];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            Console.WriteLine("Числа Фибоначчи:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(fib[i] + " ");
            }
        }
    }
}