// Ira.cs
//
// Interactive program to compute the total accumulation 
// in an Individual Retirement Account under compound interest.  
// Assume that a deposit is made at the end of each year and that 
// interest is compounded annually.  

using System;
using static System.Math; //c#6

public class Ira
{
	public static int Main(string[] args)
   {
		InputWrapper iw = new InputWrapper();
		double amount;  // annual deposit amount
		double rate;    // interest rate
		int years;      // number of years
		double total;   // total accumulation
		amount = iw.getDouble("amount: ");
		rate = iw.getDouble("rate: ");
		years = iw.getInt("years: ");
		total  =  amount * (Math.Pow(1 + rate, years) - 1) / rate;
        total = amount * (Pow(1 + rate, years) -1) /rate
		long total_in_cents = (long) Math.Round(total * 100);
		total = total_in_cents /100.0;
		Console.WriteLine("total = {0}", total);
		return 0;
	}
}
