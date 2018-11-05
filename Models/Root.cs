using System;
using Newtonsoft.Json;

namespace ScribeLabs.Connector.HelloFlex.Models
{

    public class AuthResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
    }


    public class EmployersRoot
    {
        public employers[] Employer { get; set; }
    }

    public class employers
    {
        [JsonIgnore]
        public string search { get; set; }

        public string guid { get; set; }
        public string parentGuid { get; set; }
        public string agencyGuid { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string legalName { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string number { get; set; }
        public string unit { get; set; }
        public string organizationTypeId { get; set; }
        public string entityStateId { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string totalHoursPerWeek { get; set; }
        public string debtorNumber { get; set; }
        public string contactPersonGuid { get; set; }
        public string contactPersonName { get; set; }
        public DateTime lastUpdateDateUtc { get; set; }
    }
    

    public interface IItem { }

    public class Rootobject
    {
        public IItem[] Items { get; set; }
    }
    public class Test : IItem { }
}
