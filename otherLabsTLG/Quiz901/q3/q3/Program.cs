using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            InputWrapper iw = new InputWrapper();
            int a = iw.getInt("Please input the size of an array: ");
            int[] b = new int[a];
            int count = 1;
            for(int i = 0; i < b.Length; i++)
            {
                Console.Write("Please input number {0}", count++);
                b[i] = iw.getInt(" : ");     
            }
            Array.Sort(b);
            foreach (var key in b)
            {
                Console.WriteLine(key.ToString());
            }



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