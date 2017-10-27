// Shift.cs

using System;

public class Shift
{
	public static int Main(string[] args)
   {
		int x = 30;
		Console.WriteLine("Original Number");
		WriteBinary(x);
		Console.WriteLine("   {0}", x);

		Console.WriteLine("Shifting Left");
		WriteBinary(x << 1);
		Console.WriteLine("   {0}", x << 1);
		WriteBinary(x << 2);
		Console.WriteLine("   {0}", x << 2);
		WriteBinary(x << 3);
		Console.WriteLine("   {0}", x << 3);

		Console.WriteLine("Shifting Right");
		WriteBinary(x >> 1);
		Console.WriteLine("   {0}", x >> 1);
		WriteBinary(x >> 2);
		Console.WriteLine("   {0}", x >> 2);
		WriteBinary(x >> 3);
		Console.WriteLine("   {0}", x >> 3);

		x = -30;
		Console.WriteLine("Original Number");
		WriteBinary(x);
		Console.WriteLine("   {0}", x);

		Console.WriteLine("Shifting Left");
		WriteBinary(x << 1);
		Console.WriteLine("   {0}", x << 1);
		WriteBinary(x << 2);
		Console.WriteLine("   {0}", x << 2);
		WriteBinary(x << 3);
		Console.WriteLine("   {0}", x << 3);

		Console.WriteLine("Shifting Right");
		WriteBinary(x >> 1);
		Console.WriteLine("   {0}", x >> 1);
		WriteBinary(x >> 2);
		Console.WriteLine("   {0}", x >> 2);
		WriteBinary(x >> 3);
		Console.WriteLine("   {0}", x >> 3);
		return 0;
	}
	private static void WriteBinary(int x)
	{
		for (int i = 0; i < 32; i++)
		{
			if (x < 0)
				Console.Write("1");
			else
				Console.Write("0");
			x <<= 1;
		}
	}
}