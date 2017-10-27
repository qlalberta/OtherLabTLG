// Account.cs - Step 5

using System;

abstract public class Account
{
   private int id;
   protected decimal balance;
	private string owner;
	protected int numXact = 0;	// number of transactions
	public Account(decimal balance, string owner, int id)
	{
		this.balance = balance;
		this.owner = owner;
		this.id = id;
	}
	virtual public void Deposit(decimal amount)
	{
		if (amount < 0.00m)
			throw new Exception("The transaction amount cannot be negative.");
		balance += amount;
		numXact++;
	}
	virtual public void Withdraw(decimal amount)
	{
		if (amount < 0.00m)
			throw new Exception("The transaction amount cannot be negative.");
		decimal newbal = balance - amount;
		if (newbal < 0.00m)
			throw new Exception("The balance cannot be negative.");
		balance = newbal;
	}
	public decimal Balance
	{
		get
		{
			return balance;
		}
	}
	public int Id
	{
		get
		{
			return id;
		}
	}
	public string Owner
	{
		get
		{
			return owner;
		}
		set
		{
			owner = value;
		}
	}
	public int Transactions
	{
		get
		{
			return numXact;
		}
	}
	public string FormatBalance()
	{
		return string.Format("{0:C}", balance);
	}
	virtual public string GetStatement()
	{
		string s = "Statement for " + Owner + " id = " + Id + "\n" +
			Transactions + " transactions, balance = " + FormatBalance();
		return s;
	}
	abstract public void Post();
	abstract public string Prompt {get;}
	virtual public void MonthEnd()
	{
		numXact = 0;
	}
}