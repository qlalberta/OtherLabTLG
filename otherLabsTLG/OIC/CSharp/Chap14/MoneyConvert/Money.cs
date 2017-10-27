// Money.cs

using System;

public class Money
{
   private decimal amount;
	public Money(string str)
	{
		amount = Convert.ToDecimal(str);
	}
	public Money(double num)
	{
		amount = Convert.ToDecimal(num);
	}
	public Money(decimal num)
	{
		amount = num;
	}
	public Money()
	{
	}
	public string MoneyStr
	{
		get
		{
			return string.Format("{0:C}", amount);
		}
	}
	public static explicit operator Money(string str)
	{
		Money mon = new Money(str);
		return mon;
	}
	public static explicit operator Money(double num)
	{
		Money mon = new Money(num);
		return mon;
	}
	public static explicit operator Money(decimal num)
	{
		Money mon = new Money(num);
		return mon;
	}
	public static implicit operator string(Money mon)
	{
		return string.Format("{0:C}", mon.amount);
	}
	public static implicit operator double(Money mon)
	{
		return Convert.ToDouble(mon.amount);
	}
	public static implicit operator decimal(Money mon)
	{
		return mon.amount;
	}
}