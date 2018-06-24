using System;
using System.Collections.Generic;

namespace AwareGroup.ProjectWorks.Models
{
    public class UserRole
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public List<object> UserRoleIDs { get; set; } = new List<object>();
    }
}
