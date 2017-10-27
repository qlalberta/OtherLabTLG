// DecimalLiterals.cs

using System;

public class DecimalLiterals
{
	public static int Main(string[] args)
   {
		double pi = 3.14;
		float e = 2.72F;
		double earthFromSun = 9.3E7;
		decimal mySalary = 199.50M;
		decimal nationalDebit = 7E12M;
		Console.WriteLine("pi = " + pi);
		Console.WriteLine("e = " + e);
		Console.WriteLine("earthFromSun = " + earthFromSun);
		Console.WriteLine("mySalary = " + mySalary);
		Console.WriteLine("nationalDebit = " + nationalDebit);
		return 0;
	}
}