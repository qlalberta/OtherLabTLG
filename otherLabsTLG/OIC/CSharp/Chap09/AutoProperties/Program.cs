using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoProperties
{
	class Program
	{
		static void Main(string[] args)
		{
			Account acc = new Account(101, 150m);
			acc.Show();
			acc.Balance += 100m;
			acc.Show();
			// acc.AccountId = 201;
			// Illegal because AccountId is read-only
		}
	}
	class Account
	{
		public int AccountId { get; private set; }	// read-only
		public decimal Balance { get; set; }
		public Account(int accId, decimal bal)
		{
			AccountId = accId;
			Balance = bal;
		}
		public void Show()
		{
			Console.WriteLine("Id: {0}, Balance: {1:C}",
				AccountId, Balance);
		}
	}
}
