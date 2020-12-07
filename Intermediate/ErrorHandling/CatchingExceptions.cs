

using System;

namespace Intermediate.ErrorHandling
{
	public class CatchingExceptions
	{
		public void RollDie()
		{
			try
			{
				// something
			}
			catch (ArgumentException e) // make sure to use specific exceptions
			{
				Console.WriteLine(e.Message);
				// add "throw;" if you still want the program to crash
			}
			catch (FormatException e) // you can use multiple exceptions
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				// This code will run regardless of whether or not an exception was thrown
			}
		}
	}
}