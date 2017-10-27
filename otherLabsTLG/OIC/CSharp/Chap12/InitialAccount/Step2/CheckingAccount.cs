// CheckingAccount.cs

using System;

public class CheckingAccount : Account
{
	private const decimal FEE = 5.00m;
	public CheckingAccount(decimal balance, string owner, int id)
		: base(balance, owner, id)
	{
	}
	new public string GetStatement()
	{
		string s = base.GetStatement();
		s += ", fee = " + FEE;
		return s;
	}
}
