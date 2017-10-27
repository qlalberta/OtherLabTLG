// StringCompare.cs

using System;

public class StringCompare
{
	public static void Main(string[] args)
	{
		string a1 = "hello";
		string a2 = "hello";
		string b = "HELLO";
		string c = "goodbye";
		Console.WriteLine("{0}.Equals({1}): {2}", a1, a2, a1.Equals(a2));
		Console.WriteLine("String.Equals({0},{1}): {2}", a1, a2, String.Equals(a1,a2));
		Console.WriteLine("Case sensitive...");
		Console.WriteLine("String.Compare({0},{1}): {2}", a1, b, String.Compare(a1,b));
		Console.WriteLine("Case insensitive...");
		Console.WriteLine("String.Compare({0},{1},true): {2}", a1, b, String.Compare(a1,b,true));
		Console.WriteLine("Order relation...");
		Console.WriteLine("String.Compare({0},{1}): {2}", a1, c, String.Compare(a1,c));
		Console.WriteLine("String.Compare({0},{1}): {2}", c, a1, String.Compare(c,a1));
	}
}
