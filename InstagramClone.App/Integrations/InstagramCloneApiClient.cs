using InstagramClone.App.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace InstagramClone.App.Integrations
{
    public class InstagramCloneApiClient : IInstagramCloneApiClient
    {
        private readonly HttpClient httpClient;

        public InstagramCloneApiClient(HttpClient httpClient, IConfiguration config)
        {
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = new Uri(config.GetValue<string>("InstagramCloneApiUrl"));
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var requestUri = "users";

            return await httpClient.GetFromJsonAsync<List<User>>(requestUri);
        }

        public async Task<User> GetUser(int userId)
        {
            var requestUri = "users/" + userId;
            return await httpClient.GetFromJsonAsync<User>(requestUri);
        }
        
        public async Task CreateUser(string username, string email, string forename, string surname, int age, decimal rating)
        {

        }
    }
}
