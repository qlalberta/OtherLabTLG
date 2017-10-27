using System;
using NUnit.Framework;

namespace QueueLib
{
	[TestFixture]
	public class QueueFixture
	{
		private MyQueue que;
		private int SizeQueue;

		[SetUp]
		public void SetupQueue()
		{
			que = new MyQueue(SizeQueue);
			Console.WriteLine("Setup up queue of size {0}", SizeQueue);
		}
		[TearDown]
		public void TearDownQueue()
		{
			Console.WriteLine("Tear down queue");
		}
		[TestFixtureSetUp]
		public void SetupQueueFixture()
		{
			SizeQueue = 3;
			Console.WriteLine("Setup up queue fixture");
		}
		[TestFixtureTearDown]
		public void TearDownQueueFixture()
		{
			Console.WriteLine("Tear down queue fixture");
		}

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
