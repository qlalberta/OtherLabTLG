// StringMethods.cs

using System;

public class StringMethods
{
	public static void Main(string[] args)
	{
		string str = "hello";
		Console.WriteLine("str = {0}", str);
		int n = str.Length;						// 5
		Console.WriteLine("n = {0}", n);
		str = "goodbye";
		str = str.ToUpper();					// GOODBYE
		Console.WriteLine("str = {0}", str);
		str = str.ToLower();					// goodbye
		Console.WriteLine("str = {0}", str);
		string sub = str.Substring(4,3);	// bye
		Console.WriteLine("sub = {0}", sub);
		str = "goodbye";
		int n1 = str.IndexOf("bye");		// 4
		int n2 = str.IndexOf("boo");		// -1
		Console.WriteLine("n1 = {0}", n1);
		Console.WriteLine("n2 = {0}", n2);
	}
}
