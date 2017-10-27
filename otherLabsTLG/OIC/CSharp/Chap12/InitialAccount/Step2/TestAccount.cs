// TestAccount.cs

using System;

public class TestAccount
{
	public static void Main(string[] args)
	{
		Account acc;  		
		acc = new Account(100, "Amy", 1);
		ShowAccount("Account", acc);
		CheckingAccount chk; 
		chk = new CheckingAccount(400, "David", 4);
		ShowAccount("CheckingAccount", chk);
	}
	private static void ShowAccount(string caption, Account acc)
	{
		Console.Write("{0}: ", caption);
		Console.WriteLine(acc.GetStatement());
	}
	private static void ShowAccount(string caption, CheckingAccount acc)
	{
		Console.Write("{0}: ", caption);
		Console.WriteLine(acc.GetStatement());
	}
}