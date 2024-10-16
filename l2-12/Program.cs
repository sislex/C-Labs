// Используя цикл, попросите пользователя ввести пароль. Программа должна продолжать запрашивать пароль до тех пор, пока пользователь не введет правильный пароль.

using System;

namespace Password
{
    class Program
    {
        static void Main()
        {
            string password = "password";
            string userPassword;
            do
            {
                Console.Write("Enter password: ");
                userPassword = Console.ReadLine();
            } while (userPassword != password);
            Console.WriteLine("Password is correct!");
        }
    }
}

