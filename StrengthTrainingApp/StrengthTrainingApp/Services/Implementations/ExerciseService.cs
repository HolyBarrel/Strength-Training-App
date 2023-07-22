using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrengthTrainingApp.DataTransferObjects;
using StrengthTrainingApp.Pages;
using StrengthTrainingApp.Services.Interfaces;
using StrengthTrainingApp.Utility;

namespace StrengthTrainingApp.Services.Implementations
{
    public class ExerciseService : ServiceBase, IExerciseService
    {
        public ExerciseService(HttpClient client) : base(client) { }

        public async Task CreateExercise(ExerciseEssentials exercise)
        {
            EnsureSetup();

            var response = await Client.PostAsync("/rest/v1/exercises", JsonHelper.SerializeContent(exercise));

            if (!response.IsSuccessStatusCode)
            {

                throw new Exception("Failed to create sets.");

            }
        }
    }
}
