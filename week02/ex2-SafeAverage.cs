using System;

namespace ex2
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] values = new double[3];

			for (int i = 0; i < values.Length; i++)
			{
				while (true)
				{
					Console.Write($"Enter number {i + 1}: ");
					string? number = Console.ReadLine();
					if (double.TryParse(number, out double no))
					{
						values[i] = no;
						break;
					}
					else
					{
						Console.Write("invalid number");
					}
				}
			}

			double sum = 0;
			for (int i = 0; i < values.Length; i++)
			sum += values[i];
	        double avg = sum / values.Length;
		    Console.WriteLine($"Average = {avg:F2}");
			
		}
	}
}
