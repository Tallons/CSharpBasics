using System;

namespace CSharpBasics.Basics
{
	public class Jumping
	{
		private void BreakLoop()
		{
			for (var i = 0; i < 15; i++)
			{
				if (i == 7) break;
				Console.WriteLine(i);
			}

		}

		private void ContinueLoop()
		{
			for (var i = 0; i < 15; i++)
			{
				if (i == 7) continue;
				Console.WriteLine(i);
			}

		}
	}
}