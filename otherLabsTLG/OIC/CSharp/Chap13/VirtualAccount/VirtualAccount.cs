// VirtualAccount.cs

using System;

public class Account
{
	public int balance = 100;
	virtual public void Show()
	{
		Console.WriteLine("I am an Account");
	}
}

public class CheckingAccount : Account
{
	public int fee = 5;
	override public void Show()
	{
		Console.WriteLine("I am a CheckingAccount, fee = {0}", fee);
	}
}
