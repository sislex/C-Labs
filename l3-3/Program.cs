// Создать список List<string> и добавить в него минимум 5 строк. 
// Вывести список на экран. Удалить из списка все элементы, которые начинаются на букву "а". Вывести список на экран.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new System.Collections.Generic.List<string> { "apple", "banana", "avocado", "orange", "kiwi" };

            Console.WriteLine("List:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].StartsWith("a"))
                {
                    list.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine("\nList without elements starting with 'a':");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
