// MoneyPower.cs

using System;

public class MoneyPower
{
	public static void Main()
	{
		decimal power = .01m;
		decimal total = 0m;
		for (int i = 1; i <= 64; i++)
		{
			total += power;
			//Console.WriteLine("{0,-3} {1,5:E26}", i, total);
            Console.WriteLine($"i = {0,-3}, total = {1,5:E26}");
            power *= 2;
		}
	}
}