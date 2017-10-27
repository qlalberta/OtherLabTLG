// MoneyConvert.cs

using System;

public class MoneyConvert
{
	public static void Main()
	{
		Money x = new Money("30.33");
		Console.WriteLine(x.MoneyStr);
		Money a = new Money();
		a = (Money) "40.44";
		Console.WriteLine((string) a);
		a = (Money) 50.55;
		Console.WriteLine((string) a);
		a = (Money) 60.66m;
		Console.WriteLine((string) a);
		string s = a;
		Console.WriteLine("a = (string) {0}", s);
		double b = a;
		Console.WriteLine("a (double) = {0}", b);
		decimal c = a;
		Console.WriteLine("a (decimal) = {0:C}", c);
	}
}