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
			if (count >= data.Length)
				throw new OverflowException("Queue overflow");
			rear += 1;
			data[rear] = x;
			count += 1;
		}

		public int Dequeue()
		{
			if (count == 0)
			{
				throw new UnderflowException("Queue underflow");
			}
			int x = data[front];
			front += 1;
			count -= 1;
			return x;
		}

		public int[] ToArray()
		{
			if (count == 0)
				return null;
			int[] arr = new int[count];
			int iq = front;
			int ia = 0;
			while (ia < count)
			{
				arr[ia] = data[iq];
				ia += 1;
				iq += 1;
			}
			return arr;
		}
	}
}
