// CharacterLiterals.cs

using System;

public class CharacterLiterals
{
	public static int Main(string[] args)
   {
		Console.Write('7');
		Console.Write('\t');
		Console.Write('\x0037');
		Console.Write('\t');
		Console.Write('\u0037');
		Console.Write('\n');
		Console.Write('\'');
		Console.Write('7');
		Console.Write('\'');
		Console.WriteLine();
		return 0;
	}
}