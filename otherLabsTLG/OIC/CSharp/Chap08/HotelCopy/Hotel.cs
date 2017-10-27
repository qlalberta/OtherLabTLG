// Hotel.cs

using System;

public struct Hotel
{
	public Hotel(Hotel hotel)
	{
		Console.WriteLine("Copy Hotel struct instance");
		this.city = hotel.city;
		this.name = hotel.name;
		this.rooms = hotel.rooms;
		this.cost = hotel.cost + 1m;  // not quite a copy
	}
	public Hotel(string city, string name, int rooms, decimal cost)
	{
		Console.WriteLine("Hotel struct instance");
		this.city = city;
		this.name = name;
		this.rooms = rooms;
		this.cost = cost;
	}
	public void Show()
	{
		Console.WriteLine("{0} {1} {2} {3:C}", city, name, rooms, cost);
	}
	public string city;
	public string name;
	public int rooms;
	public decimal cost;
}
