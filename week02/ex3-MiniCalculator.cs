using System;

namespace ex3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("1) Add 2) Subtract 3) Multiply 4) Divide Q) Quit");
			Console.Write("Choose: ");
			string? value = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(value) || value.Equals("Q", StringComparison.OrdinalIgnoreCase))
			{
				Console.WriteLine("Goodbye.");
				return;
			}
			Console.Write("A: ");
			if (!double.TryParse(Console.ReadLine(), out double a))
			{
				Console.WriteLine("Bad A (not a number).");
				return;
			}
			Console.Write("B: ");
			if (!double.TryParse(Console.ReadLine(), out double b))
			{
				Console.WriteLine("Bad B (not a number).");
				return;
			}

			double result;
			switch (value.Trim())
			{
				case "1":
					result = a + b; break;
				case "2":
					result = a - b; break;
				case "3":
					result = a * b; break;
				case "4":
					if (b == 0)
					{
						Console.WriteLine("Cannot divide by zero.");
						return;
					}
					result = a / b; break;
				default:
					Console.WriteLine("Invalid choice.");
					return;
			}
			Console.WriteLine($"Result = {result:F2}");
		}
	}
}



