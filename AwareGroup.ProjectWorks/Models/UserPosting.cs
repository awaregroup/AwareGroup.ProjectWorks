using System;

namespace AwareGroup.ProjectWorks.Models
{
    public class UserPosting
    {
        public int AgreementID { get; set; }
        public double Cost { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public int HolidayCalendarID { get; set; }
        public bool IsBillable { get; set; }
        public int ManagerID { get; set; }
        public int OfficeID { get; set; }
        public int PositionID { get; set; }
        public int RankID { get; set; }
        public double Rate { get; set; }
        public int Recoverable { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public int TeamID { get; set; }
        public int UserID { get; set; }
        public int WorkWeekID { get; set; }
    }
}
