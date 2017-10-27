// Relational.cs

using System;

public class Relational
{
	public static int Main(string[] args)
   {
		int x = 17;
		int y = 5;
		//bool result = (x = y);
		Console.WriteLine("{0} == {1} = {2}", x, y, x == y);
		Console.WriteLine("{0} != {1} = {2}", x, y, x != y);
		Console.WriteLine("{0} < {1} = {2}", x, y, x < y);
		Console.WriteLine("{0} <= {1} = {2}", x, y, x <= y);
		Console.WriteLine("{0} > {1} = {2}", x, y, x > y);
		Console.WriteLine("{0} >= {1} = {2}", x, y, x >= y);
		return 0;
	}
}