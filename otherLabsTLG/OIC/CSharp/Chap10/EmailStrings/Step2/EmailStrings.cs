// EmailStrings.cs

using System;

public class EmailStrings
{
	public static void Main()
	{
		InputWrapper iw = new InputWrapper();
		Console.WriteLine("Enter a string, empty string to terminate");
		string email = iw.getString("email: ");
		while (! email.Equals(""))
		{
			// Extract string to first '@' character
			int index = email.IndexOf('@', 0);
			if (index != -1)
			{
				string user = email.Substring(0, index);
				// Extract string to first '.' character
				int start = index + 1;
				index = email.IndexOf('.', index);
				if (index != -1)
				{
					string domain = email.Substring(start, index - start);
					// Check that suffix is legal
					string suffix = email.Substring(index + 1);
					if (suffix == "com" || suffix == "org" || suffix == "edu")
					{
						// Check that user and domain are alphanumeric
						if (IsAlphaNum(user) && IsAlphaNum(domain))
						{
							Console.WriteLine("user = {0}", user);
							Console.WriteLine("domain = {0}", domain);
							Console.WriteLine("suffix = {0}", suffix);
						}
						else
							Console.WriteLine("User and domain must be alphanumeric");
					}
					else
					{
						Console.WriteLine("Legal suffixes are com, org and edu");
					}
				}
				else
				{
					Console.WriteLine("No period found in email address");
				}
			}
			else
			{
				Console.WriteLine("No at symbol found in email address");
			}
			email = iw.getString("email: ");
		}
	}
	private static bool IsAlphaNum(string str)
	{
		for (int i = 0; i < str.Length; i++)
		{
			if (! char.IsLetterOrDigit(str[i]))
				return false;
		}
		return true;
	}
}