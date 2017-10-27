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
            string[] name;
            name = new string[10];
            int count = 0;
            int index;
            string input;
            string cmd;
            //bool found = false;
            name[count++] = "Tom";
            name[count++] = "Dick";
            name[count++] = "Harry";
            //can use prefix increment as well; but at the end of array, 
            //the point refers to the last thing loaded/filled, not the next empty slot.)
            InputWrapper iw = new InputWrapper();
            Console.WriteLine("Enter command, quit to exit");
            cmd = iw.getString(">");
            //while (cmd != "quit")
            while (!cmd.Equals("quit"))
            {
                switch (cmd)
                {
                    case "add":
                        Console.WriteLine("add is invoked");
                        name[count++] = iw.getString("name: ");
                        //try to sort the names
                        //array.sort() allows you sort part of the array.
                        break;
                    case "forward":
                        Console.WriteLine("forward is invoked");
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("{0}", name[i]);
                        }
                        Console.WriteLine("Enter command, quit to exit");
                        cmd = iw.getString(">");
                        break;
                    case "reverse":
                        Console.WriteLine("reverse is invoked");
                        for (int i = count - 1; i > 0; i--)
                        {
                            Console.WriteLine("{0}", name[i]);
                        }
                        Console.WriteLine("Enter command, quit to exit");
                        cmd = iw.getString(">");
                        break;
                    case "find":
                        Console.WriteLine("find is invoked");
                        input = iw.getString("search the name: ");
                        index = Search(name, count, input);
                        if (index == -1)
                            Console.WriteLine(
                                "{0} not found", input);
                        else
                            Console.WriteLine(
                                "{0} found at {1}", input, index);
                        break;
                    case "remove":
                        Console.WriteLine("remove is invoked");
                        input = iw.getString("name to be removed: ");
                        index = Search(name, count, input);
                        if (index != -1)
                        {
                            // Move names 
                            for (int i = index; i < count - 1; i++)
                                name[i] = name[i + 1];
                            count--;
                            Console.WriteLine("{0} has been removed", input);
                        }
                        else
                            Console.WriteLine("{0} not found", input);

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
            cmd = iw.getString(">");
        }
        public static int Search(string[] array, int count, string input)
        {
            int i = 0;
            bool search = false;
            while (!search && i < count)
            {
                if (input == array[i])
                    search = true;
                else
                    i++;
            }
            if (search)
                return i;
            else
                return -1;
        }
    }
}