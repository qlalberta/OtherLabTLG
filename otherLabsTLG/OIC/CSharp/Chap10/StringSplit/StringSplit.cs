// StringSplit.cs

using System;

public class StringSplit
{
	public static void Main(string[] args)
	{
		string all = "San Francisco\tHilton\t150\t89.95";
		char[] seps = {'\t'};
		string[] pieces = all.Split(seps);
		foreach (string piece in pieces)
			Console.WriteLine(piece);
	}
}
