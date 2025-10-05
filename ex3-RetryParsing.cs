using System;

namespace ex3
{
	class program
	{    
		static void Main(string[] args)
		{
			int attempts = 0;
			const int maxattempts = 3;
			bool success = false;
            while (attempts < maxattempts)
			{
				Console.Write($"Attempt {attempts + 1} of {maxattempts}. Please enter an integer: ");
				string input = Console.ReadLine();
                success = int.TryParse(input, out int parsedNumber);
				if (success)
				{
					Console.WriteLine($"\nSuccess! You entered the integer: {parsedNumber}.");
					break; 
				}
				else
				{
					Console.WriteLine($" '{input}' is not a valid integer. Please try again.");
				    attempts++;
				}
			}
            if (!success)
			{
				Console.WriteLine("\n All attempts failed");
				Console.WriteLine("The program will not execute");
			}
		}
	}

}
	