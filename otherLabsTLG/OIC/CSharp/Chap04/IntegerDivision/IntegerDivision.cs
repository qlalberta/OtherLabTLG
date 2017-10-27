// IntegerDivision.cs

using System;

public class IntegerDivision
{
	public static int Main(string[] args)
   {
		Console.WriteLine("{0} / {1} = {2}", 17, 5, 17/5);
		Console.WriteLine("{0} / {1} = {2}", 17, -5, 17/-5);
		int zero = 0;
		Console.Write("{0} / {1} = ", 17, zero);
		Console.WriteLine("{2}", 17/zero);
		return 0;
	}
}


try 
{
    console.Write("Integer{0} / {1} = ", 17, zero);
    console.WriteLine("{2}", 17/zero);
}
catch { Console.WriteLine("Exception"); }
try 
{
