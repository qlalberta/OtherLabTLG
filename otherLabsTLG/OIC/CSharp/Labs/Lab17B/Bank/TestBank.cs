// TestBank.cs - Step 7

using System;
using System.Collections;

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
			try
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
					ShowAccounts(bank.GetAccounts());
				else if (cmd.Equals("account"))
				{
					int id = iw.getInt("account id: ");
					Account acc = bank.FindAccount(id);
					Atm.ProcessAccount(acc);
				}
				else if (cmd.Equals("month"))
					ShowStringList(bank.GetStatements());
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
			string owner = acc.Owner.PadRight(12);
			string stype = acc.Prompt;
			string sid = acc.Id.ToString();
			string sbal = string.Format("{0:C}", acc.Balance);
			string str = owner + "\t" + stype + sid + "\t" + sbal;
			Console.WriteLine(str);
		}
	}
	private static void ShowStringList(ArrayList array)
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
		Console.WriteLine("\tmonth    -- prepare monthly statements for all accounts");
		Console.WriteLine("\tquit     -- exit the program");
	}
}