// CharCode.cs
//
// Shows some character codes

using System;

public class CharCode
{
	public static void Main(string[] args)
	{
		byte nA = (byte) 'A';
		byte nZ = (byte) 'Z';
		for (int i = nA; i <= nZ; i++)
		{
			Console.Write(i + "  ");
			Console.WriteLine((char) i);
		}
		char ch = '\u0041';
		Console.WriteLine(ch);
	}
}
