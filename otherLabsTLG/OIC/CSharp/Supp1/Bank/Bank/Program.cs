using System;

namespace Bank
{
	class Program
	{
		static void Main(string[] args)
		{
			Account acc = new Account(100);
			Console.WriteLine("balance = {0}", acc.Balance);
			acc.Deposit(25);
			Console.WriteLine("balance = {0}", acc.Balance);
			acc.Withdraw(50);
			Console.WriteLine("balance = {0}", acc.Balance);
			Console.WriteLine("press Enter to exit");
			Console.ReadLine();
		}
	}
}
