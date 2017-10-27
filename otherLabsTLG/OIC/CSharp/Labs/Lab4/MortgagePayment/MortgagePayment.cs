// MortgagePayment.cs
//
// Interactive program to compute a mortgage payment

using System;

public class MortgagePayment
{
	public static int Main(string[] args)
	{
		InputWrapper iw = new InputWrapper();
		decimal amount;  // amount of loan
		double rate;     // interest rate
		int months;      // number of periods
       // Prompt for amount of loan, interest rate, and months
        amount = iw.getDecimal("amount: ");
        rate = iw.getDouble("rate: ");
        months = iw.getInt("months: ");
        // Calculate monthly payment using payment() method
        decimal monthlyPayment = payment(amount, rate, months);
        // Display this payment
        Console.WriteLine("The monthly payment is: {0}", monthlyPayment);
        Console.ReadLine();
        return 0;
	}
	/***************************************************************/
	/* payment -- calculate the payment on a loan                  */
	/* formula:                                                    */
	/*                                      -months                */
	/*        r = amount /((1 - (1+interest)        ) / interest)  */
	/***************************************************************/
	static decimal payment(decimal amount, double interest, int months)
	{
        decimal CalculatedMonthlyPayment;
        double a = 1 - Math.Pow(1 + interest, -months);
        a = a / (interest / 1200.0);
        CalculatedMonthlyPayment = amount /(decimal) a;
        return CalculatedMonthlyPayment;
	}
}