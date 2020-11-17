using System;

namespace NeverMind
{
	class Program
	{
		public enum TimeOfDay
		{
			Morning = 0,
			Afternoon = 1,
			Evening = 2
		}

		public static void Main()
		{
			// using enums makes your code much clearer 
			WriteGreeting(TimeOfDay.Evening);
			// passing an integer is not clear to the reader
			WriteGreeting(0);

			// parsing enums
			Console.WriteLine(Enum.Parse(typeof(TimeOfDay), "Morning"));
		}

		static void WriteGreeting(TimeOfDay timeOfDay)
		{
			// switch based on the TimeOfDay passes in timeOfDay
			switch (timeOfDay)
			{
				case TimeOfDay.Morning:
					Console.WriteLine("Good morning!");
					break;
				case TimeOfDay.Afternoon:
					Console.WriteLine("Good afternoon!");
					break;
				case TimeOfDay.Evening:
					Console.WriteLine("Good evening!");
					break;
				default:
					Console.WriteLine("Case not found");
					break;
			}
		}

		static void WriteGreeting(int timeOfDay)
		{
			// switch based on the integer passed
			switch (timeOfDay)
			{
				case 0:
					Console.WriteLine("Good morning!");
					break;
				case 1:
					Console.WriteLine("Good afternoon!");
					break;
				case 2:
					Console.WriteLine("Good evening!");
					break;
				default:
					Console.WriteLine("Case not found");
					break;
			}
		}
	}
}