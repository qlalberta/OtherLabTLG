using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicObject
{
   class Program
   {
      static void Main(string[] args)
      {
         dynamic dyn = null;
         object obj = null;

         try
         {
            Console.WriteLine(dyn.GetType());
         }
         catch (Exception ex)
         {
            Console.WriteLine("dyn: " + ex.Message);
         }
         try
         {
            Console.WriteLine(obj.GetType());
         }
         catch (Exception ex)
         {
            Console.WriteLine("obj: " + ex.Message);
         }

         obj = 5;                // boxed
         Console.WriteLine("obj: " + obj.GetType());
         // int num = obj;       // will not compile  
         int num = (int)obj;    // unboxed
         // Console.WriteLine(obj + num);
         // will not compile
         //string s = obj;       // will not compile
         obj = "5";
         Console.WriteLine("obj: " + obj.GetType());

         dyn = 5;
         Console.WriteLine("dyn: " + dyn.GetType());
         int num2 = dyn;         // OK
         Console.WriteLine(dyn + num2);
         try
         {
            string s2 = dyn;    // compiles
            // runtime error
         }
         catch (Exception ex)
         {
            Console.WriteLine("dyn: " + ex.Message);
         }
         dyn = "5";              // now it's a string
         Console.WriteLine("dyn: " + dyn.GetType());
      }
   }
}
