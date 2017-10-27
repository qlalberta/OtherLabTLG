// GotoSearch.cs

using System;

public class GotoSearch
{
	public static int Main(string[] args)
   {
		int [] primes = {2, 3, 5, 7, 11, 13};
		foreach (int prime in primes)
			Console.Write("{0} ", prime);
		Console.WriteLine();
		int target = 7;
		int i;
		for(i = 0; i < primes.Length; i++)
		{
			if (target == primes[i])
				goto found;
		}
		Console.WriteLine("{0} not found", target);
		return 0;
	found:
		Console.WriteLine("{0} found at {1}", target,i);
		return 0;
	}
}
