// TestTime.cs

using System;

public class TestTime
{
	static void Main()
	{
		Time t = new Time(12,15);
		string str = t;
		Console.WriteLine(str);
		t = (Time1) "8:30";
		Console.WriteLine((string) t);
	}
}
