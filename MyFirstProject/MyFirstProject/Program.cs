﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your lastname");
            string lastname= Console.ReadLine();
            Console.WriteLine("Hello ",name," ",lastname);
            Console.WriteLine();
        }
    }
}
