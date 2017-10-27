using System;

class Bytes
{
	static void Main(string[] args)
	{
		long bytes = 1024;
		Console.WriteLine("kilo = {0}", bytes);
		bytes = OneK(bytes);
		Console.WriteLine("mega = {0}", bytes);
		bytes = OneK(bytes);
		Console.WriteLine("giga = {0}", bytes);
		bytes = OneK(bytes);
		Console.WriteLine("tera = {0}", bytes);
	}
	static long OneK(long x)
	{
		return 1024 * x;
	}
}
