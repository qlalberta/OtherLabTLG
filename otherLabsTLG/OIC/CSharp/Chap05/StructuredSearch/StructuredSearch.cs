// StructuredSearch.cs

using System;

public class StructuredSearch
{
	public static int Main(string[] args)
   {
		int [] primes = {2, 3, 5, 7, 11, 13};
		foreach (int prime in primes)
			Console.Write("{0} ", prime);
		Console.WriteLine();
		int target = 7;
		int i = 0;
		bool found = false;
		while (!found && i < primes.Length)
		{
			if (target == primes[i])
				found = true;
			else
				i++;
		}
		if (found)
			Console.WriteLine("{0} found at {1}", target,i);
		else
			Console.WriteLine("{0} not found", target);
		return 0;
	}
}
