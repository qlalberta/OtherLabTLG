using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailStrings
{
    class emailstringTest
    {

        private const int ERROR_INVALID_COMMAND_LINE = 0x667;

        static void Main(string[] args)
        {
            Console.WriteLine("Please input your email address: ");
            string emailAddress = Console.ReadLine();
            char[] seps = {'@','.'};
            if (String.IsNullOrEmpty(emailAddress))
            {
                Environment.ExitCode = ERROR_INVALID_COMMAND_LINE;
            }
            else
            {
                Console.WriteLine(emailAddress);
            }
            string[] pieces = emailAddress.Split(seps);
            foreach (string piece in pieces)
                Console.WriteLine(piece);
        }
    }
}
