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
		while (str != "")
		{
			try
			{
				Time t = (Time) str;
				t.Show();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			str = iw.getString("time: ");
		}
		Console.WriteLine("Goodbye");
	}
}
