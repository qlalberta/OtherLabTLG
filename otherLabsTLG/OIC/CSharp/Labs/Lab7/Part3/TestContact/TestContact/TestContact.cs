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
        cont = new Contact(7, "testetstetsetetsteatetstestetewtwetertetetet", "testetestetestaetetetaewtetwetewtetioerweruieotewth@gmail.com");
        ShowContact(cont);
        cont.ChangeEmail("hahahahhahahahhahahahhahahahahahahahahahahahhaahiiiiiiiiiiiiii@test.org");
        ShowContact(cont);
    }

    private static void ShowContact(Contact cont)
    {
        Console.WriteLine("Contact id is {0}, contact name is {1} and contact email is {2}", cont.GetId(), cont.GetName(), cont.GetEmail());
     
    }
}
