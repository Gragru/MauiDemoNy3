using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiDemoNy3.ViewModels
{
    internal class UserPageViewModel
    {
        public Models.User TheUser { get; set; }
            

        public UserPageViewModel()
        {
            var task = Task.Run(() => GetUserAsync());
            task.Wait();
            TheUser = task.Result;
        }

        public static async Task<Models.User> GetUserAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.api-ninjas.com/");
            client.DefaultRequestHeaders.Add("X-Api-Key", "E2O3R8zknVI8Lo/k0kdq7A==JBFTCWQdZStbgUQq");
            Models.User user = null;

            HttpResponseMessage response = await client.GetAsync("v1/randomuser/");
            if(response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                user = JsonSerializer.Deserialize<Models.User>(responseString);
            }
            return user;
        }

    }
}
