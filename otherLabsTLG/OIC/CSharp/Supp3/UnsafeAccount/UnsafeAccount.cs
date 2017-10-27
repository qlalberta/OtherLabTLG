// UnsafeAccount.cs

using System;

struct Account
{
	public int id;
	public decimal balance;
	public Account(int id, decimal balance)
	{
		this.id = id;
		this.balance = balance;
	}
}

public class UnsafeAccount
{
	public static unsafe void Main() 
	{
		int id = 101;
		decimal balance = 50.55m;
		Account acc = new Account(id, balance);
		ShowAccount(&acc);
		Account[] array = new Account[5];
		//Console.WriteLine("size of Account[] = {0}", sizeof(Account[]));
		ShowArray(array);
		fixed (Account* pStart = array)
		{
			Account* pAcc = pStart;
			for (int i = 0; i< array.Length; i++)
				*pAcc++ = acc;
		}
		ShowArray(array);
	}
	private static unsafe void ShowAccount(Account* pAcc)
	{
		Console.WriteLine("id = {0}, balance = {1:C}", pAcc->id, pAcc->balance);
	}
	private static void ShowAccount(Account acc)
	{
		Console.WriteLine("id = {0}, balance = {1:C}", acc.id, acc.balance);
	}
	private static void ShowArray(Account[] array)
	{
		for (int i = 0; i < 5; i++)
		{
			ShowAccount(array[i]);
		}
	}
}
