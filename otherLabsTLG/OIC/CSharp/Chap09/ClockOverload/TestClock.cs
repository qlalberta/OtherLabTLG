// TestClock.cs

using System;

public class TestClock
{
	public static void Main(string[] args)
	{
		Clock c1 = new Clock(17);
		Console.WriteLine("c1 = {0}", c1.Hour);
		Clock c2 = new Clock(10);
		Console.WriteLine("c2 = {0}", c2.Hour);
		Clock c3 = c1 + c2;
		Console.WriteLine("c3 = {0}", c3.Hour);
		c3 += 1;
		Console.WriteLine("c3 + 1 = {0}", c3.Hour);
	}
}
