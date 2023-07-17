using StrengthTrainingApp.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StrengthTrainingApp.Utility;

namespace StrengthTrainingApp.Services
{
    public class FullWorkoutService : IFullWorkoutService
    {
        private HttpClient _httpClient;

        public FullWorkoutService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://xpyatpstjihpnjgujeae.supabase.co");
            httpClient.DefaultRequestHeaders.Add("apikey",
                "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InhweWF0cHN0amlocG5qZ3VqZWFlIiwicm9sZSI6ImFub24iLCJpYXQiOjE2ODk0NTYzODksImV4cCI6MjAwNTAzMjM4OX0.myL9-ihnfoeXybqknHzloFTdTz8Trr72Jb1yDYUXElg");
            _httpClient = httpClient;
        }

        public async Task Setup()
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + await SecureStorage.GetAsync("access_token"));
        }
        public async Task<List<FullWorkoutRecord>> GetAllFullWorkoutRecords()
        {
            var response = await _httpClient.GetAsync("/rest/v1/full_workout?select=*");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonHelper.DeserializeWorkoutRecords(jsonString);
            }

            throw new Exception("The login was rejected due to invalid credentials");
        }
    }
}
