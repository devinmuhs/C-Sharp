using System;

namespace MoneyMaker
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double quarter = 25;
			double dime = 10;
			double nickel = 5;
			Console.WriteLine("Welcome to Money Maker!");
			Console.WriteLine("Please enter an amount of change under $1 to see the most efficient breakdown: ");
			string input = Console.ReadLine();
			double money = Convert.ToDouble(input);
			Console.WriteLine($"{money} cents is equal to...");
			double quarters = Math.Floor(money / quarter);
			double remainder = (money % quarter);
			double dimes = Math.Floor(remainder / dime);
			remainder = (remainder % dime);
			double nickels = Math.Floor(remainder / nickel);
			remainder = (remainder % nickel);
			Console.WriteLine($"Quarters: {quarters}");
			Console.WriteLine($"Dimes: {dimes}");
			Console.WriteLine($"Nickels: {nickels}");
			Console.WriteLine($"Pennies: {remainder}");


		}
	}
}
