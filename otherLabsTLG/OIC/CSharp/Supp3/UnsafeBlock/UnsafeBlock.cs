// UnsafeBlock.cs

using System;

struct Account
{
	private int id;
	private decimal balance;
}

public class UnsafeBlock
{
	public static void Main() 
	{
		unsafe
		{
			Console.WriteLine("size of int = {0}", sizeof(int));
			Console.WriteLine("size of decimal = {0}", sizeof(decimal));
			Console.WriteLine("size of Account = {0}", sizeof(Account));
		}
	}
}
