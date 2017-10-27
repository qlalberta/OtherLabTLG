// Account.cs

public class Account
{
   protected decimal balance;
	public void Deposit(decimal amount)
	{
		balance += amount;
	}
	public void Withdraw(decimal amount)
	{
		balance -= amount;
	}
	public decimal Balance
	{
		get
		{
			return balance;
		}
	}
}