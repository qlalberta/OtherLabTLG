// SimpleAccount.cs

public class SimpleAccount
{
	private decimal balance;
	public SimpleAccount()
	{
		this.balance = 0m;
	}
	public decimal Balance
	{
		get
		{
			return balance;
		}
		set
		{
			balance = value;
		}
	}
}
