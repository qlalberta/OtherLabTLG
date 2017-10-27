using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RentersLine : Policy, IPolicy, IHousingPolicy
{
    private int parcelId;
    private string propertyType;
    protected string postCode;
    protected int landloardId;

    public int ParcelId
    {
        get
        {
            return parcelId;
        }
    }

    public string PropertyType
    {
        get
        {
            return propertyType;
        }
        set
        {
            propertyType = value;
        }
    }
    public string PostCode
    {
        get
        {
            return postCode;
        }
        set
        {
            postCode = value;
        }
    }
    public int LandloardId
    {
        get
        {
            return landloardId;
        }
    }
    //need to more constructors
    public RentersLine(
        int parcelId, string propertyType, string postCode, int landloardId, int id, decimal propertyLimit, decimal liabilityLimit, string name, string polilcyStatus, string startTime, string endTime)
     : base(id, propertyLimit, liabilityLimit, name, polilcyStatus, startTime, endTime)
    {

    }

    //may need to overide the build-in string method and change the return type
    override public void ShowPolicy()
    {
        //string s = "Statement for " + Name + " id = " + Id + "\n"
        //     + " property limit is " + PropertyLimit + " liability limit is " + LiabilityLimit + "\n"
        //     + " start date: " + StartTime + "end date: " + EndTime;
        //return s;
       
        Console.WriteLine("Policy for {0}: Id is {1} Start date is {2} and End date is {3};",
            Name, Id, StartTime, EndTime);
    }


}


