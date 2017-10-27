using System;

class AccountList
{
	public AccountList()
	{
		accounts = new Account[10];
	}
	// indexer for AccountsList, using id
	public Account this[int id]
	{
		get
		{
			int index = FindIndex(id);
			if (index == -1)
			{
				Console.WriteLine("No such account");
				return null;
			}
			return accounts[index];
		}
	}
	public int Add(decimal bal, string owner)
	{
		Account acc;
		int id = nextid++;
		acc = new Account(bal, owner, id);
		accounts[count++] = acc;
		return id;
	}
	public void Delete(int id)
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
	public Account Find(int id)
	{
		for (int i = 0; i < count; i++)
		{
			if (accounts[i].Id == id)
				return accounts[i];
		}
		return null;
	}
	public string[] GetAccounts()
	{
		string[] array = new string[count];
		for (int i = 0; i < count; i++)
		{
			string owner = accounts[i].Owner;
			string sid = accounts[i].Id.ToString();
			string sbal = accounts[i].Balance.ToString();
			string str = sid + "\t" + owner + "\t" + sbal;
			array[i] = str;
		}
		return array;
	}
	private Account[] accounts;
	private int nextid = 1;
	private int count = 0;
}
