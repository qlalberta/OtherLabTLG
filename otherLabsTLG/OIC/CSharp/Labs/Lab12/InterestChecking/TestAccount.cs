// TestAccount.cs - Step 2

using System;

public class TestAccount
{
	public static void Main(string[] args)
	{
		Account acc;  		
		acc = new Account(10000, "Bob", 1);
		ShowAccount("Account", acc);
        acc.Deposit(5000);
		//acc.Deposit(25);
		acc.Withdraw(12000);
		ShowAccount("Account", acc);
		CheckingAccount chk = new CheckingAccount(10000, "Charlie", 2);
        InterestCheckingAccount intCheck = new InterestCheckingAccount(5000,);
		ShowAccount("CheckingAccount", chk);
		//chk.Deposit(25);
		chk.Deposit(5000);
		chk.Withdraw(12000);
        chk.Withdraw(500);
        chk.Withdraw(1000);
        chk.Withdraw(1500);
        ShowAccount("CheckingAccount", chk);
		chk.Post();
		Console.WriteLine("After posting, balance = {0}", chk.Balance);
        Console.WriteLine("After posting, fee = {0}", chk.Balance);

        //SavingsAccount sav = new SavingsAccount(300, "David", 3);
        //ShowAccount("SavingsAccount", sav);
        //sav.Deposit(25);
        //sav.Deposit(25);
        //sav.Withdraw(100);
        //ShowAccount("SavingsAccount", sav);
        //sav.Post();
        //Console.WriteLine("After posting, balance = {0}", sav.Balance);
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
    private static void ShowAccount(string caption, InterestCheckingAccount acc)
    {
        Console.Write("{0}: ", caption);
        Console.WriteLine(acc.GetStatement());
    }

}