// Bytes.cs

using System;

class Bytes
{
	static void Main(string[] args)
	{
		int bytes = 1024;
		Console.WriteLine("kilo = {0}", bytes);
		bytes = bytes * 1024;
		Console.WriteLine("mega = {0}", bytes);
		bytes = bytes * 1024;
		Console.WriteLine("giga = {0}", bytes);
		bytes = bytes * 1024;
		Console.WriteLine("tera = {0}", bytes);
	}
}
