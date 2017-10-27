// InterestChecking.cs

using System;

public class InterestChecking : CheckingAccount
{
	private decimal minBalance;
	private decimal rate = 0.012m;
	public InterestChecking(decimal balance, string owner, int id)
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
	new public void Withdraw(decimal amount)
	{
		base.Withdraw(amount);
		if (balance < minBalance)
		{
			minBalance = balance;
		}
	}
	new public decimal Fee
	{
		get
		{
			if (minBalance < 5000m)
				return base.Fee + 10m;
			else
				return base.Fee;
		}
    }

	new public void Post()
	{
		balance += Interest;
		balance -= Fee;
		numXact = 0;
		minBalance = balance;
	}
	override public string GetStatement()
	{
		string s = "Statement for " + this.Owner + " id = " + Id + "\n" +
			this.Transactions + " transactions, balance = " + balance;
		s += ", fee = " + Fee;
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
}
