using System;

namespace AwareGroup.ProjectWorks.Models
{
    public class RateCard
    {
        public string CurrencyCode { get; set; }
        public int CurrencyID { get; set; }
        public string Description { get; set; }
        public string ExternalReference { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public DateTimeOffset ModifiedDateUTC { get; set; }
        public string Name { get; set; }
        public int RateCardID { get; set; }
    }
}
