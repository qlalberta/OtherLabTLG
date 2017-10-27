using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract public class Policy
{
    static private int NumPolicy = 0; 
    private int id ; 
    private string name;
    protected decimal propertyLimit;
    protected decimal liabilityLimit;
    protected string policyStatus;
    protected string startTime;
    protected string endTime;
    public int Id
    {
        get
        {
            return id;
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public decimal PropertyLimit
    {
        get
        {
            return propertyLimit;
        }
        set
        {
            propertyLimit = value;
        }
    }
    public decimal LiabilityLimit
    {
        get
        {
            return liabilityLimit;
        }
        set
        {
            liabilityLimit = value;
        }
    }
    //public int this[string PolicyStatus]
    //{
    //    get
    //    {
    //        return (GetStatus(policyStatus));
    //    }
    //}
    //public GetStatus(string )
    //{

    //}
    public string StartTime
    {
        get
        {
            return startTime;
        }
        set
        {
            startTime = value;
        }
    }
    public string EndTime
    {
        get
        {
            return endTime;
        }
        set
        {
            endTime = value;
        }
    }
    public string PolicyStatus
    {
        get
        {
            return policyStatus;
        }
        set
        {
            policyStatus = value;
        }
    }
    public Policy(int id,decimal propertyLimit, decimal liabilityLimit, string name, string polilcyStatus, string startTime, string endTime)
    {
        this.id = id;
        this.propertyLimit = propertyLimit;
        this.liabilityLimit = liabilityLimit;
        this.name = name;
        this.startTime = startTime;
        this.endTime = endTime;
        NumPolicy++;
    }

    //may need to override the build-in string method.
    virtual public void ShowPolicy()
    {

        Console.WriteLine("Policy for {0}: Id is {1} Start date is {2} and End date is {3};",
            Name, Id, StartTime, EndTime);
    }

   //TODO:  need to finish the methods below.
    //virtual public string FindPolicy()
    //{
  
    //}

    //string FindAllPolicies()
    //{

    //}

    //string ShownAllPolicies()
    //{
    //    Console.WriteLine("");
    //}


}

