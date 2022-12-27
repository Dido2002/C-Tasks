using System;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] daysOfTheWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
			int day = int.Parse(Console.ReadLine());

			if (day >= 1 && day <= 7)
			{
				//THis is how to take the current day we take 1 because the array start with number 0
				Console.WriteLine($"The day of the week is: { daysOfTheWeek[day - 1]}");
			}
			else {
				Console.WriteLine("You got something wrong!Try again");
			}

		}
	}
}
