// Account.cs

using System;

public class Account
{
	protected decimal balance;
	public Account(decimal balance)
	{
		this.balance = balance;
	}
	public void Deposit(decimal amount)
	{
		if (amount < 0.00m)
			throw new Exception("The transaction amount cannot be negative.");
		balance += amount;
	}
	public void Withdraw(decimal amount)
	{
		if (amount < 0.00m)
			throw new Exception("The transaction amount cannot be negative.");
		decimal newbal = balance - amount;
		if (newbal < 0.00m)
			throw new BalanceException("The balance cannot be negative.", -newbal);
		balance = newbal;
	}
	public decimal Balance
	{
		get
		{
			return balance;
		}
	}
}