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

            Console.WriteLine($"Hello {user.Name}!");

            Console.ReadKey();
        }
    }
}
