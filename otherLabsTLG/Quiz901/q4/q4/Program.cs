using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    class Program
    {
        static void Main(string[] args)
        {
            InputWrapper iw = new InputWrapper();
            int a = iw.getInt("Please input the first coordiante x: ");
            int b = iw.getInt("Please input the first coordiante y: ");
           
            Console.WriteLine
                ("The corordinate({0}, {1}) lies in the {2} quandrant", a, b, FindSection(a, b));

            int c = iw.getInt("Please input the second coordiante x: ");
            int d = iw.getInt("Please input the second coordiante y: ");
  
            Console.WriteLine
                 ("The corordinate({0}, {1}) lies in the {2} quandrant", c, d, FindSection(c, d)); ;

            int FindSection(int x, int y)
            {
                if (x > 0 && y > 0)
                    return 1;
                else if (x > 0 && y < 0)
                    return 4;
                else if (x < 0 && y > 0)
                    return 2;
                else 
                    return 3;
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