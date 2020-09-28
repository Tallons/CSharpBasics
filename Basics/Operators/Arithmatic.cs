using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    class Arithmatic {
        public static void arithmatic(int num1, int num2) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Numbers: " + num1 + ", " + num2);
            Console.WriteLine("Addition: " + (num1 + num2));
            Console.WriteLine("Subtaction: " + (num1 - num2));
            Console.WriteLine("Multiplication: " + (num1 * num2));
            Console.WriteLine("Division: " + (num1 / num2));
            Console.WriteLine("Modulus: " + (num1 % num2));
            Console.WriteLine(num1 + " Squared: " + Math.Pow(num1, 2));
            Console.WriteLine(num1 + " Square Root: " + Math.Sqrt(num1));
            Console.WriteLine(50.5 + " Round: " + Math.Round(50.5, 0, MidpointRounding.AwayFromZero));
            Console.WriteLine(50.5 + " Round up: " + Math.Ceiling(50.5));
            Console.WriteLine(50.5 + " Round down: " + Math.Floor(50.5));
            Console.WriteLine(" Minimum: " + Math.Min(num1, num2));
            Console.WriteLine(" Maximum: " + Math.Max(num1, num2));
            Console.ResetColor();

        }

    }
}
