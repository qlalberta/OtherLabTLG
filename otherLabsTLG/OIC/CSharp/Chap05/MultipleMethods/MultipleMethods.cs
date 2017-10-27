// MultipleMethods.cs

using System;

public class MultipleMethods
{
	public static void Main()
	{
		InputWrapper iw = new InputWrapper();
		// initialize and display array
		int[] primes = {2, 3, 5, 7, 11, 13};
		for (int i = 0; i < primes.Length; i++)
			Console.Write("{0} ", primes[i]);
		Console.WriteLine();
		// loop to read and search for targets
		Console.WriteLine("Enter numbers to search for, -1 when done");
		int target = iw.getInt("target number: ");
		while (target != -1)
		{
			int index = Search(primes, target);
			if (index == -1)
				Console.WriteLine("{0} not found", target);
			else
				Console.WriteLine("{0} found at {1}", target,index);
			target = iw.getInt("target number: ");
		}
	}

	public static int Search(int[] array, int target)
	{
		int i = 0;
		bool found = false;
		while (!found && i < array.Length)
		{
			if (target == array[i])
				found = true;
			else
				i++;
		}
		if (found)
			return i;
		else
			return -1;
	}
}