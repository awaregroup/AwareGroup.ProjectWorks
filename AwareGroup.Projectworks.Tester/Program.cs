using Microsoft.Extensions.Configuration;
using Refit;
using System;
using System.Net.Http;
using System.Text;

namespace AwareGroup.Projectworks.Tester
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
            var pw = ProjectworksApiFactory.GetApiClient<IProjectWorksV1Api>(apiBaseUrl, apiUsername, apiPassword);

            //test api
            pw.GetTasks(externalReference: "United Nations - Education Update").Result.ForEach(t => Console.WriteLine(t.TaskName));
            pw.GetUsers().Result.ForEach(u => Console.WriteLine($"{u.FirstName} {u.LastName} - {u.Email}"));
            pw.GetTimesheetEntries().Result.ForEach(t => Console.WriteLine($"{t.Date.Date} {t.UserID} {t.TaskID} - {t.Minutes}"));

            Console.ReadLine();
        }
    }
}
