// NumberToString.cs

using System;

public class NumberToString
{
	public static void Main()
	{
		int number = 444;
		Console.WriteLine(number);
        //string str = number;        // illegal
        string str = number.ToString();
		Console.WriteLine(str);
		Console.WriteLine("number = " + number);
		Console.WriteLine(444.ToString());
	}
}