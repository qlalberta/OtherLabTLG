// ArrayMethods.cs

using System;

public class ArrayMethods
{
	public static void Main()
	{
		int [] a = {5, 2, 11, 7, 3};
		Array.Sort(a);		// sorts the array
		for (int i = 0; i < a.Length; i++)
			Console.Write("{0} ", a[i]);
		Console.WriteLine();
		int target = 5;
		int index = Array.BinarySearch(a, target);
		if (index < 0)
			Console.WriteLine("{0} not found", target);
		else
			Console.WriteLine("{0} found at {1}", target, index);
	}
}