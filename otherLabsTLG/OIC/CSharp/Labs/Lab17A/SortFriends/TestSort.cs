// TestSort.cs

using System;
using System.Collections;

class TestSort
{
    static void Main(string[] args)
    {
        InputWrapper iw = new InputWrapper();
        string name = " ";
        string spouse;
        ArrayList MyMarriedFriends = new ArrayList();
        while (true)
        {
            Console.WriteLine("Enter friend's name, quit to exit");
            name = iw.getString("> ");
            if (name.Equals("quit"))
                break;
            Console.WriteLine("Enter friend's spouse's name");
            spouse = iw.getString("> ");
            Friend node = new Friend(name, spouse);
            MyMarriedFriends.Add(node);
        }
        foreach (object o in MyMarriedFriends)
        {
            // todo: what errors need to be handled here?
            try
            {
                if (name != null)
                {
                    Friend f = (Friend)o;
                    Console.WriteLine(f.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine("Please input valid names");
            }

        }
        MyMarriedFriends.Sort(); // default sort
        Console.WriteLine("\nSorted");
        foreach (object o in MyMarriedFriends)
        {
            // todo: what errors need to be handled here?
            try
            {
                if (MyMarriedFriends[0] is IComparable)
                {
                    Friend f = (Friend)o;
                    Console.WriteLine(f.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        Console.Write("Enter <cr> to end program");
        Console.ReadLine();
    }
}

