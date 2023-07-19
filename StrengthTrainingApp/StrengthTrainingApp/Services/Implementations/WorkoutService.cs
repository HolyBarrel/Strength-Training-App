using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using StrengthTrainingApp.Services.Interfaces;
using StrengthTrainingApp.Utility;

namespace StrengthTrainingApp.Services.Implementations
{
    public class WorkoutService : ServiceBase, IWorkoutService
    {
        public WorkoutService(HttpClient client) : base(client) {}

        public override async Task Setup()
        {
            await base.Setup();
            Client.DefaultRequestHeaders.Add("Prefer", "return=representation");
        }

        public async Task<long> GetWorkoutForToday()
        {
            var response = await Client.GetAsync("/rest/v1/rpc/get_todays_workout");
            
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();

                long workoutId;

                if (jsonString is "null" or "")
                {
                    workoutId = await CreateWorkout();

                }
                else
                {
                    workoutId = long.Parse(jsonString);
                }

                if (workoutId > -1)
                {
                    return workoutId;
                }
            }

            throw new Exception("The service could not fetch the intended workout id");
        }

        public async Task<long> CreateWorkout()
        {
            EnsureSetup(); 
            
            var response = await Client.PostAsync("/path/to/your/workout/endpoint", null);

            if (response.IsSuccessStatusCode)
            {
                
                var responseJson = JObject.Parse(await response.Content.ReadAsStringAsync());

                if (responseJson.TryGetValue("id", out var idValue))
                {
                    return long.Parse(idValue.ToString());
                }
                else
                {
                    throw new Exception("Failed to parse workout ID from response.");
                }
            }
            else
            {
                throw new Exception("Failed to create workout.");
            }
        }

    }
}
