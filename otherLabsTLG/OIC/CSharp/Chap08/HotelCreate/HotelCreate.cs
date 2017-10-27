// HotelCreate.cs

using System;

public class HotelCreate
{
	public static void Main()
	{
		Hotel ritz = new Hotel("Boston", "Ritz", 100, 200.00m);
		ritz.Show();
		Hotel flop;
		flop.city = "Podunk";
		// Now it is OK to use the city field
		flop.name = "Flop";
		flop.rooms = 50;
		flop.cost = 30.00m;
		// Now it is OK to use the complete object
		flop.Show();
		// Attempt to use an uninitialized variable
		int x;
		x = 5;		// NEED this initialization
		Console.WriteLine("x = {0}", x);		
	}
}