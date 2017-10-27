// Friend.cs

// Todo:  need to put the proper 'using' directives here
using System;
using System.Collections;


public class Friend : IComparable
// todo: What interface needs to be implemented?
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
// todo:  What methods are required to implement necessary interface?
    public int CompareTo(object obj)
    {
        string s1 = this.name_;
        string s2 = ((Friend)obj).name_;
        return String.Compare(s1, s2);
        
    }


	private string name_;
	private string spouse_;
}
