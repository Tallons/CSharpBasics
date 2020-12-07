using System;
using System.Collections.Generic;
using System.Text;

namespace Basics {
    class Inputs {

	    static void inputs()
	    {
		    Console.WriteLine("Please enter your name");
		    string name = Console.ReadLine();
		    Console.WriteLine("Nice to meet you " + name);

		    Console.WriteLine("Please enter your age");
		    string input = Console.ReadLine();
		    int age = int.Parse(input);
		    Console.WriteLine($"You are {0} years old", age);
	    }
    }
}
