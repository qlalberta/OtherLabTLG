using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class TestContacts
    {
        static void Main(string[] args)
        { 
            string cmd = "";
            InputWrapper iw = new InputWrapper();
            Console.WriteLine("Enter command, quit to exit");
            //cmd = iw.getString("> ")
                //.ToUpper();
            //while (cmd != "quit")
            while(! cmd.Equals("quit"))
            {
                cmd = iw.getString("> ").ToLower().TrimEnd();
                {
                    //Console.WriteLine("Enter command, quit to exit");
                    switch (cmd)
                    {
                        case "Add":
                            Console.WriteLine("Add is invoked");
                            break;
                        case "Forward":
                            Console.WriteLine("Forward is invoked");
                            break;
                        case "Reverse":
                            Console.WriteLine("Reverse is invoked");
                            break;
                        case "Find":
                            Console.WriteLine("Find is invoked");
                            break;
                        case "Remove":
                            Console.WriteLine("Remove is invoked");
                            break;
                        default:
                            Console.WriteLine("Add is to add new contact to the contact list");
                            Console.WriteLine("Forward is to add new contact to the contact list");
                            Console.WriteLine("Reverse is to add new contact to the contact list");
                            Console.WriteLine("Find is to add new contact to the contact list");
                            Console.WriteLine("Remove is to add new contact to the contact list");
                            break;
                    }
                }
            }
            //cmd = iw.getString(">");
        }
    }
}
