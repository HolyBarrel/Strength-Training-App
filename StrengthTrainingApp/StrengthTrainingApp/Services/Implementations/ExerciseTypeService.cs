using StrengthTrainingApp.DataTransferObjects;
using StrengthTrainingApp.Utility;
using StrengthTrainingApp.Services.Interfaces;

namespace StrengthTrainingApp.Services.Implementations
{
    public class ExerciseTypeService : ServiceBase, IExerciseTypeService
    {
        public ExerciseTypeService(HttpClient httpClient) : base(httpClient) { }

        public async Task<List<ExerciseType>> GetAllExerciseTypes()
        {
            var response = await Client.GetAsync("/rest/v1/exercise_types?select=*");

            if (!response.IsSuccessStatusCode) throw new Exception("Fetching exercise types failed =(");

            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonHelper.DeserializeContent<List<ExerciseType>>(jsonString);

        }
    }
}
