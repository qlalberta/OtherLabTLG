// AbsoluteValue.cs

using System;

public class AbsoluteValue
{
	public static int Main(string[] args)
   {
		int x = 5;
		int abs = (x < 0) ? -x : x;
		Console.WriteLine("x = {0}, abs = {1}", x, abs);
		x = -x;
		abs = (x < 0) ? -x : x;
		Console.WriteLine("x = {0}, abs = {1}", x, abs);
		return 0;
	}
}