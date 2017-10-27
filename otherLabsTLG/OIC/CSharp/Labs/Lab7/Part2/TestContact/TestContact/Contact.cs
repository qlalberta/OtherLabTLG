//part3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Contact
{
    private int id;
    private string name;
    private string email;
    public Contact()
    {

    }
    public Contact(int id)
    {
        this.id = id;
    }
    public Contact(int id, string name, string email)
    {
        this.id = id;
        this.name = name;
        this.email = email;
    }
    public int GetId()
    {
        return id;
    }
    public string GetName()
    {
        return name;
    }
    public string GetEmail()
    {
        return email;
    }
    public void ChangeID(int newId)
    {
        id = newId;
    }
    public void ChangeName(string newName)
    {
        name = newName;
    }
    public void ChangeEmail(string newEmail)
    {
        email = newEmail;
    }

}
