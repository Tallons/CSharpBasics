using System;

namespace Intermediate.ErrorHandling
{
	public class ThrowingExceptions
	{
		public void AddD6Roll(int D6Value)
		{
			if (D6Value <= 6 && D6Value >= 1)
			{
				// add roll
			}
			else
			{
				throw new ArgumentException($"Invalid Die Roll {nameof(D6Value)}");
			}
		}
	}
}