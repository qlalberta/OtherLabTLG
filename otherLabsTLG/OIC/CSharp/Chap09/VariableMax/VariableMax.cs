// VariableMax.cs

using System;

public class VariableMax
{
	public static void Main()
	{
		Console.WriteLine("max of {0}, {1} = {2}", 5,7,FindMax(5,7));
		Console.WriteLine("max of {0}, {1}, {2} = {3}", 500,5,7,FindMax(500,5,7));
		Console.WriteLine("max of {0}, {1}, {2}, {3} = {4}", 500,5,7,80,FindMax(500,5,7,80));
	}
	static int FindMax(int a, int b)
	{
		Console.WriteLine("FindMax with Two Parameters");
		return a < b ? b : a;
	}
	static int FindMax(params int[] args)
	{
		Console.WriteLine("FindMax with Variable Number of Parameters");
		int imax = Int32.MinValue;
		for (int i = 0; i < args.Length; i++)
		{
			if (args[i] > imax)
				imax = args[i];
		}
		return imax;
	}
}