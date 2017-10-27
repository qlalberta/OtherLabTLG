// Unchecked.cs

using System;

public class Unchecked
{
	public static int Main(string[] args)
   {
		int x = 99999;
		int y = 99999;
		int z = unchecked (99999 * 99999);
		Console.WriteLine("compiled: {0}*{1} = {2}",x,y,z);
		z = x * y;
		Console.WriteLine("runtime: {0}*{1} = {2}",x,y,z);
		return 0;
	}
}