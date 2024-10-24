public class Program
{
	static void Main()
	{
		for (int i = 100; i >= 1; i--)
		{
			bool isPrime = true;
			for (int j = i - 1; j > 1; j--)
			{
				if (i % j == 0)
				{
					isPrime = false;
					break;
				}
			}
			string print = "";
			if (i % 3 == 0)
			{
				print += "Foo";
			}
			if (i % 5 == 0)
			{
				print += "Bar";
			}
			if (print == "") { print = i.ToString(); }
			if (!isPrime || i == 1) { Console.Write(print + (i == 1 ? "\n" : ", ")); }
		}
	}
}

