// Circle.cs
//
// Read in radius of circle and compute area
//
// First calculation uses pi = 3.1416
// Second calculations uses more accurate value

using System;

class Circle
{
    public static void Main(string[] args)
    {
        InputWrapper iw = new InputWrapper();
        double radius = iw.getDouble("radius: ");
        double area = 3.1416 * radius * radius;
        Console.WriteLine("Using, 3.1416, area = " + area);
        area = Math.PI * radius * radius;
        Console.WriteLine("Using, Math.PI, area = " + area);
    }
}
