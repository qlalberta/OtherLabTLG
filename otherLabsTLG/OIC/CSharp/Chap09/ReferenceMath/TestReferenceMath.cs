// TestReferenceMath.cs

using System;

public class TestReferenceMath
{
	public static void Main(string[] args)
	{
		int sum = 0, product = 0;
		ReferenceMath.Calculate(5, 7, ref sum, ref product);
		Console.WriteLine("sum = {0}", sum);
		Console.WriteLine("product = {0}", product);
	}
}
