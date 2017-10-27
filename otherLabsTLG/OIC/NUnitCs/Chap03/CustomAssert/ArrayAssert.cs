using System;
using NUnit.Framework;

namespace QueueLib
{
	class ArrayAssert
	{
		public static void AreEqual(int[] arr1, int[] arr2, string msg)
		{
			string NL = Environment.NewLine;
			string explain;
			if (arr1.Length != arr2.Length)
			{
				explain = "array lengths not equal";
			}
			else
			{
				explain = "";
				for (int i = 0; i < arr1.Length; i++)
				{
					if (arr1[i] != arr2[i])
						explain += string.Format(
							"arrays differ at index {0}", i) 
							+ NL;
				}
			}
			if (explain != "")
				Assert.Fail(msg + NL + explain);
		}
		public static void AreEqual(int[] arr1, int[] arr2)
		{
			AreEqual(arr1, arr2, "");
		}
	}
}
