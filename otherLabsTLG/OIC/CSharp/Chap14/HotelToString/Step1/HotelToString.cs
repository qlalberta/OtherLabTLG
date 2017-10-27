// HotelToString.cs

using System;

public class HotelToString
{
	public static void Main()
	{
		Hotel alpha = new Hotel("Atlanta", "Dixie");
		Hotel beta = new Hotel("Boston", "Yankee");
		Console.WriteLine(alpha.ToString());
		Console.WriteLine(beta.ToString());
	}
}