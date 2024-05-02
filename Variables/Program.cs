namespace Variables
{
	class Program
	{
		static void Main(string[] args)
		{
			int y;
			int x;

			x = 7;
			y = x + 3;

			Console.WriteLine($"y = {y}");

			Console.WriteLine("What is your name?");
			Console.Write("Type your first name: ");
			string myFirstName = Console.ReadLine();

			Console.Write("Type your last name: ");
			string myLastName = Console.ReadLine();

			Console.WriteLine($"Hello, {myFirstName} {myLastName}");
		}
	}
}