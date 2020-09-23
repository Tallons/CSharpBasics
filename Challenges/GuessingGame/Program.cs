﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Challenges.GuessingGame {
    class Program {
        public static void main() {
            string gameName = "Guessing Game";
            string gameVersion = "1.0.0";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}: Version {1}", gameName, gameVersion);
            Console.ResetColor();
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Hello {0}, Welcome to The {1}! I'll be your host, Ceasar Flickerman!", playerName, gameName);

            Random rnd = new Random();
            int correctNumber = rnd.Next(1, 11);
            int guess = 0;

            Console.WriteLine("Ladies and Gentleman! Today's game involves guessing a number between 1 and 10.");
            Console.WriteLine("Each participant will only have three guesses, remember to use them wisely!");
            Console.WriteLine("If you are correct, Congradulations! You are the next Tribute for District 11!");
            Console.WriteLine("MAY THE ODDS BE EVER IN YOUR FAVOR!");

            int guessNumber = 1;
            int[] guessedNumbers = new int[3];
            Console.WriteLine("Please guess a number");
            while (guess != correctNumber || guessNumber < 3) {
                guess = Int32.Parse(Console.ReadLine());
                if (guessedNumbers.Contains(guess) || guess < 1 || guess > 10){
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("WOW!! WE HAVE A VOLENTEER!! CONGRADULATIONS!! YOU WILL BE IN THIS YEAR'S HUNGER GAMES!!!");
                    Console.ResetColor();
                    return;
                }
                else if (guess != correctNumber && guessNumber < 3) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unfortunately that is not the right number, try again");
                    guessedNumbers[guessNumber - 1] = guess;
                    guessNumber++;
                    Console.ResetColor();
                    Console.WriteLine("Please guess again  | guesses left:" + (3 - guessNumber));

                } else {
                    Console.WriteLine("Unfortunately, you will not be in this year's Hunger Games. Try again next year");
                    Console.WriteLine(guessNumber);
                    return;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CONGRADUATIONS!! YOU WILL BE IN THIS YEAR'S HUNGER GAMES!!!");
            Console.ResetColor();
        }
    }
}