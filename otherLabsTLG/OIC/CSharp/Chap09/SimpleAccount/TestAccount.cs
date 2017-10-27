// TestAccount.cs

using System;

public class TestAccount
{
	public static void Main(string[] args)
	{
		// Compare property and method notation
		// using SimpleAccount class
		SimpleAccount acc = new SimpleAccount();
		decimal bal;
		bal = acc.Balance;
		// bal = acc.GetBalance();
		acc.Balance = 100m;
		acc.Balance += 1m;
		// acc.SetBalance(acc.GetBalance() + 1m);
		ShowAccount(acc);
	}
	private static void ShowAccount(SimpleAccount acc)
	{
		Console.WriteLine("balance: {0:C}", acc.Balance);
	}
}