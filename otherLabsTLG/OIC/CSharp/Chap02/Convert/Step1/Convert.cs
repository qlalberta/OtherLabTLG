// Convert.cs - Step 1
//
// Program converts a hardcoded temperature in
// Fahrenheit to Celsius

using System;

class Convert
{
    public static void Main(string[] args)
    {
        int fahr = 86;
        int celsius = (fahr - 32) * 5 / 9;
        Console.WriteLine("fahrenheit = " + fahr);
        Console.WriteLine("celsius = " + celsius);
    }
}
