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
		// Calculate monthly payment using payment() method
		// Display this payment

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
	}
}