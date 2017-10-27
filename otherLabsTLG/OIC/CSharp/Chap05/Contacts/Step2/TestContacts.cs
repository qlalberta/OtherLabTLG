// TestContacts.cs

using System;

public class TestContacts
{
	public static void Main()
	{
		string[] names = new string[10];
		int count = 0;
		int index;
		string target;
		names[count++] = "Tom";
		names[count++] = "Dick";
		names[count++] = "Harry";
		InputWrapper iw = new InputWrapper();
		Console.WriteLine("Enter command, quit to exit");
		string cmd = iw.getString("> ");
		while (! cmd.Equals("quit"))
		{
			//Console.WriteLine("command is " + cmd);
			switch (cmd)
			{
				case "add":
					//Console.WriteLine("add command");
					string name = iw.getString("name: ");
					names[count++] = name;
					break;
				case "forward":
					//Console.WriteLine("forward command");
					//foreach (string n in names)
					//	Console.WriteLine(n);
					for (int i = 0; i < count; i++)
						Console.WriteLine(names[i]);
					break;
				case "reverse":
					//Console.WriteLine("reverse command");
					for (int i = count - 1; i >= 0; i--)
						Console.WriteLine(names[i]);
					break;
				case "find":
					//Console.WriteLine("find command");
					target = iw.getString("target name: ");
					index = Search(names, count, target);
					if (index != -1)
						Console.WriteLine("{0} found at {1}", target, index);
					else
						Console.WriteLine("{0} not found", target);
					break;
				case "remove":
					//Console.WriteLine("remove command");
					target = iw.getString("remove name: ");
					index = Search(names, count, target);
					if (index != -1)
					{
						// Move names to fill hole
						for (int i = index; i < count - 1; i++)
							names[i] = names[i + 1];
						count--;
						Console.WriteLine("{0} has been removed", target);
					}
					else
						Console.WriteLine("{0} not found", target);
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
	public static int Search(string[] array, int count, string target)
	{
		int i = 0;
		bool found = false;
		while (!found && i < count)
		{
			if (target == array[i])
				found = true;
			else
				i++;
		}
		if (found)
			return i;
		else
			return -1;
	}
}