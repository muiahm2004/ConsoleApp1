using System;

namespace ex1
{
	class Program
	{
		static void Main(string[] args)
			{
			Console.Write("Enter text: ");
			string? text = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(text))
			{
				Console.WriteLine("No text entered.");
			}
			else
			{
				string trimmed = text.Trim();
				Console.WriteLine($"Trimmed: {trimmed}");
				Console.WriteLine($"UPPER : {trimmed.ToUpperInvariant()}");
				Console.WriteLine($"lower : {trimmed.ToLowerInvariant()}");
				Console.WriteLine($"Length (raw): {text.Length}");
				Console.WriteLine($"Length (trim): {trimmed.Length}");
			}
		}
	}
}