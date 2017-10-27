// Convert.cs - Step 2
//
// Program converts a hardcoded temperature in
// Fahrenheit to Celsius
//
// Two little "gotcha's":
//   1) "in" is some reserved entity and could not be
//       used as the InputWrapper object
//   2) "Convert" is the name of a class in System, and so
//       could not be used within the System namespace for
//       another class (this problem surfaced with the use
//       of the InputWrapper class: the latter compilation
//       broke)

using System;

class ConvertTemp
{
    public static void Main(string[] args)
    {
        InputWrapper iw = new InputWrapper();
        int fahr = iw.getInt("Temperature in Fahrenheit: ");
        int celsius = (fahr - 32) * 5 / 9;
        Console.WriteLine("fahrenheit = " + fahr);
        Console.WriteLine("celsius = " + celsius);
        // Redo calculation using double
        // Cast one of the integers to double and use a double
        // variable for celsius
        double dblCel = (fahr - (double) 32) * 5 / 9;
        Console.WriteLine("Using double, celsius = " + dblCel);
    }
}
