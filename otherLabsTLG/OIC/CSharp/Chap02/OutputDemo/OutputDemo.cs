// OutputDemo.cs

using System;

public class OutputDemo
{
	public static int Main(string[] args)
   {
		int x = 24;
		int y = 5;
		int z = x * y;
		Console.Write("Product of " + x + " and " + y);
		Console.WriteLine(" is " + z);
		Console.WriteLine("The product is {0}", z);
		Console.WriteLine("Product of {0} and {1} is {2}", x,y,z);
		return 0;
	}
}