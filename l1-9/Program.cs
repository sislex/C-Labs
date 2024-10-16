// Написать программу, которая удаляет из строки все повторяющиеся символы.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World! Hello, C#!";
            Console.WriteLine("Исходная строка: " + str);
            Console.WriteLine("Строка без повторяющихся символов: " + RemoveDuplicateChars(str));
            Console.ReadKey();
        }

        static string RemoveDuplicateChars(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }

            return result;
        }
    }
}
