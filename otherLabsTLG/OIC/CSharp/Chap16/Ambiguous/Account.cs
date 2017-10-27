// Account.cs (project "Ambiguous")

using System;

interface IAccount
{
	void Deposit(decimal amount);
	void Withdraw(decimal amount);
	decimal Balance {get;}
	void Show();
}

interface IStatement
{
	int Transactions {get;}
	void Show();
}

public class Account : IAccount, IStatement
{
	private decimal balance;
	int numXact = 0;
	public Account(decimal balance) 
	{
		this.balance = balance;
	}
	public void Deposit(decimal amount)
	{
		balance += amount;
		++numXact;
	}
	public void Withdraw(decimal amount)
	{
		balance -= amount;
		++numXact;
	}
	public decimal Balance
	{
		get
		{
			return balance;
		}
	}
	void IAccount.Show()
	{
		Console.WriteLine("balance = {0}", balance);
	}
	public int Transactions
	{
		get
		{
			return numXact;
		}
	}
	void IStatement.Show()
	{
		Console.WriteLine("{0} transactions, balance = {1}", numXact, balance);
	}
}