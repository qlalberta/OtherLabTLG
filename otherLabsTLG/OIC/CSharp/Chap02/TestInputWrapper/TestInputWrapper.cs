// TestInputWrapper.cs
//
// Test program for InputWrapper class

using System;

class TestInputWrapper
{
    public static int Main(string[] args)
    {
	    InputWrapper iw = new InputWrapper(); // get an input reader (read from stdin)
	    int i = iw.getInt("enter integer: ");
	    Console.WriteLine("i = {0}",i);
	    double d = iw.getDouble("enter double: ");
	    Console.WriteLine("d = {0}",d);
	    decimal dec = iw.getDecimal("enter decimal: ");
	    Console.WriteLine("dec = {0}",dec);
	    string s = iw.getString("enter string: ");
	    Console.WriteLine("s = {0}",s);
		return 0;
	}
}
