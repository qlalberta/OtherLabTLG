// Bank.cs

using System;

public class Bank
{
	public Bank()
	{
		BankAccounts = new AccountList();
		BankAccounts.Add(100, "Bob");
		BankAccounts.Add(200, "Mary");
		BankAccounts.Add(300, "Charlie");
	}
	public int AddAccount(decimal bal, string owner)
	{
		return BankAccounts.Add(bal, owner);
	}
	public string[] GetAccounts()
	{
		return BankAccounts.GetAccounts();
	}
	public void DeleteAccount(int id)
	{
		BankAccounts.Delete(id);
	}
	public Account FindAccount(int id)
	{
		return BankAccounts[id];
	}

	private AccountList BankAccounts;
}
