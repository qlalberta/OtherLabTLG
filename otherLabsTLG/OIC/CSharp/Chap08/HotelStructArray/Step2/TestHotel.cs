// TestHotel.cs

using System;

class TestHotel
{
	static Hotel[] hArray = new Hotel[5];
	static Hotel[] hCopy = new Hotel[5];
	static void Main(string[] args)
	{
		hArray[0].init("El Paso","Ramada Inn", 50, 69.95M);
		hArray[1].init("Los Angeles","Ritz Carlton", 120, 245.00M);
		hArray[2].init("Phoenix","Quality Inn", 55, 39.95M);
		hArray[3].init("Baltimore","Motel 6", 25, 29.95M);
		hArray[4].init("Chicago","King Suites", 250, 160.00M);
		foreach (Hotel h in hArray)
		{
			h.Show();
		}
		for (int i=0; i<5; i++)
		{
			hCopy[i] = hArray[i];
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
