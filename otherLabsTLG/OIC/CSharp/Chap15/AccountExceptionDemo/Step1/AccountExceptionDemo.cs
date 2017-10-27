// AccountExceptionDemo.cs 

using System;

public class AccountExceptionDemo
{
	public static void Main(string[] args)
	{
		Account acc = new Account(100);
		ShowBalance(acc);
		string cmd;
  		InputWrapper iw = new InputWrapper(); 
		Console.WriteLine("Enter command, quit to exit");
		cmd = iw.getString("> ");
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
				else if (cmd.Equals("show"))
					ShowBalance(acc);
				else
					help();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			cmd = iw.getString("> ");
		}
	}
	private static void ShowBalance(Account acc)
	{
		Console.WriteLine("balance = {0:C}", acc.Balance);
	}
	private static void help()
	{
		Console.WriteLine("The following commands are available:");
		Console.WriteLine("\tdeposit  -- make a deposit");
		Console.WriteLine("\twithdraw -- make a withdrawal");
		Console.WriteLine("\tshow     -- show current balance");
		Console.WriteLine("\tquit     -- exit the program");
	}
}