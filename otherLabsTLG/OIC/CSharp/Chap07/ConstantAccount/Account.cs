// Account.cs

public class Account
{
 	public  const decimal FEE = 5.00m;
	public readonly int FreeChecks;
    public Account()
    {

    }
	public Account(int num)
	{
		FreeChecks = num;
	}
}