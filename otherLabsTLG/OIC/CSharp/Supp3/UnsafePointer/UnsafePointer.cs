// UnsafePointer.cs

using System;

public class UnsafePointer
{
	public static unsafe void Main() 
	{
		int x = 55;
		int y = 777;
		Show("Before swap", x, y);
		Swap(ref x, ref y);
		Show("After swap", x, y);
		Swap(&x, &y);
		Show("After unsafe swap", x, y);
	}
	private static void Show(string s, int x, int y)
	{
		Console.WriteLine("{0}: x = {1}, y = {2}", s, x, y);
	}
	private static void Swap(ref int x, ref int y)
	{
		int temp = x;
		x = y;
		y = temp;
	}
	private static unsafe void Swap(int* px, int* py)
	{
		int temp = *px;
		*px = *py;
		*py = temp;
	}
}
