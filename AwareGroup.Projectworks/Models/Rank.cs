using System;
using System.Collections.Generic;

namespace AwareGroup.ProjectWorks.Models
{
    public class Rank
    {
        public bool IsActive { get; set; }
        public DateTimeOffset? ModifiedDateUTC { get; set; }
        public string Name { get; set; }
        public int RankID { get; set; }
        public int SortOrder { get; set; }
    }
}
