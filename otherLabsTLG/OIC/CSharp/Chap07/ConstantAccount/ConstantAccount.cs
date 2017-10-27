// ConstantAccount.cs

using System;

public class ConstantAccount
{
	public static void Main(string[] args)
	{
        Account acc = new Account();
        Console.WriteLine("FEE = {0}", acc.FEE);
        acc.FEE = 7.00m;        // illegal
        Console.WriteLine("FEE = {0}", acc.FEE);
        Account acc1 = new Account(10);
        Console.WriteLine("{0} free checks", acc.FreeChecks);

        Console.WriteLine("{0} free checks", acc1.FreeChecks);
		// acc.FreeChecks = 20;		// illegal
	}
}