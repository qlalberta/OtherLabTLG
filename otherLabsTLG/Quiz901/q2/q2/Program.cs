using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number:");
            InputWrapper iw = new InputWrapper();
            int a = iw.getInt("enter the first integer: ");
            int b = iw.getInt("enter the second integer: ");
            int[] c = new int[b - a + 1];
            int count = 0;
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = a;
                a++;
            }

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] % 6 == 0)
                {
                    Console.Write("{0}:", c[i]);
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("There are {0} number divisiable by 6", count);
        }
    }
}



class InputWrapper
{
    public int getInt(string prompt)
    {
        Console.Write(prompt);
        string buf = Console.ReadLine();
        return Convert.ToInt32(buf);
    }
    public double getDouble(string prompt)
    {
        Console.Write(prompt);
        string buf = Console.ReadLine();
        return Convert.ToDouble(buf);
    }
    public decimal getDecimal(string prompt)
    {
        Console.Write(prompt);
        string buf = Console.ReadLine();
        return Convert.ToDecimal(buf);
    }
    public string getString(string prompt)
    {
        Console.Write(prompt);
        string buf = Console.ReadLine();
        return buf;
    }
}