// TestAccount.cs

using System;

public class TestAccount
{
	public static void Main(string[] args)
	{
		Account acc;  		
		acc = new Account(100, "Bob");
		ShowAccount(acc);
		acc.Deposit(25);
		acc.Withdraw(50);
		ShowAccount(acc);
		acc.Owner = "Carl";
		ShowAccount(acc);
		acc = new Account(200, "Mary");
		ShowAccount(acc);
	}
	private static void ShowAccount(Account acc)
	{
		Console.WriteLine("id: {0} owner: {1} balance: {2:C}", 
								acc.Id, acc.Owner, acc.Balance);
	}
}