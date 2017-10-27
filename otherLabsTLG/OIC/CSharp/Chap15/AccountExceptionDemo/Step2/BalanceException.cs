// BalanceException.cs

using System;

public class BalanceException : Exception
{
	private decimal shortage;
	public BalanceException(string message, decimal shortage) 
		: base(message)
	{
		this.shortage = shortage;
	}
	public decimal Shortage
	{
		get
		{
			return shortage;
		}
	}
}
