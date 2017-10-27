// Bank.cs - Step 3

using System;

public enum AccountType
{
	Checking,
	Savings,
	Invalid
}

public class Bank
{
	private Account[] accounts;
	private int nextid = 1;
	private int count = 0;
	public Bank()
	{
		accounts = new Account[10];
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
		accounts[count++] = acc;
		return id;
	}
	public string[] GetAccounts()
	{
		string[] array = new string[count];
		for (int i = 0; i < count; i++)
		{
			string owner = accounts[i].Owner;
			string stype = accounts[i].Prompt;
			string sid = accounts[i].Id.ToString();
			string sbal = accounts[i].Balance.ToString();
			string str = sid + "\t" + stype + owner + "\t" + sbal;
			array[i] = str;
		}
		return array;
	}
	public void DeleteAccount(int id)
	{
		int index = FindIndex(id);
		if (index != -1)
		{
			// move accounts down
			for (int i = index; i < count; i++)
			{
				accounts[i] = accounts[i+1];
			}
			count--;
		}
	}
	private int FindIndex(int id)
	{
		for (int i = 0; i < count; i++)
		{
			if (accounts[i].Id == id)
				return i;
		}
		return -1;
	}
	public Account FindAccount(int id)
	{
		for (int i = 0; i < count; i++)
		{
			if (accounts[i].Id == id)
				return accounts[i];
		}
		return null;
	}
}
