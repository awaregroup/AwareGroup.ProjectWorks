using System;

namespace AwareGroup.ProjectWorks.Models
{
    public class Agreement
    {
        public int AgreementID { get; set; }
        public int AgreementTypeID { get; set; }
        public string Code { get; set; }
        public bool IsContractor { get; set; }
        public string Name { get; set; }
    }
}
