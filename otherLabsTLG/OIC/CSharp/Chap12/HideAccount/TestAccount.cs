// TestAccount.cs

using System;

public class TestAccount
{
	public static void Main(string[] args)
	{
		Account acc = new Account();  
		Console.WriteLine("balance = {0}", acc.Balance);
		acc.Deposit(100);
		acc.Withdraw(25);
		Console.WriteLine("balance = {0}", acc.Balance);
		CheckingAccount chk = new CheckingAccount();
		Console.WriteLine("balance = {0}", chk.Balance);
		chk.Deposit(200);
		chk.Withdraw(25);
		Console.WriteLine("balance = {0}", chk.Balance);
		chk.Post();
		Console.WriteLine("balance = {0}", chk.Balance);
	}
}