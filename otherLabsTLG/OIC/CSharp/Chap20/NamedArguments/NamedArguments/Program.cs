using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Volume of cylinder with height {0} and radius {1} is {2:F2}",
                30, 10, Volume(height: 30, radius: 10));
            // Volume(30, 10) and Volume(10, 30)
            // give different answers!
            Console.WriteLine("{0:F2}", Volume(30, 10));
            Console.WriteLine("{0:F2}", Volume(10, 30));
        }
        static double Volume(double radius, double height)
        {
            return Math.PI * radius * radius * height;
        }
    }
}
