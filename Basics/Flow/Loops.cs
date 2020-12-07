using System;
using System.Collections.Generic;
using System.Text;

namespace Basics {
    class Loops {
        public static void loops(string[] names) {
            int NUM = 5;
            BasicForLoop(NUM);
            ForEachLoop(names);
            WhileLoop(names);
            DoWhileLoop(NUM);


        }
        static void BasicForLoop(int num) {
            for (int i = 0; i < num; i++) {
                Console.WriteLine(i);
            }
        }

        static void ForEachLoop(string[] names) {
            foreach (string name in names) {
                Console.WriteLine(name);
            }
        }

        static void WhileLoop(string[] names) {
            int i = 0;
            while (i < names.Length) {
                Console.WriteLine($"{i}: {names[i]}");
                i++;
            }
            
        }
        static void DoWhileLoop(int num) {
            int i = 0;
            do {
                Console.WriteLine(i);
                i++;
            }
            while (i < num);
        }
    }
}
