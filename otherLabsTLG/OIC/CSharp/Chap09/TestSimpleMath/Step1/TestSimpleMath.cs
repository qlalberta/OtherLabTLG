// TestSimpleMath.cs

using System;

public class TestSimpleMath
{
	public static void Main(string[] args)
	{
		int sum = SimpleMath.Add(5, 7);
		int product = SimpleMath.Multiply(5, 7);
        //int difference = SimpleMath.Subtraction(5, 7);
        //int ratio = SimpleMath.Division(15, 5);
		Console.WriteLine("sum = {0}", sum);
		Console.WriteLine("product = {0}", product);
        //Console.WriteLine("difference = {0}", difference);
        //Console.WriteLine("ratio = {0}", ratio);
        //Console.ReadLine();
	}
}
