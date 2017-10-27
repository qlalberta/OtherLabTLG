// PowerTwo.cs - Step 0

using System;

public class PowerTwo
{
	public static void Main()
	{
		long power = 1;
		for (int i = 0; i < 16; i++)
		{
			Console.WriteLine("{0} {1}", i, power);
			power *= 2;
		}
	}
}