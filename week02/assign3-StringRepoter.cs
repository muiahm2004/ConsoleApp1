using System;

namespace assignment3
{
	class Program
	{
		static void Main(string[] args)
		{
			 Console.Write("Full name: ");
			 string? Name = Console.ReadLine();
			 Console.Write("City: ");
			string? City = Console.ReadLine();
			 if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(City))
				{
				 Console.WriteLine("Both name and city are required.");
				 return;
			    }
            string fullname = Name.Trim();
	        string city = City.Trim();

           string[] parts = fullname.Split(' ', StringSplitOptions.RemoveEmptyEntries);
		   char firstInitial = char.ToUpperInvariant(parts[0][0]);
	       char lastInitial = (parts.Length > 1)
           ? char.ToUpperInvariant(parts[^1][0]) 
           : '_'; 
           string initials = (lastInitial == '_')
           ? $"{firstInitial}."
           : $"{firstInitial}.{lastInitial}.";
          int nameLength = fullname.Length;
		string id = $"{city.ToUpperInvariant()}_{firstInitial}{(lastInitial == '_' ? '_' : lastInitial)}_{nameLength}";
               Console.WriteLine($"Hello, {fullname} ({initials}) from {city}");
			   Console.WriteLine($"Name length: {nameLength}");
			   Console.WriteLine($"ID: {id}");
		}
	}
}