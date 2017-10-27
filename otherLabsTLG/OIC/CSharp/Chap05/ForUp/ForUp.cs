// ForUp.cs

using System;

public class ForUp
{
	public static int Main(string[] args)
   {
		int sum = 0;
		for (int i = 1; i <= 100; i++)
		{
			sum += i;
		}
        //i = 3
		Console.WriteLine("sum = {0}", sum);
		// Console.WriteLine("i = {0}", i);
		// i is not defined outside the for loop
		return 0;
	}
}
