// Account.cs

using System;

public class Account
{
   private int id;
   private decimal balance;
	private string owner;
	private int numXact;	// number of transactions
	public Account(decimal balance, string owner, int id)
		: this(balance, owner)
	{
		Console.WriteLine("Account(decimal, string, int)");
		this.id = id;
	}
	public Account(decimal balance, string owner)
		: this(balance)
	{
		Console.WriteLine("Account(decimal, string)");
		this.owner = owner;
	}
	public Account (decimal balance)
	{
		Console.WriteLine("Account(decimal)");
		this.balance = balance;
	}
	public Account()
	{
	}
	public string GetStatement()
	{
		string s = "owner = " + owner + ", id = " + id + 
			 ", transactions = " + numXact +", balance = " + balance;
		return s;
	}
}