// TestInitial.cs

using System;

public class TestInitial
{
	private static int b;
	private int c = 1;
	private int d;
	public TestInitial()
	{
		Console.WriteLine("In TestInitial constructor");
		Console.WriteLine("c = {0}", c);
		Console.WriteLine("d = {0}", d);
		d = 2;
	}
	public static void Main(string[] args)
	{
		int a;
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
		TestInitial ti = new TestInitial();
		Console.WriteLine("In Main after TestInitial object constructed");
		Console.WriteLine("c = {0}", ti.c);
		Console.WriteLine("d = {0}", ti.d);
	}
}