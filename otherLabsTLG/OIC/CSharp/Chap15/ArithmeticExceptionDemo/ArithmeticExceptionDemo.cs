// ArithmeticExceptionDemo.cs
//
// This program demonstrates exceptions
// It handles exceptions within the CheckedMultiply method
// A more meaningful error message is written
//
// You can experiment with the different exceptions by commenting
// and uncommenting different statements in the main program

using System;

public class ArithmeticExceptionDemo
{
	private static long LongMultiply(object a, object b)
	{
		long product = (long) a * (long) b;
		return product;
	}
	private static int Multiply(object a, object b)
	{
		int product = (int) a * (int) b;
		return product;
	}
	private static int CheckedMultiply(object a, object b)
	{
		int first, second;
		try
		{
			first = (int) a;
		}
		catch (InvalidCastException e)
		{
			throw new Exception("First operand is not an int", e);
		}
		try
		{
			second = (int) a;
		}
		catch (InvalidCastException e)
		{
			throw new Exception("Second operand is not an int", e);
		}
		try
		{
			int product = checked(first * second);
			return product;
		}
		catch (OverflowException e)
		{
			throw new Exception("Integer overflow", e);
		}
	}
	public static int Main(string[] args)
	{
		int prod;
		long lprod;
		try
		{
			lprod = LongMultiply(56666L, 57777L);
			Console.WriteLine("product = {0}", lprod);
			prod = Multiply(56666, 57777);
			Console.WriteLine("product = {0}", prod);
			//Console.WriteLine("Operands: 56666, 57777");
			//prod = CheckedMultiply(56666, 57777);
			//Console.WriteLine("product = {0}", prod);
			Console.WriteLine("Operands: 56666L, 57777");
			prod = CheckedMultiply(56666L, 57777);
			Console.WriteLine("product = {0}", prod);
			//Console.WriteLine("Operands: 56666L, 57777");
			//prod = CheckedMultiply(56666, 57777L);
			//Console.WriteLine("product = {0}", prod);
		}
 		catch (Exception e)
		{
			Console.WriteLine("Exception: {0}", e.Message);
			if (e.InnerException != null)
				Console.WriteLine("Inner Exception: {0}", e.InnerException.Message);
		}
		return 0;
   }
}
