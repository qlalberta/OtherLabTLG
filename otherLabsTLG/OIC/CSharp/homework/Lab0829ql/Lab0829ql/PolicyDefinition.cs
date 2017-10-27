using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//interface for policy insurance object
interface IPolicy
{
    int Id { get; }
    string Name { get; set; }
    decimal PropertyLimit { get; set; }
    decimal LiabilityLimit { get; set; }
    //TODO: It may be better to use indexer for PolicyStatus; 
    //int this [string PolicyStatus] { get; set; }
    string PolicyStatus { get; set; }
    string StartTime { get; set; }
    string EndTime { get; set; }
    //string FindPolicy();
    void ShowPolicy();
    //string FindAllPolicies();
    //string ShownAllPolicies();
}

//interface for housing insurance policy
interface IHousingPolicy
{
    int ParcelId { get; }
    string PropertyType { get; set; }
    string PostCode { get; set; }
}

//interface for vehicle insurance policy
interface IVehiclePolicy
{
    string VIN { get; }
    string VehicleType { get; set; }
}