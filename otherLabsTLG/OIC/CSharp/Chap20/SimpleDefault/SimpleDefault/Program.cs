using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDefault
{
   class Program
   {
      static void Main(string[] args)
      {
            //show();
            show(100);
         show(100, 10);
         show(100, 10, 20);
            show(100,, 20);
        }
      static void show(int req, int opt1 = 1, int opt2 = 2)
      {
         Console.WriteLine("req = {0}", req);
         Console.WriteLine("opt1 = {0}", opt1);
         Console.WriteLine("opt2 = {0}", opt2);
      }
   }
}
