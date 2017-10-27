// TryInterfaces.cs

using System;

public class TryInterfaces
{
	public static void Main()
	{
		Account acc;
		IChecking ichk;
		ISavings isav;
		// Initialize accounts and show starting state
		Account[] accounts = new Account[3];
		accounts[0] = new CheckingAccount(100, "Bob", 0);
		accounts[1] = new SavingsAccount(200, "Mary", 1);
		accounts[2] = new CheckingAccount(300, "Charlie", 2);
		ShowAccounts(accounts);
		acc = accounts[0];
		Console.WriteLine(acc.GetStatement());
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
				else if (cmd.Equals("account"))
				{
					int id = iw.getInt("account id: ");
					acc = accounts[id];
					Console.WriteLine(acc.GetStatement());
				}
				else if (cmd.Equals("deposit"))
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
				else if (cmd.Equals("statement"))
				{
					Console.WriteLine(acc.GetStatement());
				}
				else if (cmd.Equals("fee"))
				{
					// cast to interface and check for exception
					try
					{
						ichk = (IChecking) acc;
						Console.WriteLine("fee = {0:C}", ichk.Fee);
					}
					catch (InvalidCastException e)
					{
						Console.WriteLine("IChecking in not supported");
						Console.WriteLine(e.Message);
					}
				}
				else if (cmd.Equals("interest"))
				{
					// use C# "is" operator
					if (acc is ISavings)
					{
						isav = (ISavings) acc;
						Console.WriteLine("interest = {0:C}", isav.Interest);
					}					
					else
						Console.WriteLine("ISavings in not supported");
				}
				else if (cmd.Equals("rate"))
				{
					// use C# "as" operator
					isav = acc as ISavings;
					if (isav != null)
					{
						//isav = (ISavings) acc;	// cast not necessary
						Console.WriteLine("rate = {0}", isav.Rate);
					}					
					else
						Console.WriteLine("ISavings in not supported");
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
	private static void ShowAccounts(Account[] array)
	{
		foreach (Account acc in array)
		{
			string owner = acc.Owner.PadRight(12);
			string stype = acc.Prompt;
			string sid = acc.Id.ToString();
			string sbal = acc.FormatBalance();
				//Decimal.Format(accounts[i].Balance, "C");
			string str = sid + "\t" + stype + owner + "\t" + sbal;
			Console.WriteLine(str);
		}
	}
	private static void ShowBalance(Account acc)
	{
		Console.WriteLine("balance = {0}", acc.FormatBalance());
	}
	private static void help()
	{
		Console.WriteLine("The following commands are available:");
		Console.WriteLine("\tshow     -- show all accounts");
		Console.WriteLine("\taccount  -- set account to work on");
		Console.WriteLine("\tstatement-- display account statement");
		Console.WriteLine("\tdeposit  -- deposit to account");
		Console.WriteLine("\twithdraw -- withdraw from account");
		Console.WriteLine("\tfee      -- show fee (checking only)");
		Console.WriteLine("\tinterest -- show interest (savings only)");
		Console.WriteLine("\trate     -- show rate (savings only)");
		Console.WriteLine("\tquit     -- exit the program");
	}
}