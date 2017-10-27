// EmailStrings.cs

using System;

public class EmailStrings
{
	public static void Main()
	{
		InputWrapper iw = new InputWrapper();
		char[] seps = {'@', '.'};
		string[] pieces;
		Console.WriteLine("Enter a string, empty string to terminate");
		string email = iw.getString("email: ");
		while (! email.Equals(""))
		{
			//Console.WriteLine(email);
			pieces = email.Split(seps);
			foreach (string part in pieces)
				Console.WriteLine(part);
			email = iw.getString("email: ");
		}
	}
}