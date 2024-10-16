// Создать список List<int> и заполнить его случайными числами от 1 до 10. 
// Вывести список на экран. Отсортировать список по возрастанию, а затем по убыванию и вывести оба списка на экран. 
// Также найти среднее арифметическое всех элементов списка и вывести его на экран.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sum = 0;
            int count = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(1, 11));

                sum += list[i];
                count++;

                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            list.Sort();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            list.Reverse();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Average: " + (double)sum / count);
        }
    }
}
