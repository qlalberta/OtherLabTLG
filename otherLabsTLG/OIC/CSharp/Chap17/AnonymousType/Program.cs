using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousType
{
	class Program
	{
		static void Main(string[] args)
		{
			// named type
			Account acc = new Account { AccountId = 101, Balance = 150m };
			ShowTypeInfo(acc);

			// anonymous type
			var acc2 = new { AccountId = 201, Balance = 250m };
			ShowTypeInfo(acc2);
			//acc2.Balance += 100m; 
			//property is read-only
		}
		static void ShowTypeInfo(object obj)
		{
			Console.WriteLine(obj);
			Console.WriteLine("Type = {0}", obj.GetType().Name);
			Console.WriteLine("Base class = {0}", obj.GetType().BaseType);
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
