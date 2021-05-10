using RITRemake.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RITRemake.Controllers;

namespace RITRemake.Services
{
    public class ISTClient
    {

        private static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Creates a client able to consume the http://ist.rit.edu/api
        /// </summary>
        /// See <see href="https://docs.microsoft.com/en-us/dotnet/api/system.net.http.headers.httprequestheaders?view=net-5.0"/>
        /// to learn more about HttpRequestHeaders.
        static ISTClient()
        {
            client.BaseAddress = new Uri("http://ist.rit.edu");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        /// <summary>
        /// Method that gets the About
        /// </summary>
        /// <returns>About</returns>
        public static async Task<About> GetAboutAsync()
        {
            Task<string> stringTask = client.GetStringAsync("http://ist.rit.edu/api/about");
            string msg = await stringTask;
            About about = JsonConvert.DeserializeObject<About>(msg);
            return about;
        }
        /// <summary>
        /// Method which takes parameter of location and awaits the client GetAsync method on that location
        /// Deserializes the object from json to our list and returns it
        /// </summary>
        /// <param name="loc"></param>
        /// <returns>EmploymentViewModel</returns>
        public static async Task<EmploymentViewModel> GetISTTableAsync (String loc)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(loc, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                var tableList = JsonConvert.DeserializeObject<EmploymentViewModel>(data);
                return tableList;
            }
            catch (HttpRequestException hre)
            {
                var msg = hre.Message;
                EmploymentViewModel tableList = new EmploymentViewModel();
                return tableList;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                EmploymentViewModel tableList = new EmploymentViewModel();
                return tableList;
            }

        }
        /// <summary>
        /// Method which also takes parameter location and returns object of DegreesViewModel,
        /// Deserializes from json and returns it
        /// </summary>
        /// <param name="loc"></param>
        /// <returns>DegreesViewModel</returns>
        public static async Task<DegreesViewModel> GetISTAsync(String loc)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(loc,
                    HttpCompletionOption.ResponseHeadersRead);
                // throws an exception if not successful
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                
                    var facultyList = JsonConvert.DeserializeObject<DegreesViewModel>(data);
                    return facultyList;                
            }
            catch (HttpRequestException hre)
            {
                var msg = hre.Message;
                DegreesViewModel facultyList = new DegreesViewModel();
                return facultyList;

            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                DegreesViewModel facultyList = new DegreesViewModel();                
                return facultyList;
                //return "Exception"; ;
            }

        }

    }
}
