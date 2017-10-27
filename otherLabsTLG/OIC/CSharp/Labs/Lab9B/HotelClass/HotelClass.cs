// HotelClass.cs

using System;

public class Hotel
{
	public Hotel(string city, string name, int rooms, decimal cost)
	{
		Console.WriteLine("Hotel class instance");
		this.city = city;
		this.name = name;
		this.rooms = rooms;
		this.cost = cost;
	}
	public void Show()
	{
		Console.WriteLine("{0} {1} {2} {3:C}", city, name, rooms, cost);
	}
	private string city;
	private string name;
	private int rooms;
	private decimal cost;
}
