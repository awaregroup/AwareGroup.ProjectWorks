using System;
using System.Collections.Generic;

namespace AwareGroup.ProjectWorks.Models
{
    public class User
    {
        public DateTimeOffset BirthDate { get; set; }
        public List<CustomFieldEntity> CustomFields { get; set; } = new List<CustomFieldEntity>();
        public string Email { get; set; }
        public DateTimeOffset EmployeeEndDate { get; set; }
        public DateTimeOffset EmployeeStartDate { get; set; }
        public string ExternalReference { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
        public string JobTitle { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset ModifiedDateUTC { get; set; }
        public int UserID { get; set; }
    }
}
