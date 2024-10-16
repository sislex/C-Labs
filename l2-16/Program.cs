// Предположим, что логин\пароль для входа в систему: johnsilver\qwerty.
// Запросить у пользователя логин и пароль. Дать пользователю только три попытки для ввода корректной пары логин\пароль. 
// Если пользователь произвёл корректный ввод, вывести на консоль: "Enter the System" и прекратить запрос логина\пароля. 
// Если пользователь ошибся трижды - вывести "The number of available tries have been exceeded" и прекратить запрос пары логин\пароль.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "johnsilver";
            string password = "qwerty";
            int tries = 3;

            while (tries > 0)
            {
                Console.Write("Enter login: ");
                string userLogin = Console.ReadLine();

                Console.Write("Enter password: ");
                string userPassword = Console.ReadLine();

                if (userLogin == login && userPassword == password)
                {
                    Console.WriteLine("Enter the System");
                    break;
                }
                else
                {
                    tries--;
                    if (tries == 0)
                    {
                        Console.WriteLine("The number of available tries have been exceeded");
                    }
                }

            }
        }
    }
}
