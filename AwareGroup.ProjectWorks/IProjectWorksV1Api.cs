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
        Task<List<Client>> GetClients(int? page = null, int? officeID = null, int? clientID = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Post("/api/v1.0/Clients")]
        Task<Client> CreateClientClients([Body]Client request);

        [Delete("/api/v1.0/Clients/BillingContacts/{billingContactID}")]
        Task DeleteBillingContactClients(int billingContactID);

        [Get("/api/v1.0/Clients/FinancePaymentTermTypes")]
        Task<List<ClientFinancePaymentTermType>> GetClientFinancePaymentTermTypeClients();

        [Get("/api/v1.0/Clients/Types")]
        Task<List<ClientType>> GetClientTypes();

        [Delete("/api/v1.0/Clients/{clientID}")]
        Task DeleteClients(int clientID);

        [Get("/api/v1.0/Clients/{clientID}")]
        Task<Client> GetClientClients(int clientID);

        [Put("/api/v1.0/Clients/{clientID}")]
        Task<Client> UpdateClients(int clientID, [Body]Client request);

        [Get("/api/v1.0/Clients/{clientID}/BillingContacts")]
        Task<List<BillingContact>> GetBillingContacts(int clientID, int? page = null, int? billingContactID = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Post("/api/v1.0/Clients/{clientID}/BillingContacts")]
        Task<BillingContact> CreateOrUpdateBillingContactClients(int clientID, [Body]BillingContact request);

        [Get("/api/v1.0/Clients/{clientID}/RateCards")]
        Task<List<ClientRateCard>> GetClientRateCards(int clientID);

        [Get("/api/v1.0/Common/Agreements")]
        Task<List<Agreement>> GetAgreements();

        [Get("/api/v1.0/Common/Countries")]
        Task<List<Country>> GetCountries();

        [Get("/api/v1.0/Common/Currencies")]
        Task<List<Currency>> GetCurrencies();

        [Get("/api/v1.0/Common/GLCodes")]
        Task<List<GLCode>> GetGLCodes();

        [Get("/api/v1.0/Common/HolidayCalendars")]
        Task<List<HolidayCalendar>> GetHolidayCalendars();

        [Get("/api/v1.0/Common/RateCards")]
        Task<List<RateCard>> GetRateCards();

        [Get("/api/v1.0/Common/WorkWeeks")]
        Task<List<WorkWeek>> GetWorkWeeks();

        [Get("/api/v1.0/Modules")]
        Task<List<Module>> GetModules(int? page = null, int? projectID = null, int? moduleID = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Post("/api/v1.0/Modules")]
        Task<Module> CreateModules([Body]Module request);

        [Get("/api/v1.0/Modules/BudgetFrequencies")]
        Task<List<ModuleBudgetFrequency>> GetBudgetFrequencies();

        [Get("/api/v1.0/Modules/BudgetTypes")]
        Task<List<ModuleBudgetType>> GetBudgetTypes();

        [Delete("/api/v1.0/Modules/{moduleID}")]
        Task DeleteModules(int moduleID);

        [Get("/api/v1.0/Modules/{moduleID}")]
        Task<Module> GetModuleModules(int moduleID);

        [Put("/api/v1.0/Modules/{moduleID}")]
        Task<Module> UpdateModules(int moduleID, [Body]Module request);

        [Get("/api/v1.0/Positions")]
        Task<List<Position>> GetPositions();

        [Get("/api/v1.0/Projects")]
        Task<List<Project>> GetProjects(int? page = null, int? clientID = null, int? projectID = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Post("/api/v1.0/Projects")]
        Task<Project> CreateProjects([Body]Project request);

        [Get("/api/v1.0/Projects/Statuses")]
        Task<List<ProjectStatus>> GetProjectStatuses();

        [Get("/api/v1.0/Projects/TaskSelfServiceModes")]
        Task<List<ProjectTaskSelfServiceMode>> GetTaskSelfServiceModes();

        [Get("/api/v1.0/Projects/Types")]
        Task<List<ProjectType>> GetProjectTypes();

        [Delete("/api/v1.0/Projects/{projectID}")]
        Task DeleteProjects(int projectID);

        [Get("/api/v1.0/Projects/{projectID}")]
        Task<Project> GetProjectProjects(int projectID);

        [Put("/api/v1.0/Projects/{projectID}")]
        Task<Project> UpdateProjects(int projectID, [Body]Project request);

        [Get("/api/v1.0/Ranks")]
        Task<List<Rank>> GetRanks();

        [Post("/api/v1.0/ServiceDesk/CreateOrUpdateTask")]
        Task<ServiceDeskTask> CreateOrUpdateTaskServiceDesk([Body]ServiceDeskTask request);

        [Get("/api/v1.0/Tasks")]
        Task<List<ProjectTask>> GetTasks(int? page = null, int? moduleID = null, int? taskID = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Post("/api/v1.0/Tasks")]
        Task<ProjectTask> CreateTasks([Body]ProjectTask request);

        [Get("/api/v1.0/Tasks/{taskID}")]
        Task<List<ProjectTask>> GetTaskTasks(int taskID);

        [Put("/api/v1.0/Tasks/{taskID}")]
        Task<ProjectTask> UpdateTasks(int taskID, [Body]ProjectTask request);

        [Get("/api/v1.0/Teams")]
        Task<List<Team>> GetTeams();

        [Delete("/api/v1.0/Timesheets")]
        Task DeleteTimesheets(int userID, int taskID, DateTimeOffset date);

        [Get("/api/v1.0/Timesheets")]
        Task<List<TimeEntry>> GetTimesheets(int? page = null, int? userID = null, int? taskID = null, DateTimeOffset? date = null, string comment = null, string userExternalReference = null, string taskExternalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Put("/api/v1.0/Timesheets")]
        Task<TimeEntry> CreateOrUpdateTimesheets([Body]TimeEntry request);

        [Get("/api/v1.0/Users")]
        Task<List<User>> GetUsers(int? page = null, int? userID = null, string email = null, string name = null, string externalReference = null, DateTimeOffset? modifiedSinceDate = null);

        [Post("/api/v1.0/Users")]
        Task<User> CreateUsers([Body]User request);

        [Get("/api/v1.0/Users/Roles")]
        Task<List<UserRole>> GetUserRoles();

        [Delete("/api/v1.0/Users/{userID}")]
        Task DeleteUsers(int userID);

        [Get("/api/v1.0/Users/{userID}")]
        Task<User> GetUserUsers(int userID);

        [Put("/api/v1.0/Users/{userID}")]
        Task<User> UpdateUsers(int userID, [Body]User request);

        [Delete("/api/v1.0/Users/{userID}/Postings")]
        Task DeleteUserPostingUsers(int userID, DateTimeOffset startDate);

        [Get("/api/v1.0/Users/{userID}/Postings")]
        Task<List<UserPosting>> GetUserPostings(int userID);

        [Put("/api/v1.0/Users/{userID}/Postings")]
        Task<UserPosting> CreatePostingUsers(int userID, [Body]UserPosting request);

        [Delete("/api/v1.0/Users/{userID}/Roles")]
        Task DeleteUserRoles(int userID, [Body]UserRole request);

        [Put("/api/v1.0/Users/{userID}/Roles")]
        Task<List<UserRole>> UpdateUserRoles(int userID, [Body]UserRole request);

    }
}
