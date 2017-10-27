// ArrayName.cs - Step 2

using System;
using System.Collections;

public class Name : IComparable
{
	private string text;
	public Name(string text)
	{
		this.text = text;
	}
	public string Text
	{
		get
		{
			return text;
		}
	}
	public int CompareTo(object obj)
	{
		string s1 = this.Text;
		string s2 = ((Name) obj).Text;
		return String.Compare(s1, s2);
	}
}

public class ArrayName
{
	public static int Main(string[] args)
	{
		Name[] array = new Name[10];
		array[0] = new Name("Michael");
		array[1] = new Name("Charlie");
		array[2] = new Name("Peter");
		array[3] = new Name("Dana");
		array[4] = new Name("Bob");
		if (array[0] is IComparable)
			Array.Sort(array);
		else
			Console.WriteLine("Name does not implement IComparable");
		foreach (Name name in array)
			Console.WriteLine(name);
		return 0;
	}
}
