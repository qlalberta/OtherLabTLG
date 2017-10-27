// CheckingAccount.cs

public class CheckingAccount : Account
{
	private decimal fee = 5.00m;
	public void Post()
	{
		balance -= fee;
	}
}
