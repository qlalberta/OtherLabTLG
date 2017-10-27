// InitialAccount.cs

using System;

public class InitialAccount
{
	public static void Main(string[] args)
	{
		Account acc1 = new Account(1, 100);		
		Console.WriteLine("balance of {0} is {1}", acc1.GetId(), acc1.GetBalance());
		Account acc2 = new Account(2, 200);
		Console.WriteLine("balance of {0} is {1}", acc2.GetId(), acc2.GetBalance());
	}
}