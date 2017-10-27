// SimpleCalc.cs
//
// This program does a simple calculation: 
// calculate area of a rectangle

public class SimpleCalc
{
	static void Main()
	{
		int width = 20;
		int height = 5;
		int area;
		area = width * height;
		System.Console.WriteLine("area = {0}", area);
        System.Console.WriteLine("Prese Enter to exit");
        System.Console.ReadLine();
	}
}