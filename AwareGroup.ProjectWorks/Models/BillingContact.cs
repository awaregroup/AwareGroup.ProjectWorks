using System;

namespace AwareGroup.ProjectWorks.Models
{
    public class BillingContact
    {
        public int BillingContactID { get; set; }
        public string CityOrState { get; set; }
        public int ClientID { get; set; }
        public string ContactEmail { get; set; }
        public string ContactEmailCc { get; set; }
        public string ContactName { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string ExternalReference { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset ModifiedDateUTC { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalAddress3 { get; set; }
        public string Postcode { get; set; }
    }
}
