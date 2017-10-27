// TestStaticAccount.cs

using System;

public class TestAccount
{
	public static void Main(string[] args)
	{
		Account acc = new Account(); 
 		CheckingAccount chk = new CheckingAccount();
		acc.Show();
		chk.Show();
		//chk = acc;		// illegal
		acc = chk;				
		acc.Show();			// still Account.Show
	}
}