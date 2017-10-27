// TestAccount.cs

using System;

public class TestAccount
{
	public static void Main(string[] args)
	{
		Account acc;  		
		acc = new Account(100, "Amy", 1);
		ShowAccount("Account", acc);
		acc = new Account(200, "Bob");
		ShowAccount("Account", acc);
		acc = new Account(300);
		ShowAccount("Account", acc);
		acc = new Account();
		ShowAccount("Account", acc);
	}
	private static void ShowAccount(string caption, Account acc)
	{
		Console.Write("{0}: ", caption);
		Console.WriteLine(acc.GetStatement());
	}
}