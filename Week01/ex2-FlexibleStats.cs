using System;

namespace ex02
{
	class program
	{
		static void Main(string[] args)
		{
			int count = 0;
			int sum = 0;
			int min = int.MaxValue;
			int max = int.MinValue;
			while (true)
			{
				Console.Write("Enter number: ");
				string input = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(input))
				{
					break;
				}
				if (int.TryParse(input, out int number))
				{
					count++;
					sum += number;
					if (number < min)
					{
						min = number;
					}
					if (number > max)
					{
						max = number;
					}
				}
				else
				{
					Console.WriteLine("Invalid input. Please enter a whole number.");
				}
			}
			Console.WriteLine("\n----------------------------------");

			if (count > 0)
			{
				double average = (double)sum / count;
				Console.WriteLine($"Count: {count}");
				Console.WriteLine($"Sum: {sum}");
				Console.WriteLine($"Min: {min}");
				Console.WriteLine($"Max: {max}");
				Console.WriteLine($"Average: {average:F2}");
			}
			else
			{
				Console.WriteLine("No numbers were entered.");
			}
			Console.WriteLine("---------------------------------------");
		}
	}
}