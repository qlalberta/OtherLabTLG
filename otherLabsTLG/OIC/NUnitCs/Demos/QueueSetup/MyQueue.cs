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
		private int count;
		private int[] data;
		private int front;
		private int rear;
		public MyQueue(int size)
		{
			count = 0;
			data = new int[size];
			front = 0;
			rear = -1;
		}
		public int Count
		{
			get
			{
				return count;
			}
		}
		public void Enqueue(int x)
		{
			rear += 1;
			data[rear] = x;
			count += 1;
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
