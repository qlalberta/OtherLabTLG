// AccountList.cs - Step 1

using System;
using System.Collections;

public class AccountList
{
	private static ArrayList accounts;
	public static void Main()
	{
		// Initialize accounts and show starting state
		accounts = new ArrayList();
		Console.WriteLine("accounts.Count = {0}", accounts.Count);
		Console.WriteLine("accounts.Capacity = {0}", accounts.Capacity);
		AddAccount(100, "Bob", 1);
		AddAccount(200, "Mary", 2);
		AddAccount(300, "Charlie", 3);
		ShowAccounts(accounts);
		Console.WriteLine("accounts.Count = {0}", accounts.Count);
		Console.WriteLine("accounts.Capacity = {0}", accounts.Capacity);
		// Command processing loop
  		InputWrapper iw = new InputWrapper(); 
		string cmd;
		Console.WriteLine("Enter command, quit to exit");
		cmd = iw.getString("> ");
		while (! cmd.Equals("quit"))
		{
			try
			{
				if (cmd.Equals("show"))
					ShowAccounts(accounts);
				else if (cmd.Equals("enum"))
					ShowEnum(accounts);
				else if (cmd.Equals("remove"))
				{
					int id = iw.getInt("id: ");
					RemoveAccount(id);
				}
				else if (cmd.Equals("add"))
				{
					decimal balance = iw.getDecimal("balance: ");
					string owner = iw.getString("owner: ");
					int id = iw.getInt("id: ");
					AddAccount(balance, owner, id);
				}
				else
					help();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				if (e.InnerException != null)
				{
					Console.WriteLine(e.InnerException.Message);
				}
			}
			cmd = iw.getString("> ");
		}
	}
	private static void ShowAccounts(ArrayList array)
	{
		foreach (Account acc in array)
		{
			Console.WriteLine(acc.Info);
		}
	}
	private static void ShowEnum(ArrayList array)
	{
		IEnumerator iter = array.GetEnumerator();
		bool more = iter.MoveNext();
		while (more)
		{
			Account acc = (Account) iter.Current;
			Console.WriteLine(acc.Info);
			more = iter.MoveNext();
		}
	}
	private static void AddAccount(decimal bal, string owner, int id)
	{
		// low-level method that lets user specify the id
		Account acc = new Account(bal, owner, id);
		if (accounts.Contains(acc))
		{
			Console.WriteLine("Account with id {0}", id);
			Console.WriteLine("is already contained in the collection");
			return;
		}
		accounts.Add(acc);
	}
	private static void RemoveAccount(int id)
	{
		Account acc = new Account(0, "", id);
		accounts.Remove(acc);
	}
	private static void help()
	{
		Console.WriteLine("The following commands are available:");
		Console.WriteLine("\tshow     -- show all accounts");
		Console.WriteLine("\tenum     -- enumerate all accounts");
		Console.WriteLine("\tadd      -- add an account (specify id)");
		Console.WriteLine("\tremove   -- remove an account");
		Console.WriteLine("\tquit     -- exit the program");
	}
}