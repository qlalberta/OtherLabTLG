using System;
using System.Collections.Generic;
using System.Text;

namespace QueueLib
{
	interface IQueue
	{
		int Count { get;}
		void Enqueue(int x);
		int Dequeue();
		int[] ToArray();
	}
	public class MyQueue : IQueue
	{
		public MyQueue(int size)
		{
		}
		public int Count
		{
			get
			{
				return -1;
			}
		}
		public void Enqueue(int x)
		{
		}
		public int Dequeue()
		{
			return 0;
		}
		public int[] ToArray()
		{
			return null;
		}
	}
}
