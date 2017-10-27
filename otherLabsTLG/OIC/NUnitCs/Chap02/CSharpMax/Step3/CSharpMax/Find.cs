using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CSharpMax
{
	public class Find
	{
		public static int Max(int x, int y, int z)
		{
			int max = x;
			if (y > max)
				max = y;
			if (z > max)
				max = z;
			return max;
		}
		public static int Div(int x, int y)
		{
			return x / y;
		}
	}

	[TestFixture]
	public class FindTest
	{
		[Test]
		public void BiggestFirst()
		{
			Assert.AreEqual(Find.Max(4, 3, 2), 4);
		}
		[Test]
		[Ignore]
		public void BiggestMiddle()
		{
			Assert.AreEqual(Find.Max(3, 4, 2), 4);
		}
		[Test]
		public void BiggestLast()
		{
			Assert.AreEqual(Find.Max(3, 2, 4), 4);
		}
		[Test]
		public void BiggestMiddleBigLast()
		{
			Assert.AreEqual(Find.Max(2, 4, 3), 4);
		}
	}

	[TestFixture]
	public class DivTest
	{
		[Test]
		public void SimpleDivide()
		{
			Assert.AreEqual(Find.Div(10, 2), 5);
		}
		[Test]
		public void DivideByZero()
		{
			// This does not raise an exception!
			Assert.AreEqual(Find.Div(10, 0), 5);
		}
	}
}
