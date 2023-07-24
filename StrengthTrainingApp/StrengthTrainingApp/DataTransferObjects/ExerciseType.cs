using Newtonsoft.Json;

namespace StrengthTrainingApp.DataTransferObjects
{
    public class ExerciseType
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("muscle_group")]
        public string MuscleGroup { get; set; }

        [JsonProperty("primary_muscle")]
        public string PrimaryMuscle { get; set; }
    }
}
