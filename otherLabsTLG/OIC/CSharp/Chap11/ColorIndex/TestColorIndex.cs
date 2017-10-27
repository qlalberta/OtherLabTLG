// TestColorIndex.cs

using System;

public class TestColorIndex
{
	public static void Main(string[] args)
	{
		ColorIndex ci = new ColorIndex();
		Console.WriteLine(ci.Color);
		Console.WriteLine("red = {0}", ci[0]);
		Console.WriteLine("green = {0}", ci[1]);
		Console.WriteLine("blue = {0}", ci[2]);
		ci[0] = 77;
		ci[1] = 133;
		ci[2] = 199;
		Console.WriteLine(ci.Color);
	}
}