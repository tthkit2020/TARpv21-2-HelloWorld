﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //program asks the user to enter their first name
            //program greets the user using their first name

            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("enter your last name:");
            string lastName = Console.ReadLine();
            //Console.WriteLine("Hello " + firstName + "!");

            //string interpolation
            Console.WriteLine($"Hello, {firstName} {lastName}!");

            Console.Read();
        }
    }
}
