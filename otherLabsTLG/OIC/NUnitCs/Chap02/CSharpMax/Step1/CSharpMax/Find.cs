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
			if (y > x)
				max = y;
			if (z > x)
				max = z;
			return max;
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
}
