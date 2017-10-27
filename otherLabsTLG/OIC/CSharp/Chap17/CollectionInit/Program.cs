using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionInit
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> primes = new List<int> { 2, 3, 5, 7, 11 };
			ShowList(primes);
			List<Account> accs = new List<Account>
			{
				new Account {AccountId = 101, Balance = 150m},
				new Account {AccountId = 201, Balance = 250m},
				new Account {AccountId = 301, Balance = 350m},
			};
			ShowList(accs);
		}
		static void ShowList<T>(List<T> info)
		{
			foreach (T x in info)
				Console.WriteLine(x);
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
}
