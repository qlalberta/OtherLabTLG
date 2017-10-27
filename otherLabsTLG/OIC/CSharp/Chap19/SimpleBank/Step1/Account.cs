using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBank
{
	class Account
	{
		private string m_owner;
		private decimal m_balance;
		public Account(string owner, decimal balance)
		{
			m_owner = owner;
			m_balance = balance;
		}
		public override string ToString()
		{
			return m_owner;
		}
		public decimal Balance
		{
			get
			{
				return m_balance;
			}
		}
	}
}
