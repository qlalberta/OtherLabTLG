// OverloadDemo.cs

using System;

public class OverloadDemo
{
	public static void Main()
	{
		int x1 = 5, x2 = 7;
		long y1 = 5000000000L, y2 = 7000000000L;
		string s1 = "fifteen", s2 = "seven";
		Console.WriteLine("max of {0}, {1} = {2}", x1, x2, FindMax(x1,x2));
		Console.WriteLine("max of {0}, {1} = {2}", y1, y2, FindMax(y1,y2));
		Console.WriteLine("max of {0}, {1} = {2}", s1, s2, FindMax(s1,s2));
	}
	static long FindMax(long a, long b)
	{
		return a < b ? b : a;
	}
	static string FindMax(string a, string b)
	{
		return String.Compare(a,b) <= 0 ? b : a;
	}
}