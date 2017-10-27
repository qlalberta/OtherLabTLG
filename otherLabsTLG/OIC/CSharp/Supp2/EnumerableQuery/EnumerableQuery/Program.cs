using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumerableQuery
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
			ShowArray(primes);
			IEnumerable<int> query =
				from num in primes
				where num < 10
				select num;
			ShowArray(query.ToArray<int>());
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
