// Bytes.cs - Step 2
//
// Calculate and print out number of bytes in a kilobyte,
// megabyte, and gigabyte
// Step 2 -- terabyte, using long

using System;

class Bytes
{
    public static void Main(String[] args)
    {
        int kilo = 1024;
        int mega = kilo * kilo;
        long giga = kilo * mega;
        long tera = kilo * giga;
        Console.WriteLine("1 kilobyte = " + kilo + " bytes");
        Console.WriteLine("1 megabyte = " + mega + " bytes");
        Console.WriteLine("1 gigabyte = " + giga + " bytes");
        Console.WriteLine("1 terabyte = " + tera + " bytes");
    }
}
