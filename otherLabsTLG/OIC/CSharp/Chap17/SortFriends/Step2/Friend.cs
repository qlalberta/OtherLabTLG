// Friend.cs

using System;
using System.Collections;

public class Friend : IComparable
{
	public Friend(string name, string spouse)
	{
		name_ = name;
		spouse_ = spouse;
	}
	public override string ToString()
	{
		string val = string.Format("Friend: {0,20}, Spouse{1,20}",name_, spouse_);
		return val;
	}
	public string Name
	{
		get{return name_;}
	}
	public string Spouse
	{
		get{return spouse_;}
	}

	public int CompareTo(object rhs)
	{
		Friend f = rhs as Friend;
		if (f == null)
		{
			throw new Exception("Invalid comparison, parameter is not 'Friend'");
		}
		return name_.CompareTo(f.Name);
	}
	private string name_;
	private string spouse_;

}
public class SpouseComparer : IComparer
{
	public int Compare(object x, object y)
	{
		Friend xF = x as Friend;
		Friend yF = y as Friend;
		if (xF == null || yF == null)
		{
			throw new Exception("Invalid comparison, parameter is not 'Friend'");
		}
		return xF.Spouse.CompareTo(yF.Spouse);
	}
}
