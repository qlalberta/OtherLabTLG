// HotelClass.cs

using System;

public class Hotel
{
	public Hotel(string city, string name, int rooms, decimal cost)
	{
		Console.WriteLine("Hotel class instance");
		City = city;
		Name = name;
		Rooms = rooms;
		Cost = cost;
	}
	public void Show()
	{
		Console.WriteLine("{0} {1} {2} {3:C}", City, Name, Rooms, Cost);
	}
	public string City
	{
		get
		{
			return city_;
		}
		set
		{
			city_ = value;
		}
	}
	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = value;
		}
	}
	public int Rooms
	{
		get
		{
			return rooms_;
		}
		set
		{
			rooms_ = value;
			if (rooms_ < 10)
			{
				rooms_ = 10;
			}
			else
			{
				if (rooms_ > 400)
				{
					rooms_ = 400;
				}
			}
		}
	}
	public decimal Cost
	{
		get
		{
			return cost_;
		}
		set
		{
			cost_ = value;
			if (cost_ < 30M)
			{
				cost_ = 30M;
			}
			else
			{
				if (cost_ > 150M)
				{
					cost_ = 150M;
				}
			}
		}
	}
	private string city_;
	private string name_;
	private int rooms_;
	private decimal cost_;
}
