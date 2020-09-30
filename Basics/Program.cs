using Basics;
using System;

namespace Basics {
    class Program {
        public static void main() {
            string name = "Brandon";
            int age = 25;
            Console.WriteLine($"{name} is {age}");
            //Console.WriteLine("{0} is {1}", name, age);

            Arithmatic.arithmatic(15,12);
            Conditional.conditional(15, "developer");
            Strings.strings();
        }
    }
}
