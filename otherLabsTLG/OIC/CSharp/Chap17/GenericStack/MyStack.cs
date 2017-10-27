using System;

class MyStack<T>
{
    private int size;
    private int top;        
    private T[] data;
    public MyStack(int n)
    {
        size = n;
        data = new T[size];
        top = -1;
    }
    public void Push(T x)
    {
        if (top >= size - 1)
            throw new Exception("Stack overflow");
        data[++top] = x;
    }
    public T Pop()
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
