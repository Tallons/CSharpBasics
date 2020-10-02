using System;
using System.Collections.Generic;
using System.Text;

namespace Basics {
    class Conditional {

         public static void conditional( int age, string job) {

            BasicConditional(age, job);
            Ternary(age, job);

        }

        static void BasicConditional(int age, string job) {
            if (age < 0) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect Age");
                Console.ResetColor();
                return;
            }

            if (age < 13 && age > 0) {
                Console.WriteLine("You are a child");
            } else if (age < 18) {
                Console.WriteLine("You are a teenager");
            } else if (age < 30) {
                Console.WriteLine("You are a young adult");
            } else {
                Console.WriteLine("You are OLD!");
            }

            if (job.ToLower() == "developer") {
                Console.WriteLine("Great Job Choice!!");
            }
        }

        static void Ternary(int age, string job) {
            Console.WriteLine(
                (age < 13 && age > 0) ? "You are a child" 
                : (age < 18) ? "You are a teenager" 
                : (age < 30) ? "You are a young adult" 
                : "You are OLD!"
                );
        }

    }
}

