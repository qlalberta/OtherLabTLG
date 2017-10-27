// CheckingAccount.cs

public class CheckingAccount : Account
{
	private const decimal FEE = .25m;
	private int numXact = 0;	// number of transactions
	new public void Deposit(decimal amount)
	{
		base.Deposit(amount);
		numXact++;
	}
	new public void Withdraw(decimal amount)
	{
		base.Withdraw(amount);
		numXact++;
	}
	public void Post()
	{
		balance -= FEE * numXact;
		numXact = 0;
	}
}
