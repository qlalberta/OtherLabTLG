// ColorIndex.cs

public class ColorIndex
{
   private byte red = 255;
	private byte green = 127;
	private byte blue = 0;
	public byte this[int index]
	{
		get
		{
			if (index == 0)
				return red;
			else if (index == 1)
				return green;
			else
				return blue;
		}
		set
		{
			if (index == 0)
				red = value;
			else if (index == 1)
				green = value;
			else
				blue = value;
		}
	}
	public string Color
	{
		get
		{
			return red + ":" + green + ":" + blue;
		}
	}
}