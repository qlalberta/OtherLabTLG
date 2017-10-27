// Checked.cs

using System;

public class Checked
{
    public static int Main(string[] args)
    {
        int x = 99999;
        int y = 99999;
        //ulong z = 99999 * 99999;
        ulong z;
        //Console.WriteLine("compiled: {0} * {1} = {2}", x, y, z);
        z = checked((ulong) x * (ulong) y);
        Console.WriteLine("runtime: {0} * {1} = {2}", x, y, z);
        return 0;
    }
}