// StringRelation.cs

using System;

public class StringRelation
{
	public static void Main(string[] args)
	{
		string a1 = "hello";
		string a2 = "hello";
		string b = "HELLO";
		string c = "goodbye";
		Console.WriteLine("{0} == {1}: {2}", a1, a2, a1 == a2);
		Console.WriteLine("{0} == {1}: {2}", a1, b, a1 == b);
		Console.WriteLine("{0} != {1}: {2}", a1, c, a1 != c);
		//Console.WriteLine("{0} < {1}: {2}", a1, c, a1 < c); //illegal
	}
}
