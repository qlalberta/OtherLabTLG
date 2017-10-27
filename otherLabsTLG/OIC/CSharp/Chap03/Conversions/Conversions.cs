// Conversions.cs

using System;

public class Conversions
{
	public static int Main(string[] args)
	{
		// float pi = 3.14;					// compiler error
		float pi = (float) 3.14;
		Console.WriteLine("pi = " + pi);
		// short seven = '7';			// compiler error
		short seven = (short) '7';		// cast
		ushort useven = '7';				// ok
		Console.WriteLine("seven = " + seven);
		Console.WriteLine("useven = " + useven);
		//int itrue = (int) true;		// cast fails
		int itrue = Convert.ToInt32(true);
		int ifalse = Convert.ToInt32(false);
		Console.WriteLine("itrue = " + itrue);
		Console.WriteLine("ifalse = " + ifalse);
		return 0;
	}
}