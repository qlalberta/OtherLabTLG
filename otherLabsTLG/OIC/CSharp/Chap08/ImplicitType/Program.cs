using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplicitType
{
	class Program
	{
		static void Main(string[] args)
		{
			var num = 55;
			ShowTypeInfo(num);
			ShowObject(num);

			var word = "Hello!";
			ShowObject(word);
			ShowTypeInfo(word);

			var primes = new[] { 2, 3, 5, 7, 11 };
			ShowArray(primes);
			ShowTypeInfo(primes);

			var words = new [] {"one", "two", "three"};
			ShowArray(words);
			ShowTypeInfo(words);
		}
		static void ShowTypeInfo(object obj)
		{
			Console.WriteLine("Type = {0}", obj.GetType().Name);
			Console.WriteLine("Base class = {0}", obj.GetType().BaseType);
		}
		static void ShowObject(object obj)
		{
			Console.WriteLine(obj);
		}
		static void ShowArray(System.Array arr)
		{
			foreach (var x in arr)
				Console.Write("{0} ", x);
			Console.WriteLine();
		}
	}
}
