using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Time
{
    private int hour;
    private int minute;
    public Time(int h, int m)
    {
        //string strHour = hour.ToString();
        //string strMinute = minute.ToString();
        //return 
        hour = h;
        minute = m;
    }
    public static explicit operator Time(string str)
    {
        string strhour = str.Split(':')[0];
        string strminute = str.Split(':')[1];
        int hour = Convert.ToInt32(strhour);
        int minute = Convert.ToInt32(strminute);
        Time time = new Time(hour, minute);
        return time;
    }

    public static implicit operator string (Time time)
    {
        return time.hour + ":" + time.minute;
        //return time.hour.ToString() + ":" + time.minute.ToString;

    }
}

