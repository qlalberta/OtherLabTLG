using System;
using NUnit.Framework;

namespace QueueLib
{
	[TestFixture]
	public class ArrayFixture
	{
		[Test]
		public void EqualLength()
		{
			int[] arr1 = {2, 3, 5};
			int[] arr2 = {2, 3, 5, 7};
			Assert.AreEqual(arr1.Length, arr2.Length);
		}
		[Test]
		public void EqualArrays()
		{
			int[] arr1 = { 1, 3, 5, 6 };
			int[] arr2 = { 2, 3, 5, 7 };
			Assert.AreEqual(arr1.Length, arr2.Length);
			for (int i = 0; i < arr1.Length; i++)
			{
				string msg = string.Format(
					"arrays differ at index {0}", i);
				Assert.AreEqual(arr1[i], arr2[i], msg);
			}
		}
		[Test]
		public void CustomEqualArrays()
		{
			int[] arr1 = { 1, 3, 5, 6 };
			int[] arr2 = { 2, 3, 5, 7 };
			ArrayAssert.AreEqual(arr1, arr2);
		}
		[Test]
		public void CustomEqualArraysWithMessage()
		{
			int[] arr1 = { 1, 3, 5, 6 };
			int[] arr2 = { 2, 3, 5, 7 };
			ArrayAssert.AreEqual(arr1, arr2, "arrays not equal");
		}
		[Test]
		public void CustomEqualLength()
		{
			int[] arr1 = { 2, 3, 5 };
			int[] arr2 = { 2, 3, 5, 7 };
			ArrayAssert.AreEqual(arr1, arr2);
		}
	}
}
