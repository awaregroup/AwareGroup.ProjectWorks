using Microsoft.Extensions.Configuration;
using System;

namespace AwareGroup.ProjectWorks.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Set up app config
            IConfiguration config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
#if DEBUG
                .AddJsonFile("appsettings.development.json", optional: true, reloadOnChange: true)
#endif
                .Build(); 
            #endregion

            //get settings
            var apiBaseUrl = config["ApiBaseUrl"]?.ToString();
            var apiUsername = config["ApiUsername"]?.ToString();
            var apiPassword = config["ApiPassword"]?.ToString();

            //get api client
            var pw = ProjectWorksApiFactory.GetApiClient<IProjectWorksV1Api>(apiBaseUrl, apiUsername, apiPassword);

            //test api
            pw.GetTasks().Result.ForEach(t => Console.WriteLine(t.TaskName));
            pw.GetUsers().Result.ForEach(u => Console.WriteLine($"{u.FirstName} {u.LastName} - {u.Email}"));
            pw.GetTimesheets().Result.ForEach(t => Console.WriteLine($"{t.Date.Value.Date} {t.UserID} {t.TaskID} - {t.Minutes}"));

            Console.ReadLine();
        }
    }
}
