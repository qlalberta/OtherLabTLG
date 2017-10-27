// ArrayDemo.cs

using System;

public class ArrayDemo
{
	static int [] array = {5, 2, 11, 7, 3};
	static int size = array.Length;
	public static void Main()
	{
		string cmd;
  		InputWrapper iw = new InputWrapper(); 
		Console.WriteLine("Enter command, quit to exit");
		cmd = iw.getString(": ");
		while (! cmd.Equals("quit"))
		{
			if (cmd.Equals("create"))
			{
				size = iw.getInt("size: ");
				array = new int[size];
			}
			else if (cmd.Equals("destroy"))
			{
				array = null;
				size = 0;
			}
			else if (cmd.Equals("squares"))
			{
				for (int i = 0; i < size; i++)
				{
					array[i] = i*i;
				}
				show();
			}
			else if (cmd.Equals("reverse"))
			{
				int[] temp = new int[size];
				for (int i = 0; i < size; i++)
				{
					temp[i] = array[size - 1 - i];
				}
				array = temp;
				show();
			}
			else if (cmd.Equals("show"))
			{
				show();
			}
			else if (cmd.Equals("sort"))
			{
				if (array != null)
				{
					Array.Sort(array);
					show();
				}
			}
			else if (cmd.Equals("random"))
			{
				Random rand = new Random();
				for (int i = 0; i < size; i++)
				{
					array[i] = rand.Next(100);
				}
				show();
			}
			else if (cmd.Equals("foreach"))
			{
				if (array != null)
				{
					foreach (int x in array)
					{
						Console.Write("{0} ", x);
					}
					Console.WriteLine();
				}
			}
			else if (cmd.Equals("search"))
			{
				int target = iw.getInt("target: ");
				int index = Array.BinarySearch(array, target);
				if (index < 0)
					Console.WriteLine("{0} not found", target);
				else
					Console.WriteLine("{0} found at index {1}", target, index);
			}
			else
				help();
			cmd = iw.getString(": ");
		}
	}
	private static void show()
	{
		for (int i = 0; i < size; i++)
		{
			Console.Write("{0} ", array[i]);
		}
		Console.WriteLine();
	}
	private static void help()
	{
		Console.WriteLine("The following commands are available:");
		Console.WriteLine("\tcreate  -- create an array");
		Console.WriteLine("\tdestroy -- destroy the array");
		Console.WriteLine("\tsquares -- populate array with squares");
		Console.WriteLine("\treverse -- reverse elements of array");
		Console.WriteLine("\tshow    -- show the array elements");
		Console.WriteLine("\tsort    -- sort the array elements");
		Console.WriteLine("\trandom  -- populate array with random numbers");
		Console.WriteLine("\tforeach -- show array using foreach");
		Console.WriteLine("\tsearch  -- binary search (array must be sorted)");
		Console.WriteLine("\tquit    -- exit the program");
	}
}