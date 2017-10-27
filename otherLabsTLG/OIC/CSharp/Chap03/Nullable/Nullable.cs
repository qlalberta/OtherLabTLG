using System;

class Nullable
{
	public static void Main()
	{
		int? number = null;
		ShowNumber(number);
		number = 37;
		ShowNumber(number);
	}
	private static void ShowNumber(int? number)
	{
		if (number.HasValue)
			Console.WriteLine(number);
		else
			Console.WriteLine("UNDEFINED");
	}
}
