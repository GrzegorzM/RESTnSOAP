using System;
using System.Runtime.Serialization;

namespace WCFproject.Models
{
    //[Serializable] // Generates XML for web service by including only private fields.
    //[DataContract] // Generates XML for web service by including only fields decorated with [DataMember] attribute.
    //[DataContract(Namespace = "http://companyName.com/Employee")] // Change target namespace
    public class Employee
    {
        //[DataMember] // Works on private fields.
        //private int id;

        //[DataMember] // Include this property for serialization ([DataContract] attribute is required)
        public int Id { get; set; }

        //[DataMember(Name = "", Order = 1)] // Order - Sorting order, Name - Change name of property
        public string Name { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}