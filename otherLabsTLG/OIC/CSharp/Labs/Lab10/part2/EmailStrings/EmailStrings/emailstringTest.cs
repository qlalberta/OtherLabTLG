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
            //char[] seps = { '@', '.' };
            if (String.IsNullOrEmpty(emailAddress))
            {
                Environment.ExitCode = ERROR_INVALID_COMMAND_LINE;
            }
            else
            {
                Console.WriteLine(emailAddress);
            }
            int n1 = emailAddress.IndexOf('@');
            string userName = emailAddress.Substring(0, n1);
            string domain = emailAddress.Substring(n1 + 1);
            int n2 = domain.IndexOf('.');
            string organization = domain.Substring(0, n2);
            string suffix = domain.Substring(n2 + 1);
            if (suffix == "com" ||suffix =="org" ||suffix =="edu")
            {
                Console.WriteLine(userName);
                Console.WriteLine(organization);
                Console.WriteLine(suffix);
            }
        }
    }
}
