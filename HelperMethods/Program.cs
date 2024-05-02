namespace HelperMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("The Name Game");

			Console.Write("What's your first name? ");
			string firstName = Console.ReadLine();

			Console.Write("What's your last name? ");
			string lastName = Console.ReadLine();

			Console.Write("In what city were you born? ");
			string city = Console.ReadLine();

			char[] firstNameArray = firstName.ToCharArray();
			Array.Reverse(firstNameArray);

			char[] lastNameArray = lastName.ToCharArray();
			Array.Reverse(lastNameArray);

			char[] cityArray = city.ToCharArray();
			Array.Reverse(cityArray);

			string result = "";

			foreach (char c in firstNameArray)
			{
				result += c;
			}

			foreach (char c in lastNameArray)
			{
				result += c;
			}

			foreach (char c in cityArray)
			{
				result += c;
			}

			Console.WriteLine("Results: " + result);
		}
	}
}
