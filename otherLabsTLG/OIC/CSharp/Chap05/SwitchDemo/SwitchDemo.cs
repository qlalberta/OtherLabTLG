// SwitchDemo.cs

using System;

public class SwitchDemo
{
	public static int Main(string[] args)
   {
		int [] scores = {2, 3, 5, 9, 1, 2, 4};
		foreach (int score in scores)
			Console.Write("{0} ", score);
		Console.WriteLine();
		for (int i = 0; i < scores.Length; i++)
		{
			switch(scores[i])
			{
				case 1:
					Console.Write("Very ");
					goto case 2;
				case 2:
					Console.WriteLine("Low");
					break;
				case 3:
					Console.WriteLine("Medium");
					break;
				case 4:
				case 5:
					Console.WriteLine("High");
					break;
				default:
					Console.WriteLine("Special Case");
					break;
			}
		}
		return 0;
	}
}
