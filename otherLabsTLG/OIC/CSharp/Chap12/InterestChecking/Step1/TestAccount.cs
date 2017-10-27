// TestAccount.cs - Step 2

using System;

public class TestAccount
{
	public static void Main(string[] args)
	{
		CheckingAccount chk = new CheckingAccount(10000, "Charlie", 2);
		chk.Deposit(5000);
		chk.Withdraw(12000);
		ShowAccount("CheckingAccount", chk);
		chk.Post();
		Console.WriteLine("After posting, balance = {0}", chk.Balance);

		// Same starting balance, different transactins
		chk = new CheckingAccount(10000, "Charlie", 2);
		chk.Withdraw(500);
		chk.Withdraw(1000);
		chk.Withdraw(1500);
		ShowAccount("CheckingAccount", chk);
		chk.Post();
		Console.WriteLine("After posting, balance = {0}", chk.Balance);

		// Same transaction streams for savings account
		SavingsAccount sav = new SavingsAccount(10000, "David", 3);
		sav.Deposit(5000);
		sav.Withdraw(12000);
		ShowAccount("SavingsAccount", sav);
		sav.Post();
		Console.WriteLine("After posting, balance = {0}", sav.Balance);
		
		sav = new SavingsAccount(10000, "David", 3);
		sav.Withdraw(500);
		sav.Withdraw(1000);
		sav.Withdraw(1500);
		ShowAccount("SavingsAccount", sav);
		sav.Post();
		Console.WriteLine("After posting, balance = {0}", sav.Balance);

		// Same transaction streams for interest checking account
		InterestChecking ichk = new InterestChecking(10000, "Ellen", 4);
		ichk.Deposit(5000);
		ichk.Withdraw(12000);
		ShowAccount("InterestChecking", ichk);
		ichk.Post();
		Console.WriteLine("After posting, balance = {0}", ichk.Balance);

		ichk = new InterestChecking(10000, "Ellen", 4);
		ichk.Withdraw(500);
		ichk.Withdraw(1000);
		ichk.Withdraw(1500);
		ShowAccount("InterestChecking", ichk);
		ichk.Post();
		Console.WriteLine("After posting, balance = {0}", ichk.Balance);
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
	private static void ShowAccount(string caption, SavingsAccount acc)
	{
		Console.Write("{0}: ", caption);
		Console.WriteLine(acc.GetStatement());
	}
	private static void ShowAccount(string caption, InterestChecking acc)
	{
		Console.Write("{0}: ", caption);
		Console.WriteLine(acc.GetStatement());
	}
}