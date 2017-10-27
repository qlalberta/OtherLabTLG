// Ambiguous.cs

using System;

public class Ambiguous
{
	public static void Main()
	{
		Account acc = new Account(100);
		// acc.Show();	// illegal - MUST go through an interface
		IAccount iacc = (IAccount) acc;
		IStatement istat = (IStatement) acc;
		iacc.Show();
		istat.Show();
		iacc.Deposit(25);
		iacc.Withdraw(10);
		iacc.Show();
		istat.Show();
	}
}