// HotelToString.cs - Step 3

using System;

public class HotelToString
{
	public static void Main()
	{
		Hotel alpha = new Hotel("Atlanta", "Dixie");
		Hotel beta = new Hotel("Boston", "Yankee");
		Console.WriteLine("Hotel alpha is {0}", alpha.city);
		Console.WriteLine("Hotel beta is {0}", beta.city);
	}
}