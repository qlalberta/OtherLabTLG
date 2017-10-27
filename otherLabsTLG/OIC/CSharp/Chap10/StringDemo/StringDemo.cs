// StringDemo.cs 
//
// Demonstrates various methods of String class
// Also illustrates testing for string command input
//
// Implements the following commands:
//      length      show length of string
//      new         read new string to work on
//      show        show current string
//      upper       convert to all upper case
//      lower       convert to all lower case
//      append      append a string
//      substring   find a substring
//      index       find index of a substring
//      char        find character at given index
//      reverse     reverses the string
//      quit        exit the program
//

using System;

public class StringDemo
{
    private static void show(string buffer)
    {
        Console.WriteLine("current string = " + buffer);
    }
	private static void substring(string buffer)
	{
        int begin = iw.getInt("Enter beginning index: ");
        int length = iw.getInt("Enter length of substring: ");
        string buffer2 = buffer.Substring(begin, length);
        Console.WriteLine("substring = " + buffer2);
	}
	private static void index(String buffer)
	{
        String buffer2 = iw.getString("Enter second string: ");
        int index = buffer.IndexOf(buffer2);
        Console.WriteLine("index = " + index);
	}
	private static void character(String buffer)
	{
        int index = iw.getInt("Enter index: ");
        char ch = buffer[index];
        Console.WriteLine("character = " + ch);
	}
	private static String reverse(String buffer)
	{
        String reverse = "";
        for (int i = buffer.Length-1; i >= 0; i--)
             reverse += buffer[i];
        Console.WriteLine("reversed string = " + reverse);
		return reverse;
	}
	private static void help()
	{
        Console.WriteLine("legal commands are:");
        Console.WriteLine("\tlength");
        Console.WriteLine("\tnew");
        Console.WriteLine("\tshow");
        Console.WriteLine("\tupper");
        Console.WriteLine("\tlower");
        Console.WriteLine("\tappend");
        Console.WriteLine("\tsubstring");
        Console.WriteLine("\tindex");
        Console.WriteLine("\tchar");
        Console.WriteLine("\treverse");
        Console.WriteLine("\tquit");
	}
	public static void Main(string[] args)
	{
		string cmd;
		string buffer;
		string buffer2;
		iw = new InputWrapper(); 
		buffer = iw.getString("Enter string to work on: ");
		Console.WriteLine("Enter command, 'quit' to exit");
		cmd = iw.getString("> ");
		while (! cmd.Equals("quit"))
		{
			if (cmd.Equals("length"))
				Console.WriteLine("length = " + buffer.Length);
			else if (cmd.Equals("new"))
				buffer = iw.getString("new string: ");
			else if (cmd.Equals("show"))
				show(buffer);
			else if (cmd.Equals("upper"))
			{
				buffer = buffer.ToUpper();
				show(buffer);
			}
			else if (cmd.Equals("lower"))
			{
				buffer = buffer.ToLower();
				show(buffer);
			}
			else if (cmd.Equals("append"))
			{
				buffer2 = iw.getString("Enter second string: ");
				buffer = buffer + buffer2;
				show(buffer);
			}
			else if (cmd.Equals("substring"))
				substring(buffer);
			else if (cmd.Equals("index"))
				index(buffer);
			else if (cmd.Equals("char"))
				character(buffer);
			else if (cmd.Equals("reverse"))
				buffer = reverse(buffer);
			else
				help();
			cmd = iw.getString("> ");
		}
	}
	static InputWrapper iw;
}
