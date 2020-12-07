using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics.Basics
{
	class Lists
	{
		public void main()
		{
			List<double> grades = new List<double>() {92.5, 97.6, 82.7};
			grades.Add(85.0);

			var result = 0.0;
			foreach (var number in grades)
			{
				result += number;
			}
			Console.WriteLine($"Average Grade: {(result / grades.Count):N3}");

		}
		

	}
}
