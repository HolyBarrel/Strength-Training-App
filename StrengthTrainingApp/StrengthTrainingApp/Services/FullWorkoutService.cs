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
    public class FullWorkoutService : ServiceBase, IFullWorkoutService
    {
        public FullWorkoutService(HttpClient httpClient) : base(httpClient) {}

        public async Task<List<FullWorkoutRecord>> GetAllFullWorkoutRecords()
        {
            var response = await Client.GetAsync("/rest/v1/full_workout?select=*");

            if (!response.IsSuccessStatusCode) throw new Exception("The login was rejected due to invalid credentials");

            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonHelper.DeserializeWorkoutRecords(jsonString);

        }
    }
}
