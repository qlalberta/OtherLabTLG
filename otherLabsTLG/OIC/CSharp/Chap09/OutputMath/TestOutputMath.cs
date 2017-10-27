// TestOutputMath.cs

using System;

public class TestOutputMath
{
	public static void Main(string[] args)
	{
		int sum, product;
		OutputMath.Calculate(5, 7, out sum, out product);
		Console.WriteLine("sum = {0}", sum);
		Console.WriteLine("product = {0}", product);
	}
}
