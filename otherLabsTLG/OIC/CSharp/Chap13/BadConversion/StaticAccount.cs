// StaticAccount.cs

using System;

public class Account
{
	public int balance = 100;
	public void Show()
	{
		Console.WriteLine("I am an Account");
	}
}

public class CheckingAccount : Account
{
	public int fee = 5;
	public void Show()
	{
		Console.WriteLine("I am a CheckingAccount, fee = {0}", fee);
	}
}
