// StaticAccount.cs

using System;

public class StaticAccount
{
	public static void Main(string[] args)
	{
		Console.WriteLine("nextid = {0}", Account.GetNextId());
		Account acc1, acc2, acc3;  		
		acc1 = new Account(100);
		acc1.Deposit(25);
		acc2 = new Account(200);
		acc3 = new Account();
		WriteAccount(acc1);
		WriteAccount(acc2);
		WriteAccount(acc3);
        //Console.WriteLine("nextid = {0}", Account.GetNextId());
        Console.WriteLine("nextid = {0}", acc3.GetNextId());    // illegal
    }
	private static void WriteAccount(Account acc)
	{
		Console.WriteLine("balance of {0} is {1}", acc.GetId(), acc.GetBalance());	
	}
}