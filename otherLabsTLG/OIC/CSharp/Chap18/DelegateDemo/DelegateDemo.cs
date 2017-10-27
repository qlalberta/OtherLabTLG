using System;

class DelegateDemo
{
	private static int[] array;

	public static void Main()
	{
		InitArray();
		ShowArray(GetArray());
		Ascending();
		Descending();
	}

	private static void InitArray()
	{
		Random rand = new Random();
		// Random size between 5 and 10
		int size = rand.Next(5, 10);
		array = new int[size];
		for (int i = 0; i < size; i++)
		{
			// Random integers between 1 and 100
			array[i] = rand.Next(1, 100);
		}
	}

	private static int[] GetArray()
	{
		return array;
	}

	private static void ShowArray(int[] array)
	{
        foreach (int num in array)
            Console.Write("{0, 4}", num);
		Console.WriteLine();
	}

	// named methods
	private static bool LessThan(int x, int y)
	{
		if (x < y)
			return true;
		else
			return false;
	}
	private static bool GreaterThan(int x, int y)
	{
		if (x > y)
			return true;
		else
			return false;
	}

	// delegate
	delegate bool Compare(int x, int y);

	private static void BubbleSort(int[] array, Compare comp)
	{
		for (int i = array.Length - 1; i >= 0; i--)
		{
			for (int j = 0; j < i; j++)
			{
				if (comp(array[j], array[j + 1]))
				{
					int temp = array[j];
					array[j] = array[j + 1];
					array[j + 1] = temp;
				}
			}
		}
	}

	private static void Ascending()
	{
		int[] array = GetArray();
		// Instantiate delegate for ascending sort
		Compare comp = new Compare(GreaterThan);
		BubbleSort(array, comp);
		ShowArray(array);
	}

	private static void Descending()
	{
		int[] array = GetArray();
		// Instantiate delegate for descending sort
		Compare comp = new Compare(LessThan);
		BubbleSort(array, comp);
		ShowArray(array);
	}
}
