using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace AwareGroup.ProjectWorks.Tester
{
    class Program
    {
        static async Task Main(string[] args)
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
            (await pw.GetTasks()).ForEach(t => Console.WriteLine(t.TaskName));
            (await pw.GetUsers()).ForEach(u => Console.WriteLine($"{u.FirstName} {u.LastName} - {u.Email}"));
            (await pw.GetTimesheets()).ForEach(t => Console.WriteLine($"{t.Date.Date} {t.UserID} {t.TaskID} - {t.Minutes}"));

            Console.ReadLine();
        }
    }
}
