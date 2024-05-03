using System.Globalization;
using System.Xml.XPath;

namespace WhileIteration
{
	class Program
	{
		static void Main(string[] args)
		{
			bool displayMenu = true;
			while (displayMenu)
			{
				displayMenu = MainMenu();
			}
		}

		private static bool MainMenu()
		{
			Console.WriteLine("Choose an option");
			Console.WriteLine("1) Option 1");
			Console.WriteLine("2) Option 2");
			Console.WriteLine("3) Exit");
			string result = Console.ReadLine();
			if (result == "1")
			{
				PrintNumbers();
				return true;
			}
			else if (result == "2")
			{
				GuessingGame();
				return true;
			}
			else if (result == "3")
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		private static void PrintNumbers()
		{
			Console.Clear();
			Console.WriteLine("Print numbers");
			Console.Write("Type a number: ");
			string stringResult = Console.ReadLine();
			int result = int.Parse(stringResult);
			int counter = 1;
			while (counter <= result)
			{
				Console.Write(counter);
				Console.Write("-");
				counter++;
			}
			Console.ReadLine();
		}

		private static void GuessingGame()
		{
			Console.Clear();
			Console.WriteLine("Guessing game!");

			Random myRand = new Random();
			int randomNumber = myRand.Next(1, 11);

			int guesses = 0;
			bool incorrect = true;

			do
			{
				Console.WriteLine("Guess a number between 1 and 10: ");
				string result = Console.ReadLine();
				guesses++;
				if (result == randomNumber.ToString())
					incorrect = false;
				else
					Console.WriteLine("Wrong!");
			} while (incorrect);
			Console.WriteLine("Correct! It took you {0} guesses", guesses);
			Console.ReadLine();
		}
	}
}