using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// interface for ControlConsolDefinition
/// </summary>
interface IController
{
    /// <summary>
    /// interface for motion, power and temperature control
    /// </summary>
    int MotorId { get; }
    string Time { get; }
    string DeviceName { get; set; }
    decimal Temp { get; set; }
    decimal Speed { get; set; }
    Boolean Power { get; set; }
}

/// <summary>
/// interface for data collection
/// </summary>
interface IDataCollector
{
    int MotorId { get; }
    string DeviceName { get; }
    decimal Temp { get; }
    decimal Speed { get; }
    ///<returns>return numbers of motors</returns>
    int GetMotorNumber();
    ///<returns>return temperature</returns>
    decimal GetTemp();
    ///<returns>return speed</returns>
    decimal GetSpeed();
}

/// <summary>
/// interface for data analysis
/// </summary>
interface IDataAnalyzer
{
    /// <param name="id"></param>
    int MotorId(int id);
    string DeviceName { get; }
    decimal Temp { get; }
    decimal Speed { get; }
    ///<returns>return numbers of motors</returns>
    int GetMotorNumber();
    ///<returns>return Input</returns>
    decimal GetInput { get; set; }
    ///<returns>return Output</returns>
    decimal GetOutput { get; set; }
    ///<returns>return Throughputs</returns>
    decimal GetThroughputs { get; set; }
}

