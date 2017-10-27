// StringBuilderCompare.cs

using System;
using System.Text;

public class StringBuilderCompare
{
	public static void Main(string[] args)
	{
		StringBuilder a = new StringBuilder("hello");
		StringBuilder b = new StringBuilder("hello");
		Console.WriteLine("a = {0}", a.ToString());
		Console.WriteLine("b = {0}", b.ToString());
		Console.WriteLine("Comparing as StringBuilder object references");
		Console.WriteLine("{0}.Equals({1}): {2}", a, b, a.Equals(b));
		Console.WriteLine("{0} == {1}: {2}", a, b, a ==b);
		string c = a.ToString();
		string d = b.ToString();
		Console.WriteLine("Comparing as String object references");
		Console.WriteLine("{0}.Equals({1}): {2}", c, c, c.Equals(d));
		Console.WriteLine("{0} == {1}: {2}", c, d, c ==d);
	}
}
