// Atm.cs - Step 5

using System;
	
public class Atm
{
	public static void ProcessAccount(Account acc)
	{
		ShowBalance(acc);
		string cmd;
		InputWrapper iw = new InputWrapper(); 
		Console.WriteLine("Enter command, quit to exit");
		cmd = iw.getString(acc.Prompt);
		while (! cmd.Equals("quit"))
		{
			try
			{
				if (cmd.Equals("deposit"))
				{
					decimal amount = iw.getDecimal("amount: ");
					acc.Deposit(amount);
					ShowBalance(acc);
				}
				else if (cmd.Equals("withdraw"))
				{
					decimal amount = iw.getDecimal("amount: ");
					acc.Withdraw(amount);
					ShowBalance(acc);
				}
				else if (cmd.Equals("owner"))
				{
					string owner = iw.getString("new owner name: ");
					acc.Owner = owner;
					show(acc);
				}
				else if (cmd.Equals("show"))
					show(acc);
				else
					accountHelp();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				if (e.InnerException != null)
				{
					Console.WriteLine(e.InnerException.Message);
				}
			}
			cmd = iw.getString(acc.Prompt);
		}
	}
	private static void show(Account acc)
	{
		Console.WriteLine(acc.GetStatement());
	}
	private static void ShowBalance(Account acc)
	{
		Console.WriteLine("balance = {0}", acc.FormatBalance());
	}
	private static void accountHelp()
	{
		Console.WriteLine("The following commands are available:");
		Console.WriteLine("\tdeposit  -- make a deposit");
		Console.WriteLine("\twithdraw -- make a withdrawal");
		Console.WriteLine("\towner    -- change owner name");
		Console.WriteLine("\tshow     -- show account information");
		Console.WriteLine("\tquit     -- exit the ATM");
	}
}

