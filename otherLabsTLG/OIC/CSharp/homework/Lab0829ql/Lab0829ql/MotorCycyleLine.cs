using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MotorCycleLine : Policy, IPolicy, IVehiclePolicy
{
    private string vin;
    private string vehicleType;

    public string VIN
    {
        get
        {
            return vin;
        }
    }

    public string VehicleType
    {
        get
        {
            return vehicleType;
        }
        set
        {
           vehicleType = value;
        }
    }

    public MotorCycleLine(
        string vin, string VehicleType, int id, decimal propertyLimit, decimal liabilityLimit, string name, string polilcyStatus, string startTime, string endTime)
     : base(id, propertyLimit, liabilityLimit, name, polilcyStatus, startTime, endTime)
    {

    }

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
