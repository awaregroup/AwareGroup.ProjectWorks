using System;

namespace AwareGroup.Projectworks.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string JobTitle { get; set; }
        public DateTimeOffset EmployeeStartDate { get; set; }
        public DateTimeOffset EmployeeEndDate { get; set; }
        public bool IsActive { get; set; }
        public string ExternalReference { get; set; }
        public DateTimeOffset ModifiedDateUTC { get; set; }
    }
}
