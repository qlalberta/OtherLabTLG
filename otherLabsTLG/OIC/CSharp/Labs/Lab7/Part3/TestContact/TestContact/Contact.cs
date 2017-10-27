using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Contact
{
    public const int MAXLENGTH = 20;
    private readonly int id;
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
        if (name.Length > MAXLENGTH)
        {
            name = name.Substring(0, MAXLENGTH);
        }
        if (email.Length > MAXLENGTH)
        {
            char sep = '@';
            string[] emailTrucated = email.Split(sep);
            email = emailTrucated[0].Substring(0, MAXLENGTH) + sep + emailTrucated[1];
        }
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
    public void ChangeId(int newId)
    {
        //id = newId;
    }
    public void ChangeName(string newName)
    {
        if (newName.Length > MAXLENGTH)
        {
            newName = newName.Substring(0, MAXLENGTH);
        }
        name = newName;
    }
    public void ChangeEmail(string newEmail)
    {
        if (newEmail.Length > MAXLENGTH)
        {
            char sep = '@';
            string[] emailTrucated = newEmail.Split(sep);
            newEmail = emailTrucated[0].Substring(0, MAXLENGTH) + sep + emailTrucated[1];
        }
        email = newEmail;
    }

}
