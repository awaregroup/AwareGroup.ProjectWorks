using System;
using System.Collections.Generic;

namespace AwareGroup.ProjectWorks.Models
{
    public class Module
    {
        public double Budget { get; set; }
        public int BudgetFrequencyID { get; set; }
        public string BudgetFrequencyName { get; set; }
        public int BudgetTypeID { get; set; }
        public string BudgetTypeName { get; set; }
        public double BuyPrice { get; set; }
        public List<CustomFieldEntity> CustomFields { get; set; } = new List<CustomFieldEntity>();
        public string ExternalReference { get; set; }
        public string GLCodeCode { get; set; }
        public int GLCodeID { get; set; }
        public string GLCodeName { get; set; }
        public int GLCodeTypeID { get; set; }
        public string GLCodeTypeName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDiscount { get; set; }
        public DateTimeOffset ModifiedDateUTC { get; set; }
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public int ProjectID { get; set; }
        public string Projectname { get; set; }
        public List<object> Tasks { get; set; } = new List<object>();
    }
}
