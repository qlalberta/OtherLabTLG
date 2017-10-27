using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleQuery
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
			ShowArray(primes);
			var query =
				from num in primes
				where num < 10
				select num;
			//ShowArray(query);
			foreach (int x in query)
			{
				Console.Write("{0} ", x);
			}
			Console.WriteLine();
		}
		static void ShowArray(int[] arr)
		{
			foreach (int x in arr)
			{
				Console.Write("{0} ", x);
			}
			Console.WriteLine();
		}
	}
}
