//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class Exercise1
//{
//    static int ReturnNumber(int x, int[] y)
//    {
//        if (x == 1)
//        {
//            return y[0] = x;
//        }
//        if (x > 1)
//        {
//            y[x - 1] = x;
//        }
//        return ReturnNumber(x-1, y);
//    }
//    static void Main(string[] args)
//    {
//        Console.Write("How many numbers to print: ");
//        string buf = Console.ReadLine();
//        int a = Convert.ToInt32(buf);
//        int[] b = new int [a];
//        ReturnNumber(a, b);
//        foreach(int key in b)
//        {
//            Console.Write(key + " ");
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//class Exercise2
//{
//    static int ReturnNumber(int x, int[] y)
//    {
//        if (x == 1)
//        {
//            return y[0] = x;
//        }
//        if (x > 1)
//        {
//            y[x - 1] = x;
//        }
//        return ReturnNumber(x - 1, y);
//    }
//    static void Main(string[] args)
//    {
//        Console.Write("Input the range to print starting from 1: ");
//        string buf = Console.ReadLine();
//        int a = Convert.ToInt32(buf);
//        int[] b = new int[a];
//        ReturnNumber(a, b);
//        Console.Write("All even numbers from 1 to {0} are:\n ", a);
//        foreach (int key in b)
//        {
//            if (key % 2 == 0)
//            {
//                Console.Write(key + " ");
//            }
//        }
//        Console.WriteLine();
//        Console.Write("All odd numbers from 1 to {0} are:\n ", a);
//        foreach (int key in b)
//        {
//            if (key % 2 != 0)
//            {
//                Console.Write(key + " ");
//            }
//        }
//    }
//}

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Exercise3
//{
//    static void Main(string[] args)
//    {
//        ArrayList BaseballTeam = new ArrayList();
//        BaseballTeam.Add("Yankees");
//        BaseballTeam.Add("Cubs");
//        BaseballTeam.Add("Dodgers");
//        string[] AdditioanlTeam = new string[2];
//        AdditioanlTeam[0] = "Red Socks";
//        AdditioanlTeam[1] = "Blue Jays";
//        BaseballTeam.Add(AdditioanlTeam[0]);
//        BaseballTeam.Add(AdditioanlTeam[1]);
//        Console.WriteLine("Items proir to removal: ");
//        for(int i = 0; i <BaseballTeam.Count; i++)
//        {
//            Console.WriteLine(BaseballTeam[i]);
//        }
//        Console.WriteLine();
//        Console.WriteLine("Items following removal: ");
//        BaseballTeam.Remove("Dodgers");
//        BaseballTeam.Remove("Red Socks");
//        for (int i = 0; i < BaseballTeam.Count; i++)
//        {
//            Console.WriteLine(BaseballTeam[i]);
//        }

//    }
//}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exercise4
{
    static void Main(string[] args)
    {
        Queue NumberList = new Queue();
        NumberList.Enqueue(0);
        NumberList.Enqueue(5);
        NumberList.Enqueue(10);
        NumberList.Enqueue(15);
        NumberList.Enqueue(20);
        Console.Write("Queue Values: ");
        Show();
        Console.WriteLine("\n");
        int a = (int)NumberList.Dequeue();
        Console.Write("Removed item: ");
        Console.WriteLine(a);
        Console.Write("Remaining Queue Values: ");
        Show();
        Console.WriteLine("\n");
        Console.Write("First item in the Queue: ");
        Console.Write(NumberList.Peek());
        Console.WriteLine();
        Console.Write("Remaining Queue Values: ");
        Show();

        void Show()
        {
            foreach (int key in NumberList)
            {
                Console.Write(key + " ");
            }
        }

    }
}