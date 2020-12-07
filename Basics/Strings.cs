using System;
using System.Collections.Generic;
using System.Text;

namespace Basics {
    class Strings {

       public static void strings() {
            string job = "Developer";
            string sentence = "My sister ran a marathon.";
            string doubleQuotes = "The old man said, \"Beat it! or I'll call the brute squad!\" ";
            string stringLiteral = @"The old man said, ""Beat it! or I'll call the brute squad!""";

            char[] letters = { 'h', 'e', 'l', 'l', 'o' };
            CharToString(letters);
            CompareStrings(job);
            IndexOfStrings(job);
            RemovePartOfString(job);
            SplitStrings(sentence);

        }
        static void CharToString(char[] letters) {

            string name = "Maggie";
            string greeting = new string(letters);
            Console.WriteLine($"{greeting} {name}");
        }

        static void CompareStrings(string job) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Are you a Developer?: " + (job.ToLower() == "developer"));

            int position = job.CompareTo("Developer");
            // CompareTo returns an int: 0 means the same, 11 means before, -1 means after
            // clerical worker = 1, electrician = -1: This can be useful for sorting
            Console.WriteLine("Compared String position: " + position);
            Console.ResetColor();
        }

        static void IndexOfStrings(string job) {
            int position = job.IndexOf("vel");
            Console.WriteLine(job + " position of 'vel' is: " + position);   
            //position = job.IndexOf("e",2, 5);
            //Console.WriteLine(job + " position of 'e' is: " + position);
        }

        static void RemovePartOfString(string job) {
            Console.WriteLine(job + " --> remove 'vel': " + job.Remove(2, 3));
        }

        static void SplitStrings(string sentence) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("senetence: " + sentence);
            string[] words = sentence.Split(' ');
            foreach (string word in words) {
                Console.WriteLine(word);
            }
            Console.ResetColor();
        }
    }
}
