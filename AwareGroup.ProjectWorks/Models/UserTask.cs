using System;

namespace AwareGroup.ProjectWorks.Models
{
    public class UserTask
    {
        public int AllocationTypeID { get; set; }
        public string AllocationTypeName { get; set; }
        public string FirstName { get; set; }
        public double Hours { get; set; }
        public bool IsActive { get; set; }
        public string LastName { get; set; }
        public double Rate { get; set; }
        public int RateCardID { get; set; }
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public int UserID { get; set; }
    }
}
