using System;

class Bytes
{
	static void Main(string[] args)
	{
		long bytes = 1024;
		Console.WriteLine("kilo = {0}", bytes);
		bytes = SimpleMath.OneK(bytes);
		Console.WriteLine("mega = {0}", bytes);
		bytes = SimpleMath.OneK(bytes);
		Console.WriteLine("giga = {0}", bytes);
		bytes = SimpleMath.OneK(bytes);
		Console.WriteLine("tera = {0}", bytes);
	}
}
