using BPDTSTestApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BPDTSTestApp.Services
{
    public class APIService : IAPISerrvice
    {
        HttpClient client;
        public APIService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<List<User>> GetUsers(string location)
        {
            string configValueAll = ConfigurationManager.AppSettings["userslocation"];
            string configValueCity = ConfigurationManager.AppSettings["userslondonlocation"];

            List<User> users = new List<User>();

            if (location == null)
            {
                try
                {
                    //Sending request to find web api REST service resource using HttpClient  
                    HttpResponseMessage response = await client.GetAsync(configValueAll);

                    //Storing the response details recieved from web api
                    string jsonUsers = response.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the list  
                    users = JsonConvert.DeserializeObject<List<User>>(jsonUsers);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("bpdts-test-app API Unavailable: {0}", ex);
                }
            }
            else
            {
                try
                {
                    //Sending request to find web api REST service resource using HttpClient  
                    HttpResponseMessage response = await client.GetAsync(configValueCity);

                    //Storing the response details recieved from web api   
                    string jsonUsers = response.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the list  
                    users = JsonConvert.DeserializeObject<List<User>>(jsonUsers);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("bpdts-test-app API Unavailable: {0}", ex);
                }
            }

            return users.ToList();
        }
    }
}