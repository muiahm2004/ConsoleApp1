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
				Console.Write(" No Of Marks: ");
				string? number = Console.ReadLine();
				if (int.TryParse(number, out n) && n > 0)
					break;
				Console.WriteLine("Enter a positive whole number.");
			}
			int[] marks = new int[n];
			long sum = 0;
			int min = int.MaxValue;
			int max = int.MinValue;
			for (int i = 0; i < n; i++)
			{
				while (true)
				{
					Console.Write($"Mark #{i + 1} (0..100): ");
					string? s = Console.ReadLine();
					if (int.TryParse(s, out int m) && m >= 0 && m <= 100)
					{
						marks[i] = m;
						sum += m;
						if (m < min) min = m;
						if (m > max) max = m;
						break;
					}
					Console.WriteLine("Invalid mark. Enter 0..100.");
				}
			}
			double avg = sum / (double)n;
			Console.WriteLine();
			Console.WriteLine($"Min: {min}, Max: {max}, Avg: {avg:F2}");
			Console.WriteLine("Chart (each * = 1 point above Min):");
			for (int i = 0; i < n; i++)
			{
				int stars = marks[i] - min;
				if (stars < 0) stars = 0;
				Console.Write($"M{i + 1} ({marks[i]}): ");
				for (int k = 0; k < stars; k++) Console.Write('*');
				Console.WriteLine();
			}
		}
	}
}
