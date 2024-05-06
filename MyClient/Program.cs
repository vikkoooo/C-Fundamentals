using MyCodeLibrary;

namespace MyClient
{
	class Program
	{
		static void Main(string[] args)
		{
			Scrape myScrape = new Scrape();
			string value = myScrape.ScrapeWebpage("www.google.com");
			Console.WriteLine(value);
		}
	}
}