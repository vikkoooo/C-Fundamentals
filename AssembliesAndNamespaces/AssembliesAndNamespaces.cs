using System.Net;

namespace AssembliesAndNamespaces
{
	class AssembliesAndNamespaces
	{
		static void Main(string[] args)
		{
			string text = "Write text to file";
			File.WriteAllText(@"path", text);

			WebClient client = new WebClient();
			string reply = client.DownloadString("http://msdn.microsoft.com");

			Console.WriteLine(reply);
			File.WriteAllText(@"path", reply);
		}
	}
}