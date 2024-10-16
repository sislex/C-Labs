// Написать программу, которая заменяет все пробелы в строке на символ подчеркивания.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World! This is a test string.";
            Console.WriteLine(str.Replace(' ', '_'));
        }
    }
}

