using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TestTime
{
    //static void Main(string[] args)
    static void Main()
    {
        Time time = new Time(3,40);
        string strTime = time;
        Console.WriteLine(strTime);
        time = (Time) "2:30";
        Console.WriteLine((string)time);

    }
}

