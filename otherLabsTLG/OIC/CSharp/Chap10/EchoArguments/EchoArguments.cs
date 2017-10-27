// EchoArguments.cs

using System;

public class EchoArguments
{
	public static void Main(string[] args)
	{
		foreach (string arg in args)
			Console.WriteLine(arg);
	}
}