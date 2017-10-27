// Account.cs

public class Account
{
	private int balance;
	public Account(int balance)
	{
		this.balance = balance;
	}
	public void Deposit(int amount)
	{
		balance += amount;
	}
	public void Withdraw(int amount)
	{
		balance -= amount;
	}
	public int Balance
	{
		get
		{
			return balance;
		}
	}
}
