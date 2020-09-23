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
            Console.ResetColor();

        }

    }
}
