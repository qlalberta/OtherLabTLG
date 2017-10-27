// Bytes.cs - Step 1
//
// Calculate and print out number of bytes in a kilobyte,
// megabyte, and gigabyte
//
// To get exception generated on integer overflow, compile
// with the /checked switch

using System;

class Bytes
{
    public static void Main(String[] args)
    {
        int kilo = 1024;
        int mega = kilo * kilo;
        int giga = kilo * mega;
        int tera = kilo * giga;
        Console.WriteLine("1 kilobyte = " + kilo + " bytes");
        Console.WriteLine("1 megabyte = " + mega + " bytes");
        Console.WriteLine("1 gigabyte = " + giga + " bytes");
        Console.WriteLine("1 terabyte = " + tera + " bytes");
    }
}
