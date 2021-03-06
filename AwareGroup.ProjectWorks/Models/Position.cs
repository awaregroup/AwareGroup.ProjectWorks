using System;

namespace AwareGroup.ProjectWorks.Models
{
    public class Position
    {
        public bool IsActive { get; set; }
        public bool IsShadowable { get; set; }
        public DateTimeOffset ModifiedDateUTC { get; set; }
        public string Name { get; set; }
        public int PositionID { get; set; }
        public int SortOrder { get; set; }
    }
}
