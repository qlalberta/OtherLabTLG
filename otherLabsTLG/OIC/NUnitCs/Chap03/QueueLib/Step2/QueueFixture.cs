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
		public void T01_Empty()
		{
			int count = que.Count;
			Assert.AreEqual(count, 0);
		}
		[Test]
		public void T02_EnqueueOne()
		{
			que.Enqueue(17);
			Assert.AreEqual(que.Count, 1);
		}
		[Test]
		public void T03_EnqueueDequeue()
		{
			que.Enqueue(17);
			que.Dequeue();
			Assert.AreEqual(que.Count, 0);
		}
		[Test]
		public void T04_EnqueueRememberDequeue()
		{
			que.Enqueue(17);
			int x = que.Dequeue();
			Assert.AreEqual(x, 17);
		}
		[Test]
		public void T05_Enqueue3RememberDequeue3()
		{
			que.Enqueue(17);
			que.Enqueue(27);
			que.Enqueue(37);
			int x = que.Dequeue();
			Assert.AreEqual(x, 17);
			x = que.Dequeue();
			Assert.AreEqual(x, 27);
			x = que.Dequeue();
			Assert.AreEqual(x, 37);
		}
		[Test]
		//[ExpectedException(typeof(UnderflowException))]
		public void T06_DequeueEmptyExpectedException()
		{
			que.Dequeue();
		}
		[Test]
		//[ExpectedException(typeof(OverflowException))]
		public void T07_OverflowExpectedException()
		{
			que.Enqueue(17);
			que.Enqueue(27);
			que.Enqueue(37);
			que.Enqueue(47);
		}
		[Test]
		public void T08_Enqueue3GetArray()
		{
			que.Enqueue(17);
			que.Enqueue(27);
			que.Enqueue(37);
			int[] inarr = { 17, 27, 37 };
			int[] outarr = que.ToArray();
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
	}
}
