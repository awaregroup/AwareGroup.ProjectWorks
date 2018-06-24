using System;
using System.Collections.Generic;

namespace AwareGroup.Projectworks.Models
{
    public class ProjectTask
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }

        public int ModuleID { get; set; }
        public string ModuleName { get; set; }

        public int TaskTypeID { get; set; }
        public string TaskTypeName { get; set; }

        public int TaskStatusID { get; set; }
        public string TaskStatusName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double? PercentComplete { get; set; }

        public bool IsOnTimesheet { get; set; }
        public bool EnforceTimesheetDates { get; set; }
        public bool IsCommentRequired { get; set; }
        public bool IsScheduledTask { get; set; }
        public bool IsAutoSchedule { get; set; }

        public List<int> Users { get; set; }

        public string ExternalReference { get; set; }
        public DateTimeOffset ModifiedDateUTC { get; set; }
    }
}
