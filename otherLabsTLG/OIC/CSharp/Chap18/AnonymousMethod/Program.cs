using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousMethod
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
			Calculate dlgSquare = delegate(int x)
			{
				return x * x;
			};
			Show5(dlgSquare);
		}
	}
}
