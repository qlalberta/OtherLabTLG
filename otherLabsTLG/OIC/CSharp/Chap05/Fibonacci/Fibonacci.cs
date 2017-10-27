// Fibonacci.cs

using System;

public class Fibonacci
{
	public static int Main(string[] args)
   {
		double [] fib;
		fib = new double[10];
		fib[0] = fib[1] = 1;
		for (int i = 2; i < 10; i++)
			fib[i] = fib[i-1] + fib[i-2];

		for (int i = 0; i < 10; i++)
			Console.Write("{0} ", fib[i]);
		Console.WriteLine();

		for (int i = 9; i >= 0 ; i--)
			Console.Write("{0} ", fib[i]);
		Console.WriteLine();
		return 0;
	}
}
