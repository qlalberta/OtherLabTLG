// TestBank.cs - Step 3

using System;

public class TestBank
{
	public static void Main()
	{
		Bank bank = new Bank();
  		InputWrapper iw = new InputWrapper(); 
		string cmd;
		Console.WriteLine("Enter command, quit to exit");
		cmd = iw.getString("> ");
		while (! cmd.Equals("quit"))
		{
			if (cmd.Equals("open"))
			{
				AccountType type;
				string stype = iw.getString("account type: ");
				switch(stype)
				{
					case "checking":
						type = AccountType.Checking;
						break;
					case "savings":
						type = AccountType.Savings;
						break;
					default:
						type = AccountType.Invalid;
						break;
				}
				if (type == AccountType.Invalid)
				{
					Console.WriteLine("Valid account types are checking/savings");
					continue;
				}
				decimal bal = iw.getDecimal("starting balance: ");
				string owner = iw.getString("owner: ");
				int id = bank.AddAccount(type, bal, owner);
				Console.WriteLine("Account opened, id = {0}", id);
			}
			else if (cmd.Equals("close"))
			{
				int id = iw.getInt("account id: ");
				bank.DeleteAccount(id);
			}
			else if (cmd.Equals("show"))
				ShowArray(bank.GetAccounts());
			else if (cmd.Equals("account"))
			{
				int id = iw.getInt("account id: ");
				Account acc = bank.FindAccount(id);
				Atm.ProcessAccount(acc);
			}
			else
				help();
			cmd = iw.getString("> ");
		}
	}
	private static void ShowArray(string[] array)
	{
		foreach (string str in array)
			Console.WriteLine(str);
	}
	private static void help()
	{
		Console.WriteLine("The following commands are available:");
		Console.WriteLine("\topen     -- open an account");
		Console.WriteLine("\tclose    -- close an account");
		Console.WriteLine("\tshow     -- show all accounts");
		Console.WriteLine("\taccount  -- perform transactions on an account");
		Console.WriteLine("\tquit     -- exit the program");
	}
}