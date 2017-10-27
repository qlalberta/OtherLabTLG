using System;

class MyStack
{
	private int size;
	private int top;        
	private object[] data;
	public MyStack(int n)
	{
		size = n;
		data = new object[size];
		top = -1;
	}
	public void Push(object x)
	{
		if (top >= size - 1)
			throw new Exception("Stack overflow");
		data[++top] = x;
	}
	public object Pop()
	{
		if (top == - 1)
			throw new Exception("Stack underflow");
		return data[top--];
	}
    public void Show()
    {
        for (int i = 0; i <= top; i++)
        {
            Console.Write(data[i] + " ");
        }
        Console.WriteLine();
    }
}
