// Account.cs

using System;

public class Account
{
   private int id;
   private decimal balance;
	private string owner;
	private int numXact;	// number of transactions
	public string GetStatement()
	{
		string s = "owner = " + owner + ", id = " + id + 
			 ", transactions = " + numXact +", balance = " + balance;
		return s;
	}
}