// PowerFormat.cs

using System;

public class PowerFormat
{
	public static void Main()
	{
		long bigint = 1;
		decimal bigdecimal = 1;
		decimal smalldecimal = 1;
		double bigdouble = Math.Pow(2, 60);
		double smalldouble = Math.Pow(2, -60);
		for (int i = 1; i <= 60; i++)
		{
			bigint *= 2;
			bigdecimal *= 2;
			smalldecimal /= 2;
		}
		Console.WriteLine("{0,36:D}", bigint);
		Console.WriteLine("{0,36:N0}", bigint);
		Console.WriteLine("{0,36:N4}", bigint);
		Console.WriteLine("{0,36:X} (hex)", bigint);
		Console.WriteLine("{0,36:N0}", bigdecimal);
		Console.WriteLine("{0,36:F}", bigdouble);
		Console.WriteLine("{0,36:G}", smalldouble);
		Console.WriteLine("{0,36:F26}", smalldouble);
		Console.WriteLine("{0,36:E26}", smalldouble);
	}
}