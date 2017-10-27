// CharTest.cs
//
//  Test simple operations on characters

using System;

public class CharTest
{
	public static void Main(string[] args)
	{
		char ch1 = 'a';
		char ch2 = 'b';
		Console.WriteLine("ch1 = {0}, ch2 = {1}", ch1, ch2);
		// demonstrate inequality for char
		if (ch1 < ch2)
			Console.WriteLine(ch1 + " < " + ch2);
		else if (ch1 == ch2)
			Console.WriteLine(ch1 + " == " + ch2);
		else
			Console.WriteLine(ch1 + " > " + ch2);
        
		// demonstrate casting between integers
		int n = (int) ch1;
		n++;
		ch1 = (char) n;
		Console.Write("After increment: ");
		Console.WriteLine("ch1 = {0}, ch2 = {1}", ch1, ch2);
		if (ch1 < ch2)
			Console.WriteLine(ch1 + " < " + ch2);
		else if (ch1 == ch2)
			Console.WriteLine(ch1 + " == " + ch2);
		else
			Console.WriteLine(ch1 + " > " + ch2);
	}
}
