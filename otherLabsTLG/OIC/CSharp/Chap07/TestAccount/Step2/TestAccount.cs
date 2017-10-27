// TestAccount.cs - Step2

using System;

public class TestAccount
{
	public static void Main(string[] args)
	{
		Account acc;  		
		acc = new Account();		
		//acc.Id = 1;
		//acc.Balance = 100;		
		//Account acc2 = new Account();
		//acc2.Id = 2;
		//acc2.Balance = 200;
		Console.WriteLine("acc  id {0} has balance {1}", acc.Id, acc.Balance);
		//Console.WriteLine("acc2 id {0} has balance {1}", acc2.Id, acc2.Balance);
		//acc2 = acc;
		//Console.WriteLine("-----After acc2 = acc-----");
		//Console.WriteLine("acc  id {0} has balance {1}", acc.Id, acc.Balance);
		//Console.WriteLine("acc2 id {0} has balance {1}", acc2.Id, acc2.Balance);
		//acc.Balance = 150;
		//Console.WriteLine("-----After acc.Balance = 150-----");
		//Console.WriteLine("acc  id {0} has balance {1}", acc.Id, acc.Balance);
		//Console.WriteLine("acc2 id {0} has balance {1}", acc2.Id, acc2.Balance);
	}
}