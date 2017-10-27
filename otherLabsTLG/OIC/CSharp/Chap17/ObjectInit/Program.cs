using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectInit
{
	class Program
	{
		static void Main(string[] args)
		{
			Account acc = new Account { AccountId = 101, Balance = 150m };
			Console.WriteLine(acc);
		}
	}
	class Account
	{
		public int AccountId { get; set; }
		public decimal Balance { get; set; }
		public override string ToString()
		{
			return string.Format("Id: {0}, Balance: {1:C}",
				AccountId, Balance);
		}
	}
}
