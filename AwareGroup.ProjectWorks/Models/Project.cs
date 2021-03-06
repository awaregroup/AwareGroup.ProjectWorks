using System;
using System.Collections.Generic;

namespace AwareGroup.ProjectWorks.Models
{
    public class Project
    {
        public int AccountManagerID { get; set; }
        public string AccountManagerName { get; set; }
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string CurrencyCode { get; set; }
        public int CurrencyID { get; set; }
        public List<CustomFieldEntity> CustomFields { get; set; } = new List<CustomFieldEntity>();
        public bool DefaultInvoicesToForecastAmount { get; set; }
        public int DefaultRateCardID { get; set; }
        public string ExternalReference { get; set; }
        public int HolidayCalendarID { get; set; }
        public string HolidayCalendarName { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset ModifiedDateUTC { get; set; }
        public List<object> Modules { get; set; } = new List<object>();
        public int OfficeID { get; set; }
        public string OfficeName { get; set; }
        public int ProjectID { get; set; }
        public int ProjectManagerID { get; set; }
        public string ProjectManagerName { get; set; }
        public string ProjectName { get; set; }
        public int ProjectStatusID { get; set; }
        public string ProjectStatusName { get; set; }
        public int ProjectTypeID { get; set; }
        public string ProjectTypeName { get; set; }
        public bool SendInvoicesToBillingContactEmail { get; set; }
        public bool SendInvoicesToFinanceEmail { get; set; }
        public int TaskSelfServiceModeID { get; set; }
        public string TaskSelfServiceModeName { get; set; }
    }
}
