using System;
using Task2.Models;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            Console.Write("Enter your name: ");
            user.Name = Console.ReadLine();

            Console.Write("Enter your email: ");
            user.Email = Console.ReadLine();

            Console.WriteLine($"Hello {user.Name}!\nYour email: {user.Email}");

            Console.ReadKey();
        }
    }
}
