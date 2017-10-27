using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TestPolicy
{
    static void Main(string[] args)
    {
        //TODO: use command loop to show and find policies
        Policy[] policy = new Policy[3];
        policy[0] = new HomeOwnerLine
            (33, "Duplex", "98001", 1, 300000, 2000000, "Kathy", "applied for",
            "2016-5-6", "2017-5-6");
        policy[1] = new RentersLine
            (45, "SingleFamily", "98000", 55, 2, 30000, 200000, "Rachel", "Bound", "2013-5-6", "2014-5-6");
        policy[2] = new MotorCycleLine
            ("343525335vkj", "TwoWheel",
            3, 20000, 20000, "Jay", "Bound", "2013-5-6", "2014-5-6");
        policy[0].ShowPolicy(); //works//
        Console.WriteLine(policy[0].Name); //works

        InputWrapper iw = new InputWrapper();
        string cmd;
        Console.WriteLine("Enter the id to find the policy");
        cmd = iw.getString("> ");

        for (int i = 0; i < policy.Length; i++)
        {
            if (cmd.Equals(policy[i].Id.ToString()))
            {
                policy[i].ShowPolicy();
            }

        }
    }
}

