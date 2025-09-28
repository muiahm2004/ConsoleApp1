using System;

namespace ex1
{
	class program
	{
		static void Main(string[] args)
		{
			Console.Write("enter your first name :");
			string firstname = Console.ReadLine();
			Console.Write("enter your middle name :");
			string middlename = Console.ReadLine();
			Console.Write("enter your last name :");
			string lastname = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname))
			{
				Console.WriteLine("first and last name cannot be empty");
				return;
			}
			firstname = firstname.Trim();
			middlename = middlename.Trim();
			lastname = lastname.Trim();
			char firstinitial = firstname[0];
			char lastinitial = lastname[0];
			char middleinitial;
			if (string.IsNullOrWhiteSpace(middlename))
			{
				middleinitial = '.';
			}
			else
			{
				middleinitial = middlename[0];
			}
			string initials = $"{char.ToUpperInvariant(firstinitial)}{char.ToUpperInvariant(middleinitial)}{char.ToUpperInvariant(lastinitial)}";
			Console.WriteLine($"Hello,{firstname} {middlename} {lastname}({initials})");
		}
	}
}




