// TestInterfaces.cs - Step 6

using System;

public class TestInterfaces
{
	static Account acc;
	static IAccount iacc;
	static IStatement istat;
	static IChecking ichk;
	static ISavings isav;
	public static void Main()
	{
		// Initialize accounts and show starting state
		Account[] accounts = new Account[3];
		accounts[0] = new CheckingAccount(100, "Bob", 0);
		accounts[1] = new SavingsAccount(200, "Mary", 1);
		accounts[2] = new CheckingAccount(300, "Charlie", 2);
		ShowAccounts(accounts);
		acc = accounts[0];
		SetInterfaces();
		Console.WriteLine(istat.GetStatement());
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
					SetInterfaces();
					Console.WriteLine(istat.GetStatement());
				}
				else if (cmd.Equals("deposit"))
				{
					decimal amount = iw.getDecimal("amount: ");
					iacc.Deposit(amount);
					ShowBalance(istat);
				}
				else if (cmd.Equals("withdraw"))
				{
					decimal amount = iw.getDecimal("amount: ");
					iacc.Withdraw(amount);
					ShowBalance(istat);
				}
				else if (cmd.Equals("statement"))
				{
					Console.WriteLine(istat.GetStatement());
				}
				else if (cmd.Equals("post"))
				{
					istat.Post();
					Console.WriteLine(istat.GetStatement());
				}
				else if (cmd.Equals("month"))
				{
					istat.MonthEnd();
					Console.WriteLine(istat.GetStatement());
				}
				else if (cmd.Equals("fee"))
				{
					if (ichk == null)
						Console.WriteLine("IChecking is not supported");
					else
						Console.WriteLine("fee = {0:C}", ichk.Fee);
				}
				else if (cmd.Equals("interest"))
				{
					if (isav == null)
						Console.WriteLine("ISavings is not supported");
					else
						Console.WriteLine("interest = {0:C}", isav.Interest);
				}
				else if (cmd.Equals("rate"))
				{
					if (isav == null)
						Console.WriteLine("ISavings is not supported");
					else
						Console.WriteLine("rate = {0}", isav.Rate);
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
			string str = sid + "\t" + stype + owner + "\t" + sbal;
			Console.WriteLine(str);
		}
	}
	private static void SetInterfaces()
	{
		iacc = acc as IAccount;
		if (iacc != null)
			Console.WriteLine("IAccount is supported");
		istat = acc as IStatement;
		if (istat != null)
			Console.WriteLine("IStatement is supported");
		ichk = acc as IChecking;
		if (ichk != null)
			Console.WriteLine("IChecking is supported");
		isav = acc as ISavings;
		if (isav != null)
			Console.WriteLine("ISavings is supported");
	}
	private static void ShowBalance(IStatement istat)
	{
		Console.WriteLine("balance = {0}", istat.FormatBalance());
	}
	private static void help()
	{
		Console.WriteLine("The following commands are available:");
		Console.WriteLine("\tshow     -- show all accounts");
		Console.WriteLine("\taccount  -- set account to work on");
		Console.WriteLine("\tdeposit  -- deposit to account");
		Console.WriteLine("\twithdraw -- withdraw from account");
		Console.WriteLine("\tstatement-- display account statement");
		Console.WriteLine("\tpost     -- post to account");
		Console.WriteLine("\tmonth    -- initialize for new month");
		Console.WriteLine("\tfee      -- show fee (checking only)");
		Console.WriteLine("\tinterest -- show interest (savings only)");
		Console.WriteLine("\trate     -- show rate (savings only)");
		Console.WriteLine("\tquit     -- exit the program");
	}
}