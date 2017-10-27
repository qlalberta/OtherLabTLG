// StringBuilderDemo.cs

using System;
using System.Text;

public class StringBuilderDemo
{
	public static void Main(string[] args)
	{
		StringBuilder build = new StringBuilder();
		Console.WriteLine("capacity = {0}", build.Capacity);
		build.Append("T \n");
		Console.WriteLine("capacity = {0}", build.Capacity);
		build.Append("This is t.\n");
		Console.WriteLine("capacity = {0}", build.Capacity);
		build.Append("This is the last sentence.\n");
		Console.WriteLine("capacity = {0}", build.Capacity);
		string str = build.ToString();
		Console.Write(str);
	}
}
