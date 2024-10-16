// Создать цикл foreach для списка List<double> и вывести на экран все элементы списка, умноженные на 2.

using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double> { 1.1, 2.2, 3.3, 4.4, 5.5 };

            foreach (double item in list)
            {
                Console.WriteLine(item * 2);
            }
        }
    }
}
