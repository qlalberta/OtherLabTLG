using System;
using System.Collections.Generic;

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
		private Queue<int> que;
		public MyQueue()
		{
			que = new Queue<int>();
		}
		public int Count
		{
			get
			{
				return que.Count;
			}
		}
		public void Enqueue(int x)
		{
			que.Enqueue(x);
		}

		public int Dequeue()
		{
			return que.Dequeue();
		}

		public int[] ToArray()
		{
			if (Count == 0)
				return null;
			int[] arr = new int[Count];
			int ia = 0;
			foreach (int x in que)
			{
				arr[ia] = x;
				ia += 1;
			}
			return arr;
		}
	}
}
