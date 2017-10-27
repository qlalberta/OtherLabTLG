// TestTime.cs

using System;

public class TestTime
{
	static void Main()
	{
		Console.WriteLine("Enter time in format hh:mm");
		Console.WriteLine("Press carriage return to quit");
		InputWrapper iw = new InputWrapper();
		string str = iw.getString("time: ");
        try
        {
            while (str != "")
            {
                Time t = (Time)str;
                t.Show();
                str = iw.getString("time: ");
            }
            Console.WriteLine("Goodbye");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        //finally
        //{
        //    Console.WriteLine("Enter time in formt hh:mm again");
        //    InputWrapper iw1 = new InputWrapper();
            string str1 = iw.getString("time: ");
        //}
    }
}
