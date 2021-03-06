using System;

namespace AwareGroup.ProjectWorks.Models
{
    public class GLCode
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string ExternalReference { get; set; }
        public int GLCodeID { get; set; }
        public int GLCodeTypeID { get; set; }
        public string GLCodeTypeName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDiscount { get; set; }
        public bool IsInterco { get; set; }
        public DateTimeOffset ModifiedDateUTC { get; set; }
    }
}
