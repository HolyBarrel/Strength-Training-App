using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StrengthTrainingApp.Services.Interfaces;
using StrengthTrainingApp.Utility;

namespace StrengthTrainingApp.Services.Implementations
{
    public class WorkoutService : IWorkoutService
    {
        /*
        public async Task<int> GetWorkoutForToday()
        {
            var response = await _httpClient.GetAsync("/rest/v1/full_workout?select=*");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonHelper.DeserializeWorkoutRecords(jsonString);
            }

            throw new Exception("The login was rejected due to invalid credentials");
        }

        public async Task CreateWorkout()
        {

        }
        */
    }
}
