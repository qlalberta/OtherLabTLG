// Hotel.cs

using System;
public struct Hotel
{
	public void init(string city, string name, int rooms, decimal cost)
	{
        this.city_ = city;
		this.name_ = name;
		this.rooms_ = rooms;
		this.cost_ = cost;
	}
	public void Show()
	{
		Console.WriteLine("{0} {1} {2} {3:C}",city_, name_, rooms_, cost_);
	}
	private string city_;
	private string name_;
	private int rooms_;
	private decimal cost_;
}
