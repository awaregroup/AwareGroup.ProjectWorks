using Refit;
using System;
using System.Net.Http;
using System.Text;

namespace AwareGroup.ProjectWorks
{
    public static class ProjectWorksApiFactory
    {
        /// <summary>
        /// Added generics for future compatibility reasons
        /// </summary>
        public static T GetApiClient<T>(string apiBaseUrl, string apiUsername, string apiPassword) where T : IProjectWorksApi
        {
            //set up HttpClient
            var apiHttpClient = new HttpClient();
            apiHttpClient.BaseAddress = new Uri(apiBaseUrl);
            apiHttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{apiUsername}:{apiPassword}")));

            //set up api client
            var api = RestService.For<T>(apiHttpClient);
            return api;
        }
    }
}
