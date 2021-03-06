using System;
using System.Collections.Generic;

namespace AwareGroup.ProjectWorks.Models
{
    public class ProjectTask
    {
        public List<CustomFieldEntity> CustomFields { get; set; } = new List<CustomFieldEntity>();
        public DateTimeOffset EndDate { get; set; }
        public bool EnforceTimesheetDates { get; set; }
        public string ExternalReference { get; set; }
        public bool IsAutoSchedule { get; set; }
        public bool IsCommentRequired { get; set; }
        public bool IsOnTimesheet { get; set; }
        public bool IsScheduledTask { get; set; }
        public DateTimeOffset ModifiedDateUTC { get; set; }
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public int PercentComplete { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public int TaskStatusID { get; set; }
        public string TaskStatusName { get; set; }
        public int TaskTypeID { get; set; }
        public string TaskTypeName { get; set; }
        public List<object> Users { get; set; } = new List<object>();
    }
}
