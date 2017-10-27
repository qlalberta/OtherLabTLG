// TestContacts.cs

using System;

public class TestContacts
{
	public static void Main()
	{
		InputWrapper iw = new InputWrapper();
		Console.WriteLine("Enter command, quit to exit");
		string cmd = iw.getString("> ");
		while (! cmd.Equals("quit"))
		{
			//Console.WriteLine("command is " + cmd);
			switch (cmd)
			{
				case "add":
					Console.WriteLine("add command");
					break;
				case "forward":
					Console.WriteLine("forward command");
					break;
				case "reverse":
					Console.WriteLine("reverse command");
					break;
				case "find":
					Console.WriteLine("find command");
					break;
				case "remove":
					Console.WriteLine("remove command");
					break;
				default:
					Console.WriteLine("The following commands are available:");
					Console.WriteLine("   add       add a contact");
					Console.WriteLine("   forward   show contacts in forward order");
					Console.WriteLine("   reverse   show contacts in reverse order");
					Console.WriteLine("   find      find a contact");
					Console.WriteLine("   remove    remove a contact");
					Console.WriteLine("   quit      exit the program");
					break;
			}
			cmd = iw.getString("> ");
		}
	}
}