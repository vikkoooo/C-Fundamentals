namespace HandlingExceptions
{
	class HandlingExceptions
	{
		static void Main(string[] args)
		{
			try
			{
				string content = File.ReadAllText(@"PATH"); // path
				Console.WriteLine(content);
			}
			catch (FileNotFoundException ex)
			{
				Console.WriteLine("There was a problem!");
				Console.WriteLine("Make sure the file name is named correctly: Example.txt");
			}
			catch (DirectoryNotFoundException ex)
			{
				Console.WriteLine("There was a problem!");
				Console.WriteLine(@"Make sure the dictory c:\users\... exists");
			}
			catch (Exception ex)
			{
				Console.WriteLine("there was a problem");
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine("Closing the app now...");
			}
		}
	}
}