//  TestHotel.cs

using System;

class TestHotel
{
	static void Main(string[] args)
	{
		Hotel[] hArray = new Hotel[5]; // only creates references
		// need to call constructor for each Hotel
		hArray[0] = new Hotel("El Paso","Ramada Inn", 50, 69.95M);
		hArray[1] = 
			new Hotel("Los Angeles","Ritz Carlton", 120, 245.00M);
		hArray[2] = new Hotel("Phoenix","Quality Inn", 55, 39.95M);
		hArray[3] = new Hotel("Baltimore","Motel 6", 25, 29.95M);
		hArray[4] = new Hotel("Chicago","King Suites", 250, 160.00M);
		foreach (Hotel h in hArray)
		{
			h.Show();
		}
		Hotel[] hCopy = new Hotel[5];
		for (int i=0; i<5; i++)
		{
			// hCopy[i] = hArray[i]; ß won’t work!
			hCopy[i] = new Hotel(hArray[i]);  // call copy constructor
			hArray[i].init("","",0,0);
		}
		foreach (Hotel h in hArray)
		{
			h.Show();
		}
		foreach (Hotel h in hCopy)
		{
			h.Show();
		}
	}
}

