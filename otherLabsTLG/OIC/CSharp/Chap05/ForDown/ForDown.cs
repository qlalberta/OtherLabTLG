// ForDown.cs

using System;

public class ForDown
{
	public static int Main(string[] args)
   {
		int sum = 0;
		int i;
		for (i = 100; i >= 1; i--)
		{
			sum += i;
		}
		Console.WriteLine("sum = {0}", sum);
		Console.WriteLine("i = {0}", i);
        //Console.ReadLine();
		// i is defined outside the for loop
		return 0;
	}
}
