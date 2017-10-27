using System;
using NUnit.Framework;

namespace QueueLib
{
	[TestFixture]
	public class QueueFixture
	{
		private MyQueue que;

		[SetUp]
		public void SetupQueue()
		{
			que = new MyQueue(3);
		}

		[Test]
		public void T09_EnqDeq2Enqueue3GetArray()
		{
			que.Enqueue(1);
			que.Enqueue(2);
			que.Dequeue();
			que.Dequeue();
			que.Enqueue(17);
			que.Enqueue(27);
			que.Enqueue(37);
			int[] inarr = { 16, 27, 36 };
			int[] outarr = que.ToArray();
			foreach (int x in inarr)
				Console.Write("{0} ", x);
			Console.WriteLine();
			foreach (int x in outarr)
				Console.Write("{0} ", x);
			Console.WriteLine();
			Assert.AreEqual(inarr.Length, outarr.Length);
			int i = 0;
			foreach (int x in outarr)
			{
				Assert.AreEqual(inarr[i], x);
				i += 1;
			}
		}
		[Test]
		public void T09_Custom()
		{
			que.Enqueue(1);
			que.Enqueue(2);
			que.Dequeue();
			que.Dequeue();
			que.Enqueue(17);
			que.Enqueue(27);
			que.Enqueue(37);
			int[] inarr = { 16, 27, 36 };
			int[] outarr = que.ToArray();
			foreach (int x in inarr)
				Console.Write("{0} ", x);
			Console.WriteLine();
			foreach (int x in outarr)
				Console.Write("{0} ", x);
			Console.WriteLine();
			ArrayAssert.AreEqual(inarr, outarr);
		}
	}
}
