using System;
using System.Collections.Generic;

namespace AwareGroup.ProjectWorks.Models
{
    public class Client
    {
        public int AccountManagerID { get; set; }
        public string AccountManagerName { get; set; }
        public List<object> BillingContacts { get; set; } = new List<object>();
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public int ClientTypeID { get; set; }
        public string ClientTypeName { get; set; }
        public List<CustomFieldEntity> CustomFields { get; set; } = new List<CustomFieldEntity>();
        public int DefaultRateCardID { get; set; }
        public string ExternalReference { get; set; }
        public string FinanceEmail { get; set; }
        public string FinanceNotes { get; set; }
        public int FinancePaymentTermDays { get; set; }
        public int FinancePaymentTermTypeID { get; set; }
        public string FinancePaymentTermTypeName { get; set; }
        public string FinancePhone { get; set; }
        public bool IsInvoiceReferenceRequired { get; set; }
        public DateTimeOffset ModifiedDateUTC { get; set; }
        public int OfficeID { get; set; }
        public string OfficeName { get; set; }
        public List<object> Projects { get; set; } = new List<object>();
        public bool SendBillingContactEmail { get; set; }
        public bool SendClientFinanceEmail { get; set; }
    }
}
