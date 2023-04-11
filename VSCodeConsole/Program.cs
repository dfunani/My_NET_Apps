using Humanizer;

internal class Program
{
	private static void Main(string[] args)
	{
		int res = 0;
		int.TryParse("0250", out res);
		Console.WriteLine(res);
		// See https://aka.ms/new-console-template for more information
		/*Console.WriteLine("Quantities:");
		HumanizeQuantities();

		Console.WriteLine("\nDate/Time Manipulation:");
		HumanizeDates(); */

		/* IEnumerable<string> dir = Directory.EnumerateFiles(".", "*.cs*", SearchOption.AllDirectories);
		foreach (string file in dir)
		{
			Console.WriteLine(file);
		}
		 */
		Console.WriteLine(Environment.CommandLine);
	}

	static void HumanizeQuantities()
	{
		Console.WriteLine("case".ToQuantity(0));
		Console.WriteLine("case".ToQuantity(1));
		Console.WriteLine("case".ToQuantity(5));
	}

	static void HumanizeDates()
	{
		Console.WriteLine(DateTime.UtcNow.AddHours(-48).Humanize());
		Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
		Console.WriteLine(TimeSpan.FromDays(1).Humanize());
		Console.WriteLine(TimeSpan.FromDays(16).Humanize());
	}
}