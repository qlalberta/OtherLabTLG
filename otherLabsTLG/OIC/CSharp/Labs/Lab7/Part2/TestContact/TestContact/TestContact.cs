using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestContact
{
    public static void Main(string[] args)
    {
        Contact cont;
        cont = new Contact();
        cont.ChangeID(5);
        ShowContact(cont);
        Contact cont2 = new Contact(6, "tst", "tst@test.com");
        ShowContact(cont2);
    }

    private static void ShowContact(Contact cont)
    {
        Console.WriteLine("Contact id is {0}, contact name is {1} and contact email is {2}", cont.GetId(), cont.GetName(), cont.GetEmail());
    }
}
