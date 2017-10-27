// Hotel.cs

using System;

public class Hotel
{
	// add constructor
	public Hotel(string city, string name, int rooms, decimal cost)
	{
		city_ = city;
		name_ = name;
		rooms_ = rooms;
		cost_ = cost;
	}
	// add copy constructor
	public Hotel(Hotel h)
	{
		city_ = h.city_;
		name_ = h.name_;
		rooms_ = h.rooms_;
		cost_ = h.cost_;
	}
	public void init(string city, string name, int rooms, decimal cost)
	{
		city_ = city;
		name_ = name;
		rooms_ = rooms;
		cost_ = cost;
	}
	public void Show()
	{
		Console.WriteLine("{0} {1} {2} {3:C}",city_, name_, rooms_, cost_);
	}
	private  string city_;
	private  string name_;
	private  int rooms_;
	private  decimal cost_;
}
