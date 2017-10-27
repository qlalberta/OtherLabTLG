using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicOperation
{
   class Program
   {
      static void Main(string[] args)
      {
         dynamic x;
         try
         {
            x = "abcdef";
            // x is a string and has property Length
            Console.WriteLine("{0} has length {1}",
               x, x.Length);

            // x is now an int and does not have property Length
            x = 123456;
            Console.WriteLine("{0} has length {1}",
               x, x.Length);
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
         }
      }
   }
}
