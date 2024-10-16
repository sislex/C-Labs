// Написать программу, которая переводит строку сперва в верхний регистр, а затем в нижний регистр.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
        }
    }
}
    