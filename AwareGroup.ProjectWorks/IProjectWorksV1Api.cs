using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AwareGroup.ProjectWorks.Models;
using Refit;

namespace AwareGroup.ProjectWorks
{
    public interface IProjectWorksV1Api : IProjectWorksApi
    {
        [Get("/api/v1.0/Clients")]
        Task<List<Client>> GetClientAsync(int? page = null, int? pageSize = null, int? officeID = null, int? clientID = null, bool? includeCustomFields = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Post("/api/v1.0/Clients")]
        Task<Client> CreateClientAsync([Body]Client request);

        [Get("/api/v1.0/Clients/BillingContacts")]
        Task<List<BillingContact>> GetBillingContactAsync(int? page = null, int? pageSize = null, int? billingContactID = null, int? clientID = null, string email = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Delete("/api/v1.0/Clients/BillingContacts/{billingContactID}")]
        Task DeleteBillingContactAsync(int billingContactID);

        [Get("/api/v1.0/Clients/FinancePaymentTermTypes")]
        Task<List<ClientFinancePaymentTermType>> GetClientFinancePaymentTermTypeAsync();

        [Get("/api/v1.0/Clients/Types")]
        Task<List<ClientType>> GetClientTypeAsync();

        [Delete("/api/v1.0/Clients/{clientID}")]
        Task DeleteClientsAsync(int clientID);

        [Patch("/api/v1.0/Clients/{clientID}")]
        Task<Client> UpdateClientsAsync(int clientID, [Body]object request);

        [Put("/api/v1.0/Clients/{clientID}")]
        Task<Client> ReplaceClientsAsync(int clientID, [Body]Client request);

        [Post("/api/v1.0/Clients/{clientID}/BillingContacts")]
        Task<List<BillingContact>> CreateOrUpdateBillingContactAsync(int clientID, [Body]BillingContact request);

        [Put("/api/v1.0/Clients/{clientID}/Fields")]
        Task<List<CustomFieldEntity>> ReplaceCustomFieldAsync(int clientID, [Body]object request);

        [Get("/api/v1.0/Clients/{clientID}/RateCards")]
        Task<List<ClientRateCard>> GetClientRateCardAsync(int clientID);

        [Get("/api/v1.0/Common/Agreements")]
        Task<List<Agreement>> GetAgreementAsync();

        [Get("/api/v1.0/Common/Countries")]
        Task<List<Country>> GetCountryAsync();

        [Get("/api/v1.0/Common/Currencies")]
        Task<List<Currency>> GetCurrencyAsync();

        [Get("/api/v1.0/Common/GLCodes")]
        Task<List<GLCode>> GetGLCodeAsync();

        [Get("/api/v1.0/Common/HolidayCalendars")]
        Task<List<HolidayCalendar>> GetHolidayCalendarAsync();

        [Get("/api/v1.0/Common/RateCards")]
        Task<List<RateCard>> GetRateCardAsync();

        [Get("/api/v1.0/Common/WorkWeeks")]
        Task<List<WorkWeek>> GetWorkWeekAsync();

        [Get("/api/v1.0/CustomFields/EntitySubTypes")]
        Task<List<CustomFieldEntitySubType>> GetCustomFieldEntitySubTypeAsync();

        [Get("/api/v1.0/CustomFields/EntityTypes")]
        Task<List<CustomFieldEntityType>> GetCustomFieldEntityTypeAsync();

        [Get("/api/v1.0/CustomFields/Types")]
        Task<List<CustomFieldType>> GetCustomFieldTypeAsync();

        [Get("/api/v1.0/Modules")]
        Task<List<Module>> GetModuleAsync(int? page = null, int? pageSize = null, int? projectID = null, int? moduleID = null, bool? includeCustomFields = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Post("/api/v1.0/Modules")]
        Task<Module> CreateModulesAsync([Body]Module request);

        [Get("/api/v1.0/Modules/BudgetFrequencies")]
        Task<List<ModuleBudgetFrequency>> GetBudgetFrequencyAsync();

        [Get("/api/v1.0/Modules/BudgetTypes")]
        Task<List<ModuleBudgetType>> GetBudgetTypeAsync();

        [Delete("/api/v1.0/Modules/{moduleID}")]
        Task DeleteModulesAsync(int moduleID);

        [Patch("/api/v1.0/Modules/{moduleID}")]
        Task<Module> UpdateModulesAsync(int moduleID, [Body]object request);

        [Put("/api/v1.0/Modules/{moduleID}")]
        Task<Module> ReplaceModulesAsync(int moduleID, [Body]Module request);

        [Get("/api/v1.0/Positions")]
        Task<List<Position>> GetPositionAsync();

        [Get("/api/v1.0/Projects")]
        Task<List<Project>> GetProjectAsync(int? page = null, int? pageSize = null, int? clientID = null, int? projectID = null, bool? includeCustomFields = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Post("/api/v1.0/Projects")]
        Task<Project> CreateProjectsAsync([Body]Project request);

        [Get("/api/v1.0/Projects/Statuses")]
        Task<List<ProjectStatus>> GetProjectStatuseAsync();

        [Get("/api/v1.0/Projects/TaskSelfServiceModes")]
        Task<List<ProjectTaskSelfServiceMode>> GetTaskSelfServiceModeAsync();

        [Get("/api/v1.0/Projects/Types")]
        Task<List<ProjectType>> GetProjectTypeAsync();

        [Delete("/api/v1.0/Projects/{projectID}")]
        Task DeleteProjectsAsync(int projectID);

        [Patch("/api/v1.0/Projects/{projectID}")]
        Task<Project> UpdateProjectsAsync(int projectID, [Body]object request);

        [Put("/api/v1.0/Projects/{projectID}")]
        Task<Project> ReplaceProjectsAsync(int projectID, [Body]Project request);

        [Get("/api/v1.0/Ranks")]
        Task<List<Rank>> GetRankAsync();

        [Post("/api/v1.0/ServiceDesk/CreateOrUpdateTask")]
        Task<ServiceDeskTask> CreateOrUpdateTaskAsync([Body]ServiceDeskTask request);

        [Get("/api/v1.0/Tasks")]
        Task<List<ProjectTask>> GetTasksAsync(int? page = null, int? pageSize = null, int? moduleID = null, int? taskID = null, bool? includeCustomFields = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Post("/api/v1.0/Tasks")]
        Task<ProjectTask> CreateTasksAsync([Body]ProjectTask request);

        [Get("/api/v1.0/Tasks/AllocationTypes")]
        Task<List<AllocationType>> GetAllocationTypeAsync();

        [Patch("/api/v1.0/Tasks/{taskID}")]
        Task<List<ProjectTask>> UpdateTasksAsync(int taskID, [Body]object request);

        [Put("/api/v1.0/Tasks/{taskID}")]
        Task<ProjectTask> ReplaceTasksAsync(int taskID, [Body]ProjectTask request);

        [Put("/api/v1.0/Tasks/{taskID}/Users")]
        Task<List<UserTask>> CreateOrReplaceUserTaskAsync(int taskID, [Body]UserTask request);

        [Delete("/api/v1.0/Tasks/{taskID}/Users/{userID}")]
        Task DeleteUserTaskAsync(int taskID, int userID);

        [Get("/api/v1.0/Tasks/{taskID}/Users/{userID}")]
        Task<ProjectTask> GetUserTaskAsync(int taskID, int userID);

        [Patch("/api/v1.0/Tasks/{taskID}/Users/{userID}")]
        Task<UserTask> UpdateUserTaskAsync(int taskID, int userID, [Body]object request);

        [Get("/api/v1.0/Teams")]
        Task<List<Team>> GetTeamAsync();

        [Delete("/api/v1.0/Timesheets")]
        Task DeleteTimesheetsAsync(int userID, int taskID, DateTimeOffset date);

        [Get("/api/v1.0/Timesheets")]
        Task<List<TimeEntry>> GetTimesheetsAsync(int? page = null, int? pageSize = null, int? userID = null, int? taskID = null, DateTimeOffset? date = null, string comment = null, string userExternalReference = null, string taskExternalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Put("/api/v1.0/Timesheets")]
        Task<TimeEntry> CreateOrUpdateTimesheetsAsync([Body]TimeEntry request);

        [Get("/api/v1.0/Users")]
        Task<List<User>> GetUsersAsync(int? page = null, int? pageSize = null, int? userID = null, string email = null, bool? includeCustomFields = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Post("/api/v1.0/Users")]
        Task<User> CreateUsersAsync([Body]User request);

        [Get("/api/v1.0/Users/Roles")]
        Task<List<UserRole>> GetUserRoleAsync();

        [Delete("/api/v1.0/Users/{userID}")]
        Task DeleteUsersAsync(int userID);

        [Patch("/api/v1.0/Users/{userID}")]
        Task<User> UpdateUsersAsync(int userID, [Body]object request);

        [Put("/api/v1.0/Users/{userID}")]
        Task<User> ReplaceUsersAsync(int userID, [Body]User request);

        [Delete("/api/v1.0/Users/{userID}/Postings")]
        Task DeleteUserPostingAsync(int userID, DateTimeOffset startDate);

        [Get("/api/v1.0/Users/{userID}/Postings")]
        Task<List<UserPosting>> GetUserPostingAsync(int userID);

        [Put("/api/v1.0/Users/{userID}/Postings")]
        Task<UserPosting> CreatePostingAsync(int userID, [Body]UserPosting request);

        [Delete("/api/v1.0/Users/{userID}/Roles")]
        Task DeleteUserRoleAsync(int userID, [Body]UserRole request);

        [Put("/api/v1.0/Users/{userID}/Roles")]
        Task<List<UserRole>> UpdateUserRoleAsync(int userID, [Body]UserRole request);

    }
}
