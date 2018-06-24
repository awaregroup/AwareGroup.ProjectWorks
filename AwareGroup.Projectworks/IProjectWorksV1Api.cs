using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AwareGroup.Projectworks.Models;
using Refit;

namespace AwareGroup.Projectworks
{
    public interface IProjectWorksV1Api : IProjectWorksApi
    {
        [Get("/api/v1.0/Tasks")]
        Task<List<ProjectTask>> GetTasks(int? taskID = null, int? moduleID = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Get("/api/v1.0/Users")]
        Task<List<User>> GetUsers(int? userID = null, int? email = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Get("/api/v1.0/Timesheets")]
        Task<List<TimesheetEntry>> GetTimesheetEntries(int? userID = null, int? taskID = null, DateTime? date = null, string comment = null, string userExternalReference = null, string taskExternalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Put("/api/v1.0/Timesheets")]
        Task<TimesheetEntry> PutTimesheetEntry([Body]TimesheetEntry timesheetEntry);
    }
}
