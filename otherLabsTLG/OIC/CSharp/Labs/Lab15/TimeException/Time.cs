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
        char[] seps = { ':' };
        string[] pieces = str.Split(seps);
        int index = str.IndexOf(':');
        if (index == -1)
        {
            throw new Exception(
                "The input doesnot contain ':'");
        }
        int hour = Convert.ToInt32(pieces[0]);
        if (hour > 23 || hour < 0)
        {
            throw new Exception(
                "The hour input is not valid. Please input the number between 0 and 23");
        }
        int minute = Convert.ToInt32(pieces[1]);
        if (minute > 59 || minute < 0)
        {
            throw new Exception(
                "The minuute input is not valid. Please input the number between 0 and 59");
        }
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
