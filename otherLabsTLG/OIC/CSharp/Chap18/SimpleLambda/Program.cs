using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleLambda
{
	class Program
	{
		delegate int Calculate(int x);
		static void Show5(Calculate calc)
		{
			for (int i = 1; i <= 5; i++)
				Console.WriteLine("{0}   {1}", i, calc(i));
		}
		static void Main(string[] args)
		{
			// inferred type
			Show5(x => x * x);
			// explicit type
			Show5((int x) => x * x * x);
			// multiple statements
			Show5((int x) =>
			{
				if (x % 2 == 0)
					return x * x;
				else
					return x * x * x;
			});
		}
	}
}
