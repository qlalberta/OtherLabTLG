using System;
using System.Collections.Generic;
using System.Text;

class AccountList
{
    private Account[] accounts;
    private int nextid = 1;
    private int count = 0;
    public AccountList 
    {
        accounts = new Account[10];
    }
   
    public int Add(decimal bal, string owner)
    {
        Account acc;
        int id = nextid++;
        acc = new Account(bal, owner, id);
        accounts[count++] = acc;
        return id;
    }
    public Account this[int index]
    {
        get
        {
         
        }
        
    }



}

