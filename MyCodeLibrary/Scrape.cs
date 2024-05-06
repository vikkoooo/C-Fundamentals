using System.Net;
using System.Runtime.InteropServices;

namespace MyCodeLibrary;
public class Scrape
{
	public string ScrapeWebpage(string url)
	{
		return getWebpage(url);
	}

	public string ScrapeWebpage(string url, string filepath)
	{
		string reply = getWebpage(url);

		File.WriteAllText(filepath, reply);
		return reply;
	}

	private string getWebpage(string url)
	{
		WebClient client = new WebClient();
		return client.DownloadString(url);
	}

}
