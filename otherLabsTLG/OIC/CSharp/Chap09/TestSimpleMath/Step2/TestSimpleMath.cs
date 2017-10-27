// TestSimpleMath.cs

using System;

public class TestSimpleMath
{
	public static void Main(string[] args)
	{
		int sum = SimpleMath.Add(5, 7);
		int product = SimpleMath.Multiply(5, 7);
		int div = SimpleMath.Divide(5, 7);
		int difference = SimpleMath.Subtract(5, 7);
		Console.WriteLine("sum = {0}", sum);
		Console.WriteLine("product = {0}", product);
		Console.WriteLine("div = {0}", div);
		Console.WriteLine("difference = {0}", difference);
		double dsum = SimpleMath.Add(5.0, 7.0);
		double dproduct = SimpleMath.Multiply(5.0, 7.0);
		double ddiv = SimpleMath.Divide(5.0, 7.0);
		double ddifference = SimpleMath.Subtract(5.0, 7.0);
		Console.WriteLine("dsum = {0}", dsum);
		Console.WriteLine("dproduct = {0}", dproduct);
		Console.WriteLine("ddiv = {0}", ddiv);
		Console.WriteLine("ddifference = {0}", ddifference);
	}
}
