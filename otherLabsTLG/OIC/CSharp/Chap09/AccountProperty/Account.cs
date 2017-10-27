// Account.cs

public class Account
{
	private int id;
	private static int nextid = 1;
	private decimal balance;
	private string owner;
	public Account(decimal balance, string owner)
	{
		this.id = nextid++;
		this.balance = balance;
		this.owner = owner;
	}
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
}