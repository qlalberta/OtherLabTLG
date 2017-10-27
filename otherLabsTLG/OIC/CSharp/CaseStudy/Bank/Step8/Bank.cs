// Bank.cs - Step 8

using System;
using System.Collections.Generic;

public enum AccountType
{
	Checking,
	Savings,
	Invalid
}

interface IBank
{
	int AddAccount(AccountType type, decimal bal, string owner);
	List<Account> GetAccounts();
	void DeleteAccount(int id);
	Account FindAccount(int id);
	List<string> GetStatements();
}

public class Bank
{
	private List<Account> accounts;
	private int nextid = 1;
	public Bank()
	{
		accounts = new List<Account>();
		AddAccount(AccountType.Checking, 100, "Bob");
		AddAccount(AccountType.Savings, 200, "Mary");
		AddAccount(AccountType.Checking, 300, "Charlie");
	}
	public int AddAccount(AccountType type, decimal bal, string owner)
	{
		Account acc;
		int id = nextid++;
		switch(type)
		{
			case AccountType.Checking:
				acc = new CheckingAccount(bal, owner, id);
				break;
			case AccountType.Savings:
				acc = new SavingsAccount(bal, owner, id);
				break;
			default:
				Console.WriteLine("Unexpected AccountType");
				return -1;
		}
		accounts.Add(acc);
		return id;
	}
	public List<Account> GetAccounts()
	{
		return accounts;
	}
	public void DeleteAccount(int id)
	{
		CheckingAccount acc = new CheckingAccount(0m, "", id);
		accounts.Remove(acc);
	}
	public Account FindAccount(int id)
	{
		foreach (Account acc in accounts)
		{
			if (acc.Id == id)
				return acc;
		}
		return null;
	}
	public List<string> GetStatements()
	{
		List<string> array = new List<string>(accounts.Count);
		foreach (Account acc in accounts)
		{
			acc.Post();
			string str = acc.GetStatement();
			acc.MonthEnd();
			array.Add(str);
			str = "------------------------------------------------";
			array.Add(str);
		}
		return array;
	}
}
