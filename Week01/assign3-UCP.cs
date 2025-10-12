using System;
using System.Globalization;

public class assignment03
{
	private static int lastChoice = 0;

	public static void Main(string[] args)
	{
		bool showMenu = true;
		try
		{
			Console.SetWindowSize(80, 25);
		}
		catch
		{
		}

		while (showMenu)
		{
			showMenu = MainMenu();
		}

		Console.WriteLine("\nExiting the application. Goodbye! 👋");
	}

	private static bool MainMenu()
	{
		Console.Clear();
		Console.WriteLine("---------------------------------------------");
		Console.WriteLine("        Unit Conversion Menu 📏🔄");
		Console.WriteLine("---------------------------------------------");
		Console.WriteLine("1. Kilometers (km) to Miles (mi)");
		Console.WriteLine("2. Kilograms (kg) to Pounds (lb)");
		Console.WriteLine("3. Celsius (°C) to Fahrenheit (°F)");
		Console.WriteLine("4. Meters (m) to Feet (ft)");

		if (lastChoice >= 1 && lastChoice <= 4)
		{
			string lastChoiceName = GetConversionName(lastChoice);
			Console.WriteLine($"\n[Enter] to repeat last choice ({lastChoice} - {lastChoiceName})");
		}

		Console.WriteLine("\n5. Exit");
		Console.WriteLine("---------------------------------------------");

		Console.Write("Enter your choice (1-5 or [Enter]): ");
		string input = Console.ReadLine();

		if (string.IsNullOrEmpty(input) || input.Equals("\n", StringComparison.OrdinalIgnoreCase))
		{
			if (lastChoice >= 1 && lastChoice <= 4)
			{
				Console.WriteLine($"\nRepeating last choice: {lastChoice} - {GetConversionName(lastChoice)}");
				HandleChoice(lastChoice);
				return true;
			}
			else
			{
				Console.WriteLine("\n⚠️ No previous choice to repeat. Please enter a number.");
				Console.WriteLine("Press Enter to continue...");
				Console.ReadLine();
				return true;
			}
		}

		int choice;
		if (int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out choice))
		{
			if (choice == 5)
			{
				return false;
			}
			else if (choice >= 1 && choice <= 4)
			{
				HandleChoice(choice);
				lastChoice = choice;
				return true;
			}
			else
			{
				Console.WriteLine($"\n🚫 Invalid choice: {choice}. Please enter a number between 1 and 5.");
				Console.WriteLine("Press Enter to continue...");
				Console.ReadLine();
				return true;
			}
		}
		else
		{
			Console.WriteLine($"\n🚫 Invalid input: '{input}'. Please enter a number or press Enter.");
			Console.WriteLine("Press Enter to continue...");
			Console.ReadLine();
			return true;
		}
	}

	private static void HandleChoice(int choice)
	{
		Console.WriteLine($"\n--- {GetConversionName(choice)} ---");

		Console.Write("Enter the value to convert: ");
		string valueInput = Console.ReadLine();

		double value;
		if (!double.TryParse(valueInput, NumberStyles.Any, CultureInfo.InvariantCulture, out value))
		{
			Console.WriteLine("\n❌ Invalid value entered. Please enter a numerical value.");
			Console.WriteLine("Press Enter to return to the menu...");
			Console.ReadLine();
			return;
		}

		double result;
		string unitIn = "", unitOut = "";
		string format = "F2";

		switch (choice)
		{
			case 1:
				result = value * 0.621371;
				unitIn = "km";
				unitOut = "mi";
				break;
			case 2:
				result = value * 2.20462;
				unitIn = "kg";
				unitOut = "lb";
				break;
			case 3:
				result = (value * 9 / 5) + 32;
				unitIn = "°C";
				unitOut = "°F";
				break;
			case 4:
				result = value * 3.28084;
				unitIn = "m";
				unitOut = "ft";
				break;
			default:
				Console.WriteLine("Error: Conversion choice not recognized.");
				Console.WriteLine("Press Enter to return to the menu...");
				Console.ReadLine();
				return;
		}

		Console.WriteLine($"\n✅ Result: {value.ToString(format)}{unitIn} is equal to {result.ToString(format)}{unitOut}.");

		Console.WriteLine("Press Enter to return to the main menu...");
		Console.ReadLine();
	}

	private static string GetConversionName(int choice)
	{
		switch (choice)
		{
			case 1: return "Kilometers to Miles (km→mi)";
			case 2: return "Kilograms to Pounds (kg→lb)";
			case 3: return "Celsius to Fahrenheit (°C→°F)";
			case 4: return "Meters to Feet (m→ft)";
			default: return "Unknown Conversion";
		}
	}
}