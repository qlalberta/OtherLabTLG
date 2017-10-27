// LeapYear.cs
//
// Leap year program with accurate alogrithm
// We say that N is a leap year if N is divisible by 4
// AND (N is divisible by 400 OR N is not divisible by 100)

using System;

public class LeapYear
{
    public static int Main(string[] args)
    {
        InputWrapper iw = new InputWrapper();
        int year = iw.getInt("year: ");
        if ((year % 4 == 0) &&
            ((year % 400 == 0) || (year % 100 != 0)))
        {
            Console.WriteLine("{0} is a leap year", year);
        }
        else
            Console.WriteLine("{0} is not a leap year", year);
        return 0;
    }
}
