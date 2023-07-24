using StrengthTrainingApp.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StrengthTrainingApp.Utility;
using StrengthTrainingApp.Services.Interfaces;

namespace StrengthTrainingApp.Services.Implementations
{
    public class FullWorkoutService : ServiceBase, IFullWorkoutService
    {
        public FullWorkoutService(HttpClient httpClient) : base(httpClient) { }

        public async Task<List<FullWorkoutRecord>> GetAllFullWorkoutRecords()
        {
            var response = await Client.GetAsync("/rest/v1/full_workout?select=*");

            if (!response.IsSuccessStatusCode) throw new Exception("Fetching full workout records failed =(");

            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonHelper.DeserializeContent<List<FullWorkoutRecord>>(jsonString);

        }
    }
}
