﻿using System;

namespace NameOfVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightInMetres = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");
        }
    }
}
