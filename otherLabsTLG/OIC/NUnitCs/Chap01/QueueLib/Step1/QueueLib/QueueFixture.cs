using System;
using NUnit.Framework;

namespace QueueLib
{
	[TestFixture]
	public class QueueFixture
	// needs to be public
	{
		[Test]
		public void T01_Empty()
		{
			MyQueue que = new MyQueue(3);
			int count = que.Count;
			Assert.AreEqual(count, 0);
		}
		[Test]
		public void T02_EnqueueOne()
		{
			MyQueue que = new MyQueue(3);
			que.Enqueue(17);
			Assert.AreEqual(que.Count, 1);
		}
	}
}
