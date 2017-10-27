// TestVirtualAccount.cs
using System;
public class TestAccount
{
	public static void Main(string[] args)
	{
		Account acc = new Account(); 
 		CheckingAccount chk = new CheckingAccount();
		acc.Show();
		chk.Show();
		acc = chk;				
		acc.Show();			// now CheckingAccount.Show
        Console.WriteLine(acc.fee);
	}
}