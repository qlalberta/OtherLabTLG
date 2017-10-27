using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input 10 numbers:");
            InputWrapper iw = new InputWrapper();
            int[] a = new int[10];
            int sum = 0;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Number {0}", ++count);
                a[i] = iw.getInt(": ");
            }
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            float average = sum / 10;
            Console.WriteLine("The sum of the numbers: {0}", sum);
            Console.WriteLine("The average of the numbers: {0}", average);
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

