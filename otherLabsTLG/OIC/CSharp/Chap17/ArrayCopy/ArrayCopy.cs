// ArrayCopy.cs

using System;

public class ArrayCopy
{
	public static int Main(string[] args)
	{
		int [] arr1 = {1, 4, 9};
		int [] arr2 = arr1;
		show(arr1, "first array");
		show(arr2, "second array");
		arr1[1] = 444;			// this will change BOTH arrays!
		show(arr1, "first array");
		show(arr2, "second array");
		return 0;
	}
	public static void show (int [] arr, string caption)
	{
		Console.WriteLine("----{0}----", caption);
		for (int i = 0; i < arr.Length; i++)
		{
			Console.Write("{0} ", arr[i]);
		}
		Console.WriteLine();
	}
}

