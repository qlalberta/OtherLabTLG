// Clock.cs

public class Clock
{
   private int hour;
	public Clock(int h)
	{
		hour = h % 12;
		if (hour == 0)
			hour = 12;
	}
	public int Hour
	{
		get
		{
			return hour;
		}
		set
		{
			hour = value;
		}
	}
	public static Clock operator+(Clock c1, Clock c2)
	{
		int h = c1.hour + c2.hour;
		Clock c3 = new Clock(h);
		return c3;
	}
	public static Clock operator+(Clock c1, int h2)
	{
		int h = c1.hour + h2;
		Clock c3 = new Clock(h);
		return c3;
	}
}