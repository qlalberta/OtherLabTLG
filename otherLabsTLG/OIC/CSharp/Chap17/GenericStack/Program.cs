using System;

class Program
{
    static void Main(string[] args)
    {
        MyStack<int> intstack = new MyStack<int>(3);
        MyStack<string> strstack = new MyStack<string>(4);
        intstack.Push(5);
        intstack.Push(17);
        intstack.Push(33);
        intstack.Show();
        Console.WriteLine("{0} popped", intstack.Pop());
        Console.WriteLine("{0} popped", intstack.Pop());
        Console.WriteLine("{0} popped", intstack.Pop());
        strstack.Push("Amy");
        strstack.Push("Bob");
        strstack.Push("Charlie");
        strstack.Push("David");
        strstack.Show();
        try
        {
            strstack.Push("Ellen");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        try
        {
            Console.WriteLine("{0} popped", intstack.Pop());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
