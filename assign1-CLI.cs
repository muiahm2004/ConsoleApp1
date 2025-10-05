
using System;

namespace aasignment1
{
	class program
	{
		static void Main(string[] args)
		{
			string name;
			do
			{
				Console.Write("Enter your name: ");
				name = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(name))
				{
					Console.WriteLine("Name cannot be empty,try again.");
				}

			} while (string.IsNullOrWhiteSpace(name));
			name = name.Trim();
			string city;
			do
			{
				Console.Write("Enter your city: ");
				city = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(city))
				{
					Console.WriteLine("City cannot be empty,try again.");
				}
			} while (string.IsNullOrWhiteSpace(city));
			city = city.Trim();
			int age;
			string ageno;
			bool validage = false;
			do
			{
				Console.Write("Enter your age: ");
				ageno = Console.ReadLine();
				ageno = ageno.Trim();
				if (int.TryParse(ageno, out age))
					if (age >= 0 && age <= 120)
					{
						validage = true;
					}
					else
					{
						Console.WriteLine("Age must be between 0 and 120,try again.");
					}
				else
				{
					Console.WriteLine("Invalid input. Please enter a valid age.");
				}
			} while (!validage);
			Console.WriteLine("user profile");
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Age: {age}");
			Console.WriteLine($"City: {city}");
			Console.WriteLine($"\nHello, {name}! great to meet someone from {city} who is {age} years old.");
		}
	}
}