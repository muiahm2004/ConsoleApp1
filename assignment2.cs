using System;

namespace assignment2
	{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			while (true)
			{
				Console.Write("Enter the number of temperature readings (N > 0): ");
				string input = Console.ReadLine();

				if (int.TryParse(input, out n) && n > 0)
				{
					break;
				}
				else
				{
					Console.WriteLine("Invalid input. Please enter a positive integer.");
				}
			}
			int[] temps = new int[n];

			for (int i = 0; i < n; i++)
			{
				while (true)
				{
					Console.Write($"Enter temperature reading {i + 1}: ");
					string input = Console.ReadLine();

					if (int.TryParse(input, out temps[i]))
					{
						break;
					}
					else
					{
						Console.WriteLine("Invalid input. Please enter an integer.");
					}
				}
			}
			int min = temps[0];
			int max = temps[0];

		
			long sum = 0;
			foreach (int temp in temps)
			{
				
				if (temp < min)
				{
					min = temp;
				}
				
				if (temp > max)
				{
					max = temp;
				}
				
				sum += temp;
			}
			double avg = (double)sum / n;

			Console.WriteLine("\n--- Temperature Statistics ---");
			Console.WriteLine($"Minimum Temperature: {min}");
			Console.WriteLine($"Maximum Temperature: {max}");
			Console.WriteLine($"Average Temperature: {avg:F2}");
			Console.WriteLine("\n--- Histogram ---");
			foreach (int temp in temps)
			{
				Console.Write($"{temp,3}: ");
				for (int i = 0; i < temp; i++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
