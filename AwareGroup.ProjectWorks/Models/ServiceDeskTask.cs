using System;
using System.Collections.Generic;

namespace AwareGroup.ProjectWorks.Models
{
    public class ServiceDeskTask
    {
        public string AssignedUserEmail { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public List<object> Fields { get; set; } = new List<object>();
        public bool IsTaskCreated { get; set; }
        public bool IsTaskUpdated { get; set; }
        public bool IsUserTaskCreated { get; set; }
        public int ModuleID { get; set; }
        public int ProjectID { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskStatus { get; set; }
        public string UserEmail { get; set; }
        public bool UserExists { get; set; }
        public bool UserTaskExists { get; set; }
    }
}
