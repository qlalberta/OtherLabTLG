// OutputMath.cs

public class OutputMath
{
	public static void Calculate(int x, int y, out int sum, out int prod)
	{
		sum = x + y;
		prod = x * y;
	}
}