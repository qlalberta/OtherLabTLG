// TestPolyAccount.cs

using System;

public class TestAccount
{
	public static void Main(string[] args)
	{
		Account acc;  		
		acc = new Account(100, "Bob", 1);
		ShowAccount("Account", acc);
		acc.Deposit(25);
		acc.Deposit(25);
		acc.Withdraw(50);
		ShowAccount("Account", acc);
		acc = new CheckingAccount(200, "Charlie", 2);
		ShowAccount("CheckingAccount", acc);
		acc.Deposit(25);
		acc.Deposit(25);
		acc.Withdraw(100);
		ShowAccount("CheckingAccount", acc);
		acc.Post();
		Console.WriteLine("After posting, balance = {0}", acc.Balance);
		acc = new SavingsAccount(300, "David", 3);
		ShowAccount("SavingsAccount", acc);
		acc.Deposit(25);
		acc.Deposit(25);
		acc.Withdraw(100);
		ShowAccount("SavingsAccount", acc);
		acc.Post();
		Console.WriteLine("After posting, balance = {0}", acc.Balance);
	}
	private static void ShowAccount(string caption, Account acc)
	{
		Console.Write("{0}: ", caption);
		Console.WriteLine(acc.GetStatement());
	}
}