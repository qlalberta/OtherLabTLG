using System;
using System.Collections.Generic;
using System.Text;



class InterestCheckingAccount : Account
{
    private decimal fee = 5.00m;
    private const int FREEXACT = 2;
    private decimal minBalance;
    private decimal rate = 0.012m;

    public InterestCheckingAccount(decimal balance, string owner, int id)
		: base(balance, owner, id)
	{
        minBalance = balance;
    }
    public decimal Fee
    {
        get
        {
            if (numXact > FREEXACT)
                return fee;
            else if (balance < minBalance)
                return 2 * fee;
            else
                return 0.00m;
        }
    }

    public decimal Interest
    {
        get
        {
            return minBalance * rate / 12;
        }
    }
    public void Post()
    {
        if (balance < minBalance)
            balance -= Fee;
    }
    new public string GetStatement()
    {
        string s = base.GetStatement();
        s += ", interest = " + Interest;
        return s;
    }

}

