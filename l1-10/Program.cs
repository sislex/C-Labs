// Написать программу, которая разбивает строку на подстроки по заданному разделителю и выводит их на экран.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, world! How are you?";
            char separator = ' ';
            string[] substrings = str.Split(separator);

            foreach (string substring in substrings)
            {
                Console.WriteLine(substring);
            }
        }
    }
}