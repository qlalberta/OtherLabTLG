// PowerTwo.cs - Step 1

using System;

public class PowerTwo
{
	public static void Main()
	{
		long power = 1;
		for (int i = 0; i < 16; i++)
		{         
			// Negative value for left justification
			Console.WriteLine("{0,-3} {1,10}", i, power);
			power *= 2;
		}
	}
}