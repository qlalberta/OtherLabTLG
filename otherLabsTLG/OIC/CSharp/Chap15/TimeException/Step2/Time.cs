// Time.cs

using System;

public class Time
{
	private int hour;
	private int minute;
	public Time(int h, int m)
	{
		hour = h;
		minute = m;
	}
	public static explicit operator Time(string str)
	{
		char[] seps = {':'};
		string[] pieces = str.Split(seps);
		if (pieces.Length != 2)
			throw new Exception("Improper format for time");

		int hour = Convert.ToInt32(pieces[0]);
		if (hour < 0 || hour > 23)
			throw new Exception("Hours out of range");

		int minute = Convert.ToInt32(pieces[1]);
		if (minute < 0 || minute > 59)
			throw new Exception("Minutes out of range");

		Time t = new Time(hour, minute);
		return t;
	}
	public static implicit operator string(Time t)
	{
		return t.hour + ":" + t.minute;
	}
	public void Show()
	{
		Console.WriteLine("{0} hours {1} minutes", hour, minute);
	}
}
