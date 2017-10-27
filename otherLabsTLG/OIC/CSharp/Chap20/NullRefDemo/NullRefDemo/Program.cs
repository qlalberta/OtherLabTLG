using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullRefDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            int? len = NameLength(name);
            if (len != null)
                Console.WriteLine("Length of {0} is {1}",
                    name, NameLength(name));
            else
                Console.WriteLine("input name is null");
        }

        private static int? NameLength(string name)
        {
            //if (name != null)
            //    return name.Length;
            //else
            //    return null;
            return name?.Length;
        }
    }
}
