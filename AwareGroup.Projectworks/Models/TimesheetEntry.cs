using System;

namespace AwareGroup.Projectworks.Models
{
    public class TimesheetEntry
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int TaskID { get; set; }
        public string TaskName { get; set; }

        public DateTimeOffset Date { get; set; }
        public int Minutes { get; set; }
        public string Comment { get; set; }
        public DateTimeOffset ModifiedDateUTC { get; set; }
    }
}
