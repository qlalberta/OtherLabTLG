// PolySavingsAccount.cs

using System;

public class SavingsAccount : Account
{
	private decimal minBalance;
	private decimal rate = 0.06m;
	public SavingsAccount(decimal balance, string owner, int id)
		: base(balance, owner, id)
	{
		minBalance = balance;
	}
	public decimal Interest
	{
		get
		{
			return minBalance * rate/12;
		}
	}
	override public void Withdraw(decimal amount)
	{
		base.Withdraw(amount);
		if (balance < minBalance)
		{
			minBalance = balance;
		}
	}
	override public void Post()
	{
		balance += Interest;
		numXact = 0;
		minBalance = balance;
	}
	override public string GetStatement()
	{
		string s = base.GetStatement();
		s += ", interest = " + Interest;
		return s;
	}
	public decimal Rate
	{
		get
		{
			return rate;
		}
		set
		{
			rate = value;
		}
	}
	override public string Prompt
	{
		get
		{
			return "S: ";
		}
	}
}
