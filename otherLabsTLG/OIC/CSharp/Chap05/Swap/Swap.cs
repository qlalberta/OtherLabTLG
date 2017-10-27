// Swap.cs

using System;

public class Swap
{
	public static int Main(string[] args)
   {
		int x = 5;
		int y = 12;
		Console.WriteLine("Before: x = {0}, y = {1}", x, y);
		if (x < y)
		{
			int temp = x;
			x = y;
			y = temp;
		}
		Console.WriteLine("After: x = {0}, y = {1}", x, y);
		Console.WriteLine("temp = {0}", temp);
		return 0;
	}
}
